using Order.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.AggregateModels.OrderModels
{
    public class Adress : ValueObject
    {
        public string City { get; set; }
        public string Country { get; set; }



        protected override IEnumerable<object> GetEqulityComponents()
        {
            yield return City;
            yield return Country;
        }
    }
}
