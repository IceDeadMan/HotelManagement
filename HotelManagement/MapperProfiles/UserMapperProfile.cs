using AutoMapper;
using HotelManagement.Models;
using HotelManagement.ViewModels.Users;

namespace HotelManagement.MapperProfiles
{
    /// <summary>
    /// Mapper profile for user-related mappings.
    /// Currently only the default mapping between register model and applicaiton user.
    /// </summary>
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<RegisterViewModel, ApplicationUser>();
        }
    }
}
