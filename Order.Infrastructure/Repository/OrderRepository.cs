using Order.Application.Repository;
using System.Threading.Tasks;

namespace Order.Infrastructure.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public Task<int> SaveChangesAsync()
        {
            return Task.FromResult(1);
        }
    }

}
