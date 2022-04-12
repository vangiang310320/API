using AutoMapper;
using DomainLayer.DTO;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.CustomerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhNhatShop.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;
        private readonly IMapper _mapper;
        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            this.customerService = customerService;
            _mapper = mapper;
        }
        [HttpGet(nameof(GetCustomer))]
        public IActionResult GetCustomer(int id)
        {
            var result = customerService.GetCustomer(id);
            if (result is not null)
            {
                return Ok(_mapper.Map<CustomerDTO>(result));
            }
            return BadRequest("Not Found");
        }
        [HttpGet(nameof(GetAllCustomer))]
        public IActionResult GetAllCustomer()
        {
            var result = customerService.GetAllCustomer();
            if (result is not null)
            {
                return Ok(_mapper.Map<IEnumerable<CustomerDTO>>(result));
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertCustomer))]
        public IActionResult InsertCustomer(CustomerDTO customerDTO)
        {
            var customer = _mapper.Map<Customer>(customerDTO);
            customerService.InserCustomer(customer);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateCustomer))]
        public IActionResult UpdateCustomer(CustomerDTO customerDTO)
        {
            var customer = _mapper.Map<Customer>(customerDTO);
            customerService.UpdateCustomer(customer);
            return Ok("Update success");

        }
        [HttpDelete(nameof(DeleteCustomer))]
        public IActionResult DeleteCustomer(int id)
        {
            customerService.DeleteCustomer(id);
            return Ok("Delete success");
        }
    }
}
