using ECommerce.Data.Entities;
using ECommerce.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data.Repositories;

public class CategoriesRepository : BaseRepository<Category>, ICategoriesRepository
{
    private readonly ECommerceDbContext _dbContext;

    public CategoriesRepository(ECommerceDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<IEnumerable<Category>> GetAllParentsAsync(CancellationToken cancellationToken)
    {
        return await _dbContext.Categories.Include(x => x.Children).AsNoTracking().Where(x => x.ParentCategoryId == null).ToListAsync(cancellationToken);
    }
}