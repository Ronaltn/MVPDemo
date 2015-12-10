using MVPDemo.CustomerViewFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVPDemo.CustomerPresenterFactory
{
    public class CustomerMode
    {
        private IList<Customer> _customers = new List<Customer>{
            new Customer{ Id = "001", FirstName = "San", LastName = "Zhang", Address="Su zhou"},
            new Customer{ Id = "002", FirstName = "Si", LastName = "Li", Address="Shang Hai"}
        };

        public void UpdateCustomer(Customer customer)
        {
            for (int i = 0; i < _customers.Count; i++)
            {
                if (_customers[i].Id == customer.Id)
                {
                    _customers[i] = customer;
                    break;
                }
            }
        }

        public Customer GetCustomerById(string id)
        {
            var customers = from customer in _customers
                            where customer.Id == id
                            select customer.Clone();
            return customers.ToArray<Customer>()[0];
        }

        public Customer[] GetAllCustomers()
        {
            var customers = from customer in _customers
                            select customer.Clone();
            return customers.ToArray<Customer>();
        }
    }
}
