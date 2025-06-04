using AutoMapper;
using HotelManagement.Models;
using HotelManagement.ViewModels;

namespace HotelManagement.MapperProfiles
{
    public class ReviewMapperProfile : Profile
    {
        public ReviewMapperProfile()
        {
            CreateMap<Review, ReviewViewModel>()
                .ForMember(dest => dest.ReviewerUsername,
                            opt => opt.MapFrom(src => src.ApplicationUser != null ? src.ApplicationUser.FirstName + " " + src.ApplicationUser.LastName : "Anonymous"))
                .ForMember(dest => dest.Rating,
                            opt => opt.MapFrom(src => src.Rating))
                .ForMember(dest => dest.Comment,
                            opt => opt.MapFrom(src => src.Comment))
                .ForMember(dest => dest.ReviewDate,
                            opt => opt.MapFrom(src => src.ReviewDate));
        }
    }
}
