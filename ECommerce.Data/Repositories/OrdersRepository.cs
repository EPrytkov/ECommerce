using ECommerce.Data.Entities;
using ECommerce.Data.Repositories.Interfaces;

namespace ECommerce.Data.Repositories;

public class OrdersRepository : BaseRepository<Order>, IOrdersRepository
{
    public OrdersRepository(ECommerceDbContext dbContext) : base(dbContext)
    {
    }
}