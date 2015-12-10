using MVPDemo.BaseFactory;
using MVPDemo.CustomerViewFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVPDemo.VIPCustomerPresenterFactory
{
    public class VIPCustomerPresenter : PresenterBase<ICustomerView>
    {
        public VIPCustomerMode Mode
        { get; private set; }

        public VIPCustomerPresenter(ICustomerView view)
            : base(view)
        {
            this.Mode = new VIPCustomerMode();
        }

        protected override void OnViewSet()
        {
            this.View.Load += (sender, args) =>
                {
                    Customer[] customers = this.Mode.GetAllVIPCustomers();
                    this.View.ListAllCustomers(customers);
                    this.View.Clear();
                };
            this.View.CustomerSelected += (sender, args) =>
                {
                    Customer customer = this.Mode.GetVIPCustomerById(args.CustomerId);
                    this.View.DisplayCustomerInfo(customer);
                };
            this.View.CustomerSaving += (sender, args) =>
                {
                    this.Mode.UpdateVIPCustomer(args.Customer);
                    Customer[] customers = this.Mode.GetAllVIPCustomers();
                    this.View.ListAllCustomers(customers);
                    this.View.Clear();
                    this.View.ShowMessage("The VIP customer has been successfully updated!", "Successfully Update");
                };
        }       
    }
}
