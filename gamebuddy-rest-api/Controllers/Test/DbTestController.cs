using Business.Abstract;
using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccess;
using System;
using System.Collections.Generic;

namespace gamebuddy_rest_api.Controllers.Test
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbTestController : ControllerBase
    {
        private IMyGameService _myGameService;
        private IUserService _userService;
        private IAllGameService _allGameService;


        public DbTestController()
        {
            _myGameService = new My_GameManager();
            _userService = new UserManager();
            _allGameService = new AllGameManager();
        }

        [HttpGet("{id}")]
        public JsonResult Test(int id)
        {
            try
            {
                User user = _userService.GetUserById(id);
                List<My_Game> my_Game = _myGameService.GetUsersAllGame(new User { id = id });
                foreach(var x in my_Game)
                {
                    x.AllGame = _allGameService.GetGameById(x.game_id);
                }
                user.My_Game = my_Game;
                return new JsonResult(user);
            }
            catch (Exception err)
            {
                return new JsonResult(err);
            }
        }
    }
}
