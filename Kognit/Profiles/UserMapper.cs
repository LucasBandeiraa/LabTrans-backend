using AutoMapper;
using Domain.Entities;
using Kognit.DTOs;

namespace kognit.Profiles
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<UserDTO, User>();
            CreateMap<User, UserDTO>();
        }
    }
}
