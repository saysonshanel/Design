﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    interface ILogistics
    {
        void ShipProduct(string productName, string shippingAddress);
    }



    class LogisticsManager : ILogistics
    {
        public void ShipProduct(string productName, string shippingAddress)
        {
            Console.WriteLine("Congratulations your product "+ productName + " has been shipped  at the following address:  "+   shippingAddress);
        }
    }
}
