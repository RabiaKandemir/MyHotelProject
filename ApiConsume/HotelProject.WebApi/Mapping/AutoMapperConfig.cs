using AutoMapper;
using HotelProject.DtoLayer.Dtos.AppUserDto;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Room, RoomAddDto>().ReverseMap();
            CreateMap<Room, RoomUpdateDto>().ReverseMap();
            CreateMap<AppUser, ResultAppUserWithWorkLocationDto>().ForMember(dest => dest.WorkLocationName, opt => opt.MapFrom(src => src.WorkLocation.WorkLocationName)).ReverseMap();
        }
    }
}
