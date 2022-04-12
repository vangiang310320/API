using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.SlideService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhNhatShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlideController : ControllerBase
    {
        private readonly ISlideService slideService;
        public SlideController(ISlideService slideService)
        {
            this.slideService = slideService;
        }
        [HttpGet(nameof(GetSlide))]
        public IActionResult GetSlide(int id)
        {
            var result = slideService.GetSlide(id);
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("Not Found");
        }
        [HttpGet(nameof(GetAllSlide))]
        public IActionResult GetAllSlide()
        {
            var result = slideService.GetAllSlide();
            if (result is not null)
            {
                return Ok(result);
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertSlide))]
        public IActionResult InsertSlide(Slide slide)
        {
            slideService.InsertSlide(slide);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateSlide))]
        public IActionResult UpdateSlide(Slide slide)
        {
            slideService.UpdateSlide(slide);
            return Ok("Update success");

        }
        [HttpDelete(nameof(DeleteSlide))]
        public IActionResult DeleteSlide(int id)
        {
            slideService.DeleteSlide(id);
            return Ok("Delete success");
        }
    }
}
