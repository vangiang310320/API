using AutoMapper;
using DomainLayer.DTO;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.CategorySevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhNhatShop.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        private readonly IMapper _mapper;//
        public CategoryController(ICategoryService categoryService, IMapper mapper)//
        {
            this.categoryService = categoryService;
            _mapper = mapper;//
        }
        [HttpGet(nameof(GetCategory))]
        public IActionResult GetCategory(int id)
        {
            var result = categoryService.GetCategory(id);
            if(result is not null)
            {
                return Ok(_mapper.Map<CategoryDTO>(result));//
            }
            return BadRequest("Not Fuond");
        }
        [HttpGet(nameof(GetAllCategory))]
        public IActionResult GetAllCategory()
        {
            var result = categoryService.GetAllCategory();
            if(result is not null)
            {
                return Ok(_mapper.Map<IEnumerable<CategoryDTO>>(result));//
            }
            return BadRequest("Not Found");
        }
        [HttpPost(nameof(InsertCategory))]
        public IActionResult InsertCategory(CategoryDTO categoryDTO)//
        {
            var category = _mapper.Map<Category>(categoryDTO);//
            categoryService.InsertCategory(category);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateCategory))]
        public IActionResult UpdateCategory(CategoryDTO categoryDTO)//
        {
            var category = _mapper.Map<Category>(categoryDTO);//
            categoryService.UpdateCategory(category);
            return Ok("Update success");
        }
        [HttpDelete(nameof(DeleteCategory))]
        public IActionResult DeleteCategory(int id)
        {
            categoryService.DeleteCategory(id);
            return Ok("Delete success");
        }
    }
}