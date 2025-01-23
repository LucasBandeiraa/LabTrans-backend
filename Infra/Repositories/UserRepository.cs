using Domain.Entities;
using Domain.Interfaces;
using Infra.Data;

namespace Kognit.Infra.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
