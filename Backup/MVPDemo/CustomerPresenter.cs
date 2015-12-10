using System.Windows.Forms;

namespace MVPDemo
{   
    public class CustomerPresenter: Presenter<ICustomerView>
    {
        public CustomerMode Mode
        { get; private set; }
       
        public CustomerPresenter(ICustomerView view)
            : base(view)
        {
            this.Mode = new CustomerMode();
        }

        protected override void OnViewSet()
        {
            this.View.Load += (sender, args) =>
                {
                    Customer[] customers = this.Mode.GetAllCustomers();
                    this.View.ListAllCustomers(customers);
                    this.View.Clear();
                };
            this.View.CustomerSelected += (sender, args) =>
                {
                    Customer customer = this.Mode.GetCustomerById(args.CustomerId);
                    this.View.DisplayCustomerInfo(customer);
                };
            this.View.CustomerSaving += (sender, args) =>
                {
                    this.Mode.UpdateCustomer(args.Customer);
                    Customer[] customers = this.Mode.GetAllCustomers();
                    this.View.ListAllCustomers(customers);
                    this.View.Clear();
                    MessageBox.Show("The customer has been successfully updated!", "Successfully Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
        }       
    }
}