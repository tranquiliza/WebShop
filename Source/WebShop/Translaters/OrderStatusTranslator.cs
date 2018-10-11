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

                case OrderStatusDto.Pending:
                    return OrderStatus.PaymentPending;

                case OrderStatusDto.Accepted:
                    return OrderStatus.PaymentAccepted;

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

                case OrderStatus.PaymentPending:
                    return OrderStatusDto.Pending;

                case OrderStatus.PaymentAccepted:
                    return OrderStatusDto.Accepted;

                case OrderStatus.OrderCompleted:
                    return OrderStatusDto.Completed;

                default:
                    throw new NotImplementedException("Order Status Mapping not implemented Model -> DTO");
            }
        }
    }
}
