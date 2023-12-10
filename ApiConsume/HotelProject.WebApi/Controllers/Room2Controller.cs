using AutoMapper;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Room2Controller : ControllerBase
    {
        private readonly IRoomService roomService;
        private readonly IMapper mapper;

        public Room2Controller(IRoomService roomService, IMapper mapper)
        {
            this.roomService = roomService;
            this.mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddRoom2(AddRoomDto roomDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest();
            }

            var values = mapper.Map<Room>(roomDto);
            roomService.TInsert(values);
            return Ok();
        }
    }
}
