using AutoMapper;
using DomainLayer.DTO;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.OrderService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhNhatShop.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;
        private readonly IMapper _mapper;
        public OrderController(IOrderService orderService, IMapper mapper)
        {
            this.orderService = orderService;
            _mapper = mapper;
        }
        [HttpGet(nameof(GetOrder))]
        public IActionResult GetOrder(int id)
        {
            var result = orderService.GetOrder(id);
            if (result is not null)
            {
                return Ok(_mapper.Map<OrderDTO>(result));
            }
            return BadRequest("Not Found");
        }
        [HttpGet(nameof(GetAllOrder))]
        public IActionResult GetAllOrder()
        {
            var result = orderService.GetAllOrder();
            if (result is not null)
            {
                return Ok(_mapper.Map<IEnumerable<OrderDTO>>(result));
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertOrder))]
        public IActionResult InsertOrder(OrderDTO orderDTO)
        {
            var order = _mapper.Map<Order>(orderDTO);
            orderService.InsertOrder(order);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateOrder))]
        public IActionResult UpdateOrder(OrderDTO orderDTO)
        {
            var order = _mapper.Map<Order>(orderDTO);
            orderService.UpdateOrder(order);
            return Ok("Update success");

        }
        [HttpDelete(nameof(DeleteOrder))]
        public IActionResult DeleteOrder(int id)
        {
            orderService.DeleteOrder(id);
            return Ok("Delete success");
        }
    }
}
