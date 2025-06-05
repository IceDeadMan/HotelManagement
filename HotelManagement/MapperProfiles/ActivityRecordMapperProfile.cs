using AutoMapper;
using HotelManagement.Models;
using HotelManagement.ViewModels;

namespace HotelManagement.MapperProfiles
{
    public class ActivityRecordMapperProfile : Profile
    {
        public ActivityRecordMapperProfile()
        {
            CreateMap<ActivityRecord, ActivityRecordViewModel>()
                .ForMember(dest => dest.GuestName,
                           opt => opt.MapFrom(src => src.ApplicationUser != null ? src.ApplicationUser.FirstName + " " + src.ApplicationUser.LastName : "Unknown"))
                .ForMember(dest => dest.RoomNumber,
                           opt => opt.MapFrom(src => src.Room != null ? src.Room.RoomNumber : null));
        }
    }
}
