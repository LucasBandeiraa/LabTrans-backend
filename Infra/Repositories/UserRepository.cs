using Domain.Entities;
using Domain.Interfaces;
using Infra.Data;

namespace LabTrans.Infra.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(LabTransContext context) : base(context)
        {

        }
    }
}
