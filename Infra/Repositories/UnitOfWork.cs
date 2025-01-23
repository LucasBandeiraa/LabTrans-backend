using Domain.Entities;
using Domain.Interfaces;
using Infra.Data;

namespace Kognit.Infra.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ApplicationDbContext _context;
        public IUserRepository UserRepository { get; }
        public IWalletRepository WalletRepository { get; }


        public UnitOfWork(ApplicationDbContext context, IUserRepository users, IWalletRepository wallets)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            UserRepository = users ?? throw new ArgumentNullException(nameof(users));
            WalletRepository = wallets ?? throw new ArgumentNullException(nameof(wallets));
        }

        public int Commit()
        {
            return  _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
