using AutoMapper;
using DomainLayer.DTO;
using DomainLayer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.OrderDetailService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinhNhatShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService orderDetailService;
        private readonly IMapper _mapper;
        public OrderDetailController(IOrderDetailService orderDetailService, IMapper mapper)
        {
            this.orderDetailService = orderDetailService;
            _mapper = mapper;
        }
        [HttpGet(nameof(GetOrderDetail))]
        public IActionResult GetOrderDetail(int id)
        {
            var result = orderDetailService.GetOrderDetail(id);
            if (result is not null)
            {
                return Ok(_mapper.Map<OrderDetailDTO>(result));
            }
            return BadRequest("Not Found");
        }
        [HttpGet(nameof(GetAllOrderDetail))]
        public IActionResult GetAllOrderDetail()
        {
            var result = orderDetailService.GetAllOrderDetail();
            if (result is not null)
            {
                return Ok(_mapper.Map<IEnumerable<OrderDetailDTO>>(result));
            }
            return BadRequest("Not found");
        }
        [HttpPost(nameof(InsertOrderDetail))]
        public IActionResult InsertOrderDetail(OrderDetailDTO orderDetailDTO)
        {
            var orderDetail = _mapper.Map<OrderDetail>(orderDetailDTO);
            orderDetailService.InsertOrderDetail(orderDetail);
            return Ok("Insert success");
        }
        [HttpPut(nameof(UpdateOrderDetail))]
        public IActionResult UpdateOrderDetail(OrderDetailDTO orderDetailDTO)
        {
            var orderDetail = _mapper.Map<OrderDetail>(orderDetailDTO);
            orderDetailService.UpdateOrderDetail(orderDetail);
            return Ok("Update success");

        }
        [HttpDelete(nameof(DeleteOrderDetail))]
        public IActionResult DeleteOrderDetail(int id)
        {
            orderDetailService.DelateOrderDetail(id);
            return Ok("Delete success");
        }
    }
}
