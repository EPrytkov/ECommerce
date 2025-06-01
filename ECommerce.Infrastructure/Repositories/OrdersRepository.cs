using ECommerce.Infrastructure.Entities;
using ECommerce.Infrastructure.Repositories.Interfaces;

namespace ECommerce.Infrastructure.Repositories;

public class OrdersRepository : BaseRepository<Order>, IOrdersRepository
{
    public OrdersRepository(ECommerceDbContext dbContext) : base(dbContext)
    {
    }
}