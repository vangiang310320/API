using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.MenuService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhNhatShop.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService menuService;
        public MenuController(IMenuService menuService)
        {
            this.menuService = menuService;
        }
        [HttpGet(nameof(GetMenu))]
        public IActionResult GetMenu(int id)
        {
            var result = menuService.GetMenu(id);
            if(result is not null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpGet(nameof(GetAllMenu))]
        public IActionResult GetAllMenu()
        {
            var result = menuService.GetAllMenu();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertMenu))]
        public IActionResult InsertMenu(Menu menu)
        {
            menuService.InsertMenu(menu);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateMenu))]
        public IActionResult UpdateMenu(Menu menu)
        {
            menuService.UpdateMenu(menu);
            return Ok("Update success");

        }
        [HttpDelete(nameof(DeleteMenu))]
        public IActionResult DeleteMenu(int id)
        {
            menuService.DeleteMenu(id);
            return Ok("Delete success");
        }

    }
}
