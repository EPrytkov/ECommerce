using ECommerce.Infrastructure.Entities;

namespace ECommerce.Infrastructure.Repositories.Interfaces;

public interface ICategoriesRepository : IBaseRepository<Category>
{
    Task<IEnumerable<Category>> GetAllParentsAsync(CancellationToken cancellationToken);
}