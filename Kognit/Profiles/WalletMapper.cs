using AutoMapper;
using Domain.Entities;
using Kognit.DTOs;

namespace kognit.Profiles
{
    public class WalletMapper : Profile
    {
        public WalletMapper()
        {
            CreateMap<WalletDTO, Wallet>();
            CreateMap<Wallet, WalletDTO>();
        }
    }
}
