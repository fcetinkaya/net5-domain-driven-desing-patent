using Order.Domain.Events;
using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class Order : BaseEntity, IAggerateRoot
    {
        // Sadece içeriden SET edilmesi için private özelliği ekliyoruz.
        public DateTime OrderDate { get; private set; }
        public string Description { get; private set; }
        public string UserName { get; private set; }
        public string OrderStatus { get; private set; }

        public Adress Address { get; private set; }

        public ICollection<OrderItem> OrderItems { get; private set; }

        public Order(DateTime orderDate, string description, string username, string orderStatus, Adress address, ICollection<OrderItem> orderItems)
        {
            if (orderDate < DateTime.Now)
            {
                throw new Exception("Orderdate must be greater than now");
            }

            if (address.City == "")
            {
                throw new Exception("City Cannot be empty");
            }

            OrderDate = orderDate;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            UserName = username;
            OrderStatus = orderStatus ?? throw new ArgumentNullException(nameof(orderStatus));
            Address = address ?? throw new ArgumentNullException(nameof(address));
            OrderItems = orderItems ?? throw new ArgumentNullException(nameof(orderItems));

            AddDomainEvents(new OrderStartedDomainEvent(username,this));
        }


        public void AddOrderItem(int quantity, decimal price, int productId)
        {
            OrderItem item = new(quantity, price, productId);
            OrderItems.Add(item);
            
        }
    }
}
