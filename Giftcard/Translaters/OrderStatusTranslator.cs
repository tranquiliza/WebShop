using Giftcard.Contracts;
using Giftcard.Models;
using System;

namespace Giftcard.Translaters
{
    public static class OrderStatusTranslator
    {
        public static OrderStatus Map(this OrderStatusDto orderStatusDto)
        {
            switch (orderStatusDto)
            {
                case OrderStatusDto.Created:
                    return OrderStatus.Created;

                case OrderStatusDto.Pending:
                    return OrderStatus.Pending;

                case OrderStatusDto.Accepted:
                    return OrderStatus.Accepted;

                case OrderStatusDto.Completed:
                    return OrderStatus.Completed;

                default:
                    throw new NotImplementedException("Order Status Mapping not implemented DTO -> Model");
            }
        }

        public static OrderStatusDto Map(this OrderStatus orderStatus)
        {
            switch (orderStatus)
            {
                case OrderStatus.Created:
                    return OrderStatusDto.Created;

                case OrderStatus.Pending:
                    return OrderStatusDto.Pending;

                case OrderStatus.Accepted:
                    return OrderStatusDto.Accepted;

                case OrderStatus.Completed:
                    return OrderStatusDto.Completed;

                default:
                    throw new NotImplementedException("Order Status Mapping not implemented Model -> DTO");
            }
        }
    }
}
