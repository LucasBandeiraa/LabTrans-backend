namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IReservaRepository ReservaRepository { get; }
        int Commit();
    }
}
