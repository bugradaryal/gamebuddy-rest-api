using Business.Abstract;
using Business.Concrete;
using Microsoft.AspNetCore.Mvc;
using Entities;

namespace gamebuddy_rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class My_GameController : ControllerBase
    {

        private IMyGameService _myGameService;
        public My_GameController()
        {
            _myGameService = new My_GameManager();
        }

        [HttpGet("GetUsersAllGame/{id}")]
        public JsonResult GetUsersAllGame(int id)
        {
            return new JsonResult(_myGameService.GetUsersAllGame(new User { id = id }));
        }

        [HttpDelete("DeleteUsersGames/{id}")]
        public JsonResult DeleteUsersGames(int id)
        {
            _myGameService.DeleteUsersGames(new My_Game { id = id });
            return new JsonResult("Deleted");
        }

        [Route("AddUsersGame")]
        [HttpPost]
        public JsonResult AddUsersGame(My_Game my_Game)
        {
            _myGameService.AddUsersGame(my_Game);
            return new JsonResult("Created");
        }
    }
}
