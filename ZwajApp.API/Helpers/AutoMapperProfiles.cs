using System.Linq;
using AutoMapper;
using ZwajApp.API.DTOs;
using ZwajApp.API.Models;

namespace ZwajApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDto>()
             .ForMember(dest => dest.PhotoURL, opt => { opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url); })
             .ForMember(dest => dest.Age, opt => { opt.MapFrom(src => src.DateOfBirth.CalculateAge()); });

            CreateMap<User, UserForDetailsDto>()
             .ForMember(dest => dest.PhotoURL, opt => { opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url); })
             .ForMember(dest => dest.Age, opt => { opt.MapFrom(src => src.DateOfBirth.CalculateAge()); });

            CreateMap<Photo, PhotoForDetailsDto>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<PhotoForCreateDto, Photo>();
            CreateMap<Photo, PhotoForReturnDto>();
        }
    }
}