using ECommerce.Data.Entities;

namespace ECommerce.Data.Repositories.Interfaces;

public interface IBaseRepository <TEntity> where TEntity : BaseEntity
{
    Task<TEntity?> GetAsync(Guid id, CancellationToken cancellationToken);
    Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);
    Task<Guid> CreateAsync(TEntity entity, CancellationToken cancellationToken);
}