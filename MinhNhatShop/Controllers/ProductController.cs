using AutoMapper;
using DomainLayer.DTO;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhNhatShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IMapper _mapper;
        public ProductController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            _mapper = mapper;
        }
        [HttpGet(nameof(GetProduct))]
        public IActionResult GetProduct(int id)
        {
            var result = productService.GetProduct(id);
            if (result is not null)
            {
                return Ok(_mapper.Map<ProductDTO>(result));
            }
            return BadRequest("Not Found");
        }
        [HttpGet(nameof(GetAllProduct))]
        public IActionResult GetAllProduct()
        {
            var result = productService.GetAllProduct();
            if (result is not null)
            {
                return Ok(_mapper.Map<IEnumerable<ProductDTO>>(result));
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertProduct))]
        public IActionResult InsertProduct(ProductDTO productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);
            productService.InsertProduct(product);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateProduct))]
        public IActionResult UpdateProduct(ProductDTO productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);
            productService.UpdateProduct(product);
            return Ok("Update success");

        }
        [HttpDelete(nameof(DeleteProduct))]
        public IActionResult DeleteProduct(int id)
        {
            productService.DeleteProduct(id);
            return Ok("Delete success");
        }
    }
}
