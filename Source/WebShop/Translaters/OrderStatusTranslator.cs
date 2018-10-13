using System;
using WebShop.Contracts.Order;
using WebShop.Models.Orders;

namespace WebShop.Translaters
{
    public static class OrderStatusTranslator
    {
        public static OrderStatus Map(this OrderStatusDto orderStatusDto)
        {
            switch (orderStatusDto)
            {
                case OrderStatusDto.Created:
                    return OrderStatus.OrderCreated;

                case OrderStatusDto.Placed:
                    return OrderStatus.OrderPlaced;

                case OrderStatusDto.Dispatched:
                    return OrderStatus.OrderDispatched;

                case OrderStatusDto.Completed:
                    return OrderStatus.OrderCompleted;

                default:
                    throw new NotImplementedException("Order Status Mapping not implemented DTO -> Model");
            }
        }

        public static OrderStatusDto Map(this OrderStatus orderStatus)
        {
            switch (orderStatus)
            {
                case OrderStatus.OrderCreated:
                    return OrderStatusDto.Created;

                case OrderStatus.OrderPlaced:
                    return OrderStatusDto.Placed;

                case OrderStatus.OrderDispatched:
                    return OrderStatusDto.Dispatched;

                case OrderStatus.OrderCompleted:
                    return OrderStatusDto.Completed;

                default:
                    throw new NotImplementedException("Order Status Mapping not implemented Model -> DTO");
            }
        }
    }
}
