using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.common;
using System.Collections.Generic;
using ACM.BL;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange
            var changedItems = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "fBaggins@hobbinton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                Productdescription = "Garden rake with Steel head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);
            //Act
            LoggingService.WriteToFile(changedItems);

            //Assert

        }
    }
}
