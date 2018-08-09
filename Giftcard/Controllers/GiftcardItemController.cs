using Giftcard.Contracts;
using Giftcard.Repositories.Abstractions;
using Giftcard.Services.Abstractions;
using Giftcard.Translaters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Giftcard.Controllers
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
        public void UpdateOrderStatus(UpdateOrderStatusDto updateOrderStatusDto)
        {
            _orderService.UpdateOrderStatus(updateOrderStatusDto.OrderIdentifier, updateOrderStatusDto.OrderStatus.Map());
        }
    }
}