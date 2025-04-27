using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _RoomService;

        public RoomController(IRoomService RoomService)
        {
            _RoomService = RoomService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _RoomService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(Room Room)
        {
            _RoomService.TInsert(Room);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteRoom(int id)
        {
            var values = _RoomService.TGetById(id);
            _RoomService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateRoom(Room Room)
        {
            _RoomService.TUpdate(Room);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var values = _RoomService.TGetById(id);
            return Ok(values);
        }
    }
}
