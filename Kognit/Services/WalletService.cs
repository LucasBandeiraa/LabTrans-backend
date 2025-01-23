using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Kognit.DTOs;

namespace Kognit.Services
{
    public class WalletService : IWalletService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public WalletService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Create(WalletDTO walletDto)
        {
            var wallet = _mapper.Map<Wallet>(walletDto);
            await _unitOfWork.WalletRepository.Add(wallet);

            return _unitOfWork.Commit();
        }

        public async Task<IEnumerable<WalletDTO>> GetUserWallets(int userId)
        {
            var wallets = await _unitOfWork.WalletRepository.GetAllUsersWallets(userId);
            return  _mapper.Map<IEnumerable<WalletDTO>>(wallets);
        }
    }
}
