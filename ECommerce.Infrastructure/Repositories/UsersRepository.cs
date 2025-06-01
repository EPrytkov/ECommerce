using ECommerce.Infrastructure.Entities;
using ECommerce.Infrastructure.Repositories.Interfaces;

namespace ECommerce.Infrastructure.Repositories;

public class UsersRepository : BaseRepository<User>, IUsersRepository
{
    public UsersRepository(ECommerceDbContext dbContext) : base(dbContext)
    {
    }
}