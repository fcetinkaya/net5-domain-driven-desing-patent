using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class OrderItem : BaseEntity
    {
        // İçeriden SET edileceği için "private" değerini atıyoruz.
        public int Quantity { get; private set; }
        public decimal Price { get; private set; }
        public int ProductId { get; private set; }

        public OrderItem(int quantity, decimal price, int productId)
        {
            Quantity = quantity;
            Price = price;
            ProductId = productId;
        }

        // Validation rules will be here



    }
}
