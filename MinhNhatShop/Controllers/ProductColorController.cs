using AutoMapper;
using DomainLayer.DTO;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ProductColorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhNhatShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductColorController : ControllerBase
    {
        private readonly IProductColorService productColorService;
        private readonly IMapper _mapper;
        public ProductColorController(IProductColorService productColorService, IMapper mapper)
        {
            this.productColorService = productColorService;
            _mapper = mapper;
        }
        [HttpGet(nameof(GetProductColor))]
        public IActionResult GetProductColor(int id)
        {
            var result = productColorService.GetProductColor(id);
            if (result is not null)
            {
                return Ok(_mapper.Map<ProductColorDTO>(result));
            }
            return BadRequest("Not Found");
        }
        [HttpGet(nameof(GetAllProductColor))]
        public IActionResult GetAllProductColor()
        {
            var result = productColorService.GetAllProductColor();
            if (result is not null)
            {
                return Ok(_mapper.Map<IEnumerable<ProductColorDTO>>(result));
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertProduct))]
        public IActionResult InsertProduct(ProductColorDTO productColorDTO)
        {
            var productColor = _mapper.Map<ProductColor>(productColorDTO);
            productColorService.InsertProductColor(productColor);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateProductColor))]
        public IActionResult UpdateProductColor(ProductColorDTO productColorDTO)
        {
            var productColor = _mapper.Map<ProductColor>(productColorDTO);
            productColorService.UpdateProductColor(productColor);
            return Ok("Update success");

        }
        [HttpDelete(nameof(DeleteProductColor))]
        public IActionResult DeleteProductColor(int id)
        {
            productColorService.DeleteProductColor(id);
            return Ok("Delete success");
        }
    }
}
