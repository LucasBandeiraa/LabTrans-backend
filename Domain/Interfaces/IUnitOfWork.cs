namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository UserRepository { get; }
        IWalletRepository WalletRepository { get; }
        int Commit();
    }
}
