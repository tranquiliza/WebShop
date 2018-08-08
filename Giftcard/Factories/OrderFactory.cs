using Giftcard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Giftcard.Factories
{
    public class OrderFactory
    {
        public void CreateOrder()
        {
            var order = Order.CreateNew();
        }
    }
}
