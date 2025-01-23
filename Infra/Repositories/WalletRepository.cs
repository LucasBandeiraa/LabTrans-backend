using Domain.Entities;
using Domain.Interfaces;
using Infra.Data;

namespace Kognit.Infra.Repositories
{
    public class WalletRepository : GenericRepository<Wallet> , IWalletRepository
    {
        public WalletRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
