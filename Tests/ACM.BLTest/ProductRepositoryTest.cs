using System;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //arrange
            var productRespository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                Productdescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers"
        };
            //act
            var actual = productRespository.Retrieve(2);
            //assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.Productdescription, actual.Productdescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            //arrange
            var productRespository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                Productdescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };
            //act
            var actual = productRespository.Save(updatedProduct);
            //assert
            Assert.AreEqual(true, actual);
       
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //arrange
            var productRespository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                Productdescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };
            //act
            var actual = productRespository.Save(updatedProduct);

            //assert
            Assert.AreEqual(false, actual);

        }


    }
}
