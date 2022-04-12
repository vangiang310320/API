using AutoMapper;
using DomainLayer.DTO;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhNhatShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageController : ControllerBase
    {
        private readonly IProductImageService productImageService;
        private readonly IMapper _mapper;
        public ProductImageController(IProductImageService productImageService, IMapper mapper)
        {
            this.productImageService = productImageService;
            _mapper = mapper;
        }
        [HttpGet(nameof(GetProductImage))]
        public IActionResult GetProductImage(int id)
        {
            var result = productImageService.GetProductImage(id);
            if (result is not null)
            {
                return Ok(_mapper.Map<ProductImageDTO>(result));
            }
            return BadRequest("Not Found");
        }
        [HttpGet(nameof(GetAllProductImage))]
        public IActionResult GetAllProductImage()
        {
            var result = productImageService.GetAllProductImage();
            if (result is not null)
            {
                return Ok(_mapper.Map<IEnumerable<ProductImageDTO>>(result));
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertProductImage))]
        public IActionResult InsertProductImage(ProductImageDTO productImageDTO)
        {
            var productImage = _mapper.Map<ProductImage>(productImageDTO);
            productImageService.InsertproductImage(productImage);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateProductImage))]
        public IActionResult UpdateProductImage(ProductImageDTO productImageDTO)
        {
            var productImage = _mapper.Map<ProductImage>(productImageDTO);
            productImageService.UpdateProductImage(productImage);
            return Ok("Update success");

        }
        [HttpDelete(nameof(DeleteProductImage))]
        public IActionResult DeleteProductImage(int id)
        {
            productImageService.DeleteProductImage(id);
            return Ok("Delete success");
        }
    }
}
