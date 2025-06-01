using ECommerce.Infrastructure.Entities;
using ECommerce.Infrastructure.Repositories.Interfaces;

namespace ECommerce.Infrastructure.Repositories;

public class ProductsRepository : BaseRepository<Product>, IProductsRepository
{
    public ProductsRepository(ECommerceDbContext dbContext) : base(dbContext)
    {
    }
}