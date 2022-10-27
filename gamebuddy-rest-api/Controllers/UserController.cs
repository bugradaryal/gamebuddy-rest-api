using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Entities;
using Business.Abstract;
using Business.Concrete;
using System.Data;
using System.Text.Json;

namespace gamebuddy_rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        public UserController()
        {
            _userService = new UserManager();
        }

        [Route("GetAllUser")]
        [HttpGet]
        public JsonResult GetAllUser()
        {
            return new JsonResult(_userService.GetAllUser());
        }

        [Route("GetUser")]
        [HttpGet]
        public JsonResult GetUser(User user)
        {
            return new JsonResult(_userService.GetUser(user.email, user.password));
        }

        [HttpGet("GetUserById/{id}")]
        public JsonResult GetUserById(int id)
        {
            return new JsonResult(_userService.GetUserById(id));
        }

        [Route("UpdateUser")]
        [HttpPut]
        public JsonResult UpdateUser(User user)
        {
            _userService.UpdateUser(user);
            return new JsonResult("Updated");
        }

        [Route("CreateUser")]
        [HttpPost]
        public JsonResult CreateUser(User user)
        {
            _userService.CreateUser(user);
            return new JsonResult("Created");
        }

        [HttpDelete("DeleteUser/{id}")]
        public JsonResult DeleteUser(int id)
        {
            _userService.DeleteUser(new User { id = id});
            return new JsonResult("Deleted");
        }
    }
}
