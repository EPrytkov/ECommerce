using ECommerce.Data.Entities;

namespace ECommerce.Data.Repositories.Interfaces;

public interface ICategoriesRepository : IBaseRepository<Category>
{
    Task<IEnumerable<Category>> GetAllParentsAsync(CancellationToken cancellationToken);
}