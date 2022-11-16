using AutoMapper.Models;
using AutoMapper.Models.ViewModels;

namespace AutoMapper
{
    public class  UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserViewModel>()
                .ForMember(
                    dest => dest.FirstName,
                    opt => opt.MapFrom(src => $"{src.FirstName}")
                )
                .ForMember(
                    dest => dest.LastName,
                    opt => opt.MapFrom(src => $"{src.LastName}")
                )
                .ForMember(
                    dest => dest.Email,
                    opt => opt.MapFrom(src => $"{src.Email}")
                );
              
                
        }

    }
}
