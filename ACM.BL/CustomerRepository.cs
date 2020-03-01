using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        /// <summary>
        /// retrieve one Customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public Customer Retrieve(int customerId)
        {
            //create the instance of the Customer class
            //pass in the requested id
            Customer customer = new Customer(customerId);

            //Code that retrieves the dfined customer

            //Temportary hard-coded values to return
            //a populated customer
            if(customerId == 1)
            {
                customer.EmailAddress = "fbaggings@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            //code that saves the passed in customer
            return true;
        }
    }
}
