using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhNhatShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet(nameof(GetUser))]
        public IActionResult GetUser(int id)
        {
            var result = userService.GetUser(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("Not Found");
        }
        [HttpGet(nameof(GetAllUser))]
        public IActionResult GetAllUser()
        {
            var result = userService.GetAllUser();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertUser))]
        public IActionResult InsertUser(User user)
        {
            userService.InsertUser(user);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateUser))]
        public IActionResult UpdateUser(User user)
        {
            userService.UpdateUser(user);
            return Ok("Update success");

        }
        [HttpDelete(nameof(DeleteUser))]
        public IActionResult DeleteUser(int id)
        {
            userService.DeleteUser(id);
            return Ok("Delete success");
        }
    }
}
