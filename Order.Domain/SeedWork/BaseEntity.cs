using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.SeedWork
{
    // abstract yapıyoruz. Başka class'lara implement etmek için..
   public abstract class BaseEntity
    {
        public int Id { get; set; }

        // MediatR yüklendikten sonra yazılacak...
        private ICollection<INotification> domainEvents;
        public ICollection<INotification> DomainEvents => domainEvents;

        public void AddDomainEvents(INotification notification)
        {
            domainEvents ??= new List<INotification>();
            domainEvents.Add(notification);
        }
    }
}
