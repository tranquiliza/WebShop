using Microsoft.AspNetCore.Mvc;
using System;
using WebShop.Contracts.Order;
using WebShop.Services.Interfaces;
using WebShop.Translaters;

namespace WebShop.Controllers
{
    [Produces("application/json")]
    [Route("api/Order")]
    public class OrderController : ControllerBase
    {
        //Rethink this entire controller to be a Basket instead. (So we add items to the basket serverside, and save it)
        //This saves us from having to deal with logic in the UI for basket, and it allows us to later on let customer retreive basket again.
        //Ontop of this, we already have the order saved, so we can easily create it. 


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
    }
}