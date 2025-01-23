using Domain.Entities;
using Kognit.DTOs;

namespace Kognit.Services
{
    public interface IWalletService
    {
        Task<IEnumerable<WalletDTO>> GetUserWallets(int userId);
        Task<int> Create(WalletDTO walletDto);

    }
}
