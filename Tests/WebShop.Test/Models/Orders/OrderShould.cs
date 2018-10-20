using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Models.Orders;
using WebShop.Models.Products;
using Xunit;

namespace WebShop.Test.Models.Orders
{
    public class OrderShould
    {
        [Fact]
        public void CreateWithDefaultValues()
        {
            //Arrange

            //Act
            var sut = new Order();

            //Assert
            Assert.Equal(OrderStatus.OrderCreated, sut.OrderStatus);
        }

        [Fact]
        public void AddOrderLine()
        {
            //Arrange
            var sut = new Order();
            var product = new GiftcardProduct("MyTestGiftcardProduct", 1000);
            var orderLine = new OrderLine(1, product);

            //Act
            sut.AddOrderLine(orderLine);

            //Assert
            Assert.Equal(1, sut.OrderLineCount);
        }
    }
}
