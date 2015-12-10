using MVPDemo.CustomerViewFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVPDemo.VIPCustomerPresenterFactory
{
    public class VIPCustomerMode
    {
        private IList<Customer> _vipCustomers = new List<Customer>{
            new Customer{ Id = "VIP001", FirstName = "San", LastName = "Zhang", Address="Su zhou"},
            new Customer{ Id = "VIP002", FirstName = "Si", LastName = "Li", Address="Shang Hai"},
            new Customer{ Id = "VIP003", FirstName = "Wang", LastName = "HuiTang", Address="Chang Zhou"}
        };

        public void UpdateVIPCustomer(Customer customer)
        {
            for (int i = 0; i < _vipCustomers.Count; i++)
            {
                if (_vipCustomers[i].Id == customer.Id)
                {
                    _vipCustomers[i] = customer;
                    break;
                }
            }

            //var target = _vipCustomers.Where(c => c.Id == customer.Id).FirstOrDefault();
            //target = customer;
        }//end method

        public Customer GetVIPCustomerById(string id)
        {
            return _vipCustomers.Where(c => c.Id == id).Single().Clone();
        }

        public Customer[] GetAllVIPCustomers()
        {
            return _vipCustomers.Select(c => c.Clone()).ToArray();
        }
    }
}
