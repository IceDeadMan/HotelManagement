using AutoMapper;
using HotelManagement.Models;
using HotelManagement.ViewModels;

namespace HotelManagement.MapperProfiles
{
    public class BookingMapperProfile : Profile
    {
        public BookingMapperProfile()
        {
            CreateMap<Booking, BookingSummaryViewModel>()
                .ForMember(dest => dest.GuestName,
                           opt => opt.MapFrom(src => src.ApplicationUser != null ? src.ApplicationUser.UserName : "Unknown"))
                .ForMember(dest => dest.StartDate,
                           opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.EndDate,
                           opt => opt.MapFrom(src => src.EndDate))
                .ForMember(dest => dest.Status,
                           opt => opt.MapFrom(src => src.Status));
        }
    }
}
