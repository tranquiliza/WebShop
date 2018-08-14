using WebShop.Contracts.Order;
using WebShop.Services.Abstractions;
using WebShop.Translaters;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebShop.Controllers
{
    [Produces("application/json")]
    [Route("api/Order")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService ?? throw new ArgumentNullException(nameof(orderService));
        }

        [HttpPost("UpdateStatus")]
        public void UpdateStatus(UpdateOrderStatusDto updateOrderStatusDto)
        {
            _orderService.UpdateOrderStatus(updateOrderStatusDto.OrderIdentifier, updateOrderStatusDto.OrderStatus.Map());
        }

        [HttpPost("PlaceOrder")]
        public void PlaceOrder(PlaceOrderDto placeOrderDto)
        {
        }
    }
}