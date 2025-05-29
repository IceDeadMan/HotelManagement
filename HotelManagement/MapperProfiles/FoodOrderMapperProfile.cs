using AutoMapper;
using HotelManagement.Models;
using HotelManagement.ViewModels;

namespace HotelManagement.MapperProfiles
{
    public class FoodOrderMapperProfile : Profile
    {
        public FoodOrderMapperProfile()
        {
            CreateMap<FoodOrder, FoodOrderViewModel>()
                .ForMember(dest => dest.GuestName,
                           opt => opt.MapFrom(src => src.ApplicationUser != null ? src.ApplicationUser.UserName : null))
                .ForMember(dest => dest.RoomNumber,
                           opt => opt.MapFrom(src => src.Room != null ? src.Room.RoomNumber : null))
                .ForMember(dest => dest.Foods,
                           opt => opt.MapFrom(src => src.Foods.Select(f => f.Name).ToList()));
        }
    }
}
