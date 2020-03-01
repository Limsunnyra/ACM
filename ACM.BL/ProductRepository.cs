using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {/// <summary>
     /// Retrieve one product
     /// </summary>
     /// <param name="productId"></param>
     /// <returns></returns>
        public Product Retrieve(int productId)
        {
            //Create the instance of the Product class
            //Pass in the requested Id
            Product product = new Product(productId);

            //Code that retireves the defined product

            //Temporary hard-coded values to return
            //a populated product
            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.Productdescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
                product.CurrentPrice = 15.96M;

            }
            Object myObject = new Object();
            Console.WriteLine($"Object: {myObject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }

        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //call an Insert Stored procedure
                    }
                    else
                    {
                       //call an update stored procedure

                    }
                }
                else
                {
                    success = false;
                }
            }
                return success;
            }
        }
    }
    
