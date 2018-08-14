﻿using System;
using System.Collections.Generic;
using System.Text;
using WebShop.Models;
using Xunit;

namespace WebShop.Test.Models.Product
{
    public class GiftCardProductShould
    {
        [Fact]
        public void Be_Created_With_Name_And_Price()
        {
            //Arrange
            const string Name = "SomeName";
            const int Price = 1000;

            //Act
            var giftCardProduct = new GiftcardProduct(Name, Price);

            //Assert
            Assert.Equal(Name, giftCardProduct.Name);
            Assert.Equal(Price, giftCardProduct.Price);
        }

        [Fact]
        public void Be_Created_With_Name_Price_And_Description()
        {
            //Arrange
            const string Name = "SomeName";
            const string Description = "SomeDescription";
            const int Price = 1000;

            //Act
            var giftCardProduct = new GiftcardProduct(Name, Description, Price);

            //Assert
            Assert.Equal(Name, giftCardProduct.Name);
            Assert.Equal(Description, giftCardProduct.Description);
            Assert.Equal(Price, giftCardProduct.Price);
        }

        [Fact]
        public void Set_PriceOverrideable_True()
        {
            //Arrange
            var giftcardProduct = new GiftcardProduct("Test Item", 100);

            //Act
            giftcardProduct.SetPriceOverrideAble(true);

            //Assert
            Assert.True(giftcardProduct.IsPriceOverrideable);
        }

        [Fact]
        public void IsPriceOverrideable_Should_Default_False()
        {
            //Arrange
            var product = new GiftcardProduct("TestItem", 1000);

            //Act

            //Assert
            Assert.False(product.IsPriceOverrideable);
        }
    }
}
