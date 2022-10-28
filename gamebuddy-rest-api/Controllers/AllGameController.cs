using Business.Abstract;
using Business.Concrete;
using Microsoft.AspNetCore.Mvc;
using Entities;

namespace gamebuddy_rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllGameController : ControllerBase
    {
        private IAllGameService _allGameService;
        public AllGameController()
        {
            _allGameService = new AllGameManager();
        }

        [Route("GetAllGames")]
        [HttpGet]
        public JsonResult GetAllGames()
        {
            return new JsonResult(_allGameService.GetAllGames());
        }

        [HttpDelete("DeleteGame/{id}")]
        public JsonResult DeleteGame(int id)
        {
            _allGameService.DeleteGame(new AllGame { id = id });
            return new JsonResult("Deleted");
        }

        [Route("AddGame")]
        [HttpPost]
        public JsonResult AddGame(AllGame allGame)
        {
            _allGameService.AddGame(allGame);
            return new JsonResult("Created");
        }

        [HttpGet("GetGameById/{id}")]
        public JsonResult GetGameById(int id)
        {
            return new JsonResult(_allGameService.GetGameById(id));
        }
    }
}
