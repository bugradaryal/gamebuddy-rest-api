using Business.Abstract;
using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccess;
using System;

namespace gamebuddy_rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DbTestController : ControllerBase
    {
        private IMyGameService _myGameService;
        private IUserService _userService;


        public DbTestController()
        {
            _myGameService = new My_GameManager();
            _userService = new UserManager();
        }

        [HttpGet("{id}")]
        public JsonResult Test(int id)
        {
            try
            {
                User user = _userService.GetUserById(id);
                user.My_Game = _myGameService.GetUsersAllGame(new User { id = id });

                return new JsonResult(user);
            }
            catch (Exception err)
            {
                return new JsonResult(err);
            }
        }
    }
}
