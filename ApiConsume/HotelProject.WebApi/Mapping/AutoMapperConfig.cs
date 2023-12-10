using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrate;

namespace HotelProject.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Room, AddRoomDto>();
            CreateMap<AddRoomDto, Room>();

            CreateMap<Room,UpdateRoomDto>().ReverseMap();
        }
    }
}
