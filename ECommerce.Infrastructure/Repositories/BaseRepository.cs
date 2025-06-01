using ECommerce.Infrastructure;
using ECommerce.Infrastructure.Entities;
using ECommerce.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
{
    private readonly ECommerceDbContext _dbContext;

    public BaseRepository(ECommerceDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public Task<TEntity?> GetAsync(Guid id, CancellationToken cancellationToken)
    {
        return _dbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken)
    {
        return _dbContext.Set<TEntity>().ToListAsync(cancellationToken);
    }
    
    public async Task<Guid> CreateAsync(TEntity entity, CancellationToken cancellationToken)
    {
        _dbContext.Set<TEntity>().Add(entity);
        await _dbContext.SaveChangesAsync(cancellationToken);
        
        return entity.Id;
    }
}