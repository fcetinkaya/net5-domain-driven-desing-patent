using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class Buyer : BaseEntity
    {

        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Buyer(string userName)
        {
            userName = userName;
        }
    }
}
