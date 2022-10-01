using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Domain.SeedWork
{
    public abstract class ValueObject
    {
        protected static bool EqualOperator(ValueObject left, ValueObject right)
        {
            if (ReferenceEquals(left,null)^ReferenceEquals(right,null))
            {
                return false;
            }
            return ReferenceEquals(left, null) || left.Equals(right);
        }

        protected static bool NotEqualOperator(ValueObject left, ValueObject right)
        {
            return !EqualOperator(left, right);
        }

        // Karşılaştırma sadece memory olarak değil içindeki objeler ile birlikte yapılır.
        protected abstract IEnumerable<object> GetEqulityComponents();

        public override bool Equals(object obj)
        {
            if (obj==null || obj.GetType()!=GetType())
            {
                return false;
            }

            var other=(ValueObject)obj;

            return GetEqulityComponents().SequenceEqual(other.GetEqulityComponents());
        }

        public override int GetHashCode()
        {
            return GetEqulityComponents()
                  .Select(x => x != null ? x.GetHashCode() : 0)
                  .Aggregate((x, y) => x ^ y);
        }

        public ValueObject GetCopy()
        {
            return MemberwiseClone() as ValueObject; 
        }
    }
}
