using ECommerce.Data.Entities;
using ECommerce.Data.Repositories.Interfaces;

namespace ECommerce.Data.Repositories;

public class ProductsRepository : BaseRepository<Product>, IProductsRepository
{
    public ProductsRepository(ECommerceDbContext dbContext) : base(dbContext)
    {
    }
}