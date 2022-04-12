using AutoMapper;
using DomainLayer.DTO;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ProductSizeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhNhatShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductSizeController : ControllerBase
    {
        private readonly IProductSizeService productSizeService;
        private readonly IMapper _mapper;
        public ProductSizeController(IProductSizeService productSizeService, IMapper mapper)
        {
            this.productSizeService = productSizeService;
            _mapper = mapper;
        }
        [HttpGet(nameof(GetProductSize))]
        public IActionResult GetProductSize(int id)
        {
            var result = productSizeService.GetProductSize(id);
            if (result is not null)
            {
                return Ok(_mapper.Map<ProductSizeDTO>(result));
            }
            return BadRequest("Not Found");
        }
        [HttpGet(nameof(GetAllProductSize))]
        public IActionResult GetAllProductSize()
        {
            var result = productSizeService.GetAllProductSize();
            if (result is not null)
            {
                return Ok(_mapper.Map<IEnumerable<ProductSizeDTO>>(result));
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertProductSize))]
        public IActionResult InsertProductSize(ProductSizeDTO productSizeDTO)
        {
            var productSize = _mapper.Map<ProductSize>(productSizeDTO);
            productSizeService.InsertProductSize(productSize);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateProductSize))]
        public IActionResult UpdateProductSize(ProductSizeDTO productSizeDTO)
        {
            var productSize = _mapper.Map<ProductSize>(productSizeDTO);
            productSizeService.UpdateProductSize(productSize);
            return Ok("Update success");

        }
        [HttpDelete(nameof(DeleteProductSize))]
        public IActionResult DeleteProductSize(int id)
        {
            productSizeService.DeleteProductSize(id);
            return Ok("Delete success");
        }
    }
}
