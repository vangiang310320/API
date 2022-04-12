using AutoMapper;
using DomainLayer.DTO;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.SupplierService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhNhatShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService supplierService;
        private readonly IMapper _mapper;
        public SupplierController(ISupplierService supplierService, IMapper mapper)
        {
            this.supplierService = supplierService;
            _mapper = mapper;
        }
        [HttpGet(nameof(GetSupplier))]
        public IActionResult GetSupplier(int id)
        {
            var result = supplierService.GetSupplier(id);
            if (result is not null)
            {
                return Ok(_mapper.Map<SupplierDTO>(result));
            }
            return BadRequest("Not Found");
        }
        [HttpGet(nameof(GetAllSupplier))]
        public IActionResult GetAllSupplier()
        {
            var result = supplierService.GetAllSuppliers();
            if (result is not null)
            {
                return Ok(_mapper.Map<IEnumerable<SupplierDTO>>(result));
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertSupplier))]
        public IActionResult InsertSupplier(SupplierDTO supplierDTO)
        {
            var supplier = _mapper.Map<Supplier>(supplierDTO);
            supplierService.InsertSupplier(supplier);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateSupplier))]
        public IActionResult UpdateSupplier(SupplierDTO supplierDTO)
        {
            var supplier = _mapper.Map<Supplier>(supplierDTO);
            supplierService.UpdateSupplier(supplier);
            return Ok("Update success");

        }
        [HttpDelete(nameof(DeleteSupplier))]
        public IActionResult DeleteSupplier(int id)
        {
            supplierService.DeleteSupplier(id);
            return Ok("Delete success");
        }
    }
}
