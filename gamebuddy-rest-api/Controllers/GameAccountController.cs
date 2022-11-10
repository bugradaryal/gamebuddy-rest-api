using Business.Abstract;
using Business.Concrete;
using Microsoft.AspNetCore.Mvc;
using Entities;

namespace gamebuddy_rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameAccountController : ControllerBase
    {
        private IGameAccountService _gameAccountService;
        public GameAccountController()
        {
            _gameAccountService = new GameAccountManager();
        }

        [HttpGet("GetUsersAllAccounts/{id}")]
        public JsonResult GetUsersAllAccounts(int user_id)
        {
            return new JsonResult(_gameAccountService.GetUsersAllAccounts(user_id));
        }

        [HttpGet("GetUsersAccountsByGame/{id}")]
        public JsonResult GetUsersAccountsByGame(int my_game_id)
        {
            return new JsonResult(_gameAccountService.GetUsersAccountsByGame(my_game_id));
        }

        [HttpGet("GetSelectedAccount/{id}")]
        public JsonResult GetSelectedAccount(int id)
        {
            return new JsonResult(_gameAccountService.GetSelectedAccount(id));
        }

        [HttpDelete("DeleteAccount/{id}")]
        public JsonResult DeleteAccount(int id)
        {
            _gameAccountService.DeleteAccount(new GameAccount { id = id });
            return new JsonResult("Deleted");
        }

        [Route("CreateAccount")]
        [HttpPost]
        public JsonResult CreateAccount(GameAccount gameAccount)
        {
            _gameAccountService.CreateAccount(gameAccount);
            return new JsonResult("Created");
        }

        [Route("UpdateAccount")]
        [HttpPut]
        public JsonResult UpdateAccount(GameAccount gameAccount)
        {
            _gameAccountService.UpdateAccount(gameAccount);
            return new JsonResult("Updated");
        }
    }
}
