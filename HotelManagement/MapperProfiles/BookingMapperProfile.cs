using AutoMapper;
using HotelManagement.Models;
using HotelManagement.ViewModels;

namespace HotelManagement.MapperProfiles
{
    /// <summary>
    /// Maps Booking entities to BookingSummaryViewModel for displaying booking summaries.
    /// Special case for the guest name.
    /// </summary>
    public class BookingMapperProfile : Profile
    {
        public BookingMapperProfile()
        {
            CreateMap<Booking, BookingSummaryViewModel>()
                .ForMember(dest => dest.GuestName,
                           opt => opt.MapFrom(src => src.ApplicationUser != null ? (src.ApplicationUser.FirstName + " " + src.ApplicationUser.LastName) : "Unknown"))
                .ForMember(dest => dest.StartDate,
                           opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.EndDate,
                           opt => opt.MapFrom(src => src.EndDate))
                .ForMember(dest => dest.Status,
                           opt => opt.MapFrom(src => src.Status));
        }
    }
}
