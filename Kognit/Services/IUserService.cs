using Kognit.DTOs;

namespace Kognit.Services
{
    public interface IUserService
    {
        
        Task<int> Create(UserDTO userDto);
    }
}
