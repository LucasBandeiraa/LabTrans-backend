using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Kognit.DTOs;

namespace Kognit.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<int> Create(UserDTO userDto)
        {
            var user = _mapper.Map<User>(userDto);

            await _unitOfWork.UserRepository.Add(user);
            return _unitOfWork.Commit();
        }
    }
}
