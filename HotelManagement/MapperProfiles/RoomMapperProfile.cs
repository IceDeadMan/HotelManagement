using AutoMapper;
using HotelManagement.Models;
using HotelManagement.ViewModels;

namespace HotelManagement.MapperProfiles
{
    public class RoomMapperProfile : Profile
    {
        public RoomMapperProfile()
        {
            CreateMap<Room, RoomDetailViewModel>()
                .ForMember(dest => dest.RoomNumber,
                           opt => opt.MapFrom(src => src.RoomNumber!))
                .ForMember(dest => dest.Description,
                           opt => opt.MapFrom(src => src.Description!))
                .ForMember(dest => dest.RoomTypeName,
                           opt => opt.MapFrom(src => src.RoomType != null ? src.RoomType.Name : string.Empty))
                .ForMember(dest => dest.RoomTypeDescription,
                           opt => opt.MapFrom(src => src.RoomType != null ? src.RoomType.Description : string.Empty))
                .ForMember(dest => dest.RoomTypePrice,
                           opt => opt.MapFrom(src => src.RoomType != null ? src.RoomType.Price : 0m))
                .ForMember(dest => dest.RoomTypeCapacity,
                           opt => opt.MapFrom(src => src.RoomType != null ? src.RoomType.Capacity : 0))
                .ForMember(dest => dest.RoomTypePhoto,
                           opt => opt.MapFrom(src => src.RoomType != null ? src.RoomType.Photo : null));
        }
    }
}
