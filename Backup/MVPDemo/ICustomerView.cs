using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVPDemo
{
    public interface ICustomerView : IViewBase
    {
        event EventHandler<CustomerEventArgs> CustomerSelected;

        event EventHandler<CustomerEventArgs> CustomerSaving;

        void ListAllCustomers(Customer[] customers);

        void DisplayCustomerInfo(Customer customer);

        void Clear();
    }
}
