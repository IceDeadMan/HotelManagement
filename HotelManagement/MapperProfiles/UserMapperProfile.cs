using AutoMapper;
using HotelManagement.Models;
using HotelManagement.ViewModels.Users;

namespace HotelManagement.MapperProfiles
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<RegisterViewModel, ApplicationUser>();
        }
    }
}
