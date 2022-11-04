using Domain.Interfaces;
using Infra.Data;

namespace LabTrans.Infra.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly LabTransContext _context;
        public IUserRepository UserRepository { get; }
        public IReservaRepository ReservaRepository { get; }


        public UnitOfWork(LabTransContext context, IUserRepository users, IReservaRepository reservas)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            UserRepository = users ?? throw new ArgumentNullException(nameof(users));
            ReservaRepository = reservas ?? throw new ArgumentNullException(nameof(reservas));
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
