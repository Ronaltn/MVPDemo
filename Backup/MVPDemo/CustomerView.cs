using System;
using System.Windows.Forms;

namespace MVPDemo
{
    public partial class CustomerView : ViewBase, ICustomerView
    {
        public CustomerView()
        {
            InitializeComponent();            
        }

        protected override object CreatePresenter()
        {
            return new CustomerPresenter(this);
        }

        #region ICustomerView Members

        public event EventHandler<CustomerEventArgs> CustomerSelected;

        public event EventHandler<CustomerEventArgs> CustomerSaving;

        public void ListAllCustomers(Customer[] customers)
        {
            this.dataGridViewCustomers.DataSource = customers;
        }

        public void DisplayCustomerInfo(Customer customer)
        {
            this.buttonOK.Enabled = true;
            this.textBoxId.Text = customer.Id;
            this.textBox1stName.Text = customer.FirstName;
            this.textBoxLastName.Text = customer.LastName;
            this.textBoxAddress.Text = customer.Address;
        }

        public void Clear()
        {
            this.buttonOK.Enabled       = false;
            this.textBox1stName.Text    = string.Empty;
            this.textBoxLastName.Text   = string.Empty;
            this.textBoxAddress.Text    = string.Empty;
            this.textBoxId.Text         = string.Empty;
        }

        #endregion

        protected virtual void OnCustomerSelected(string customerId)
        {
            var previousId = this.textBoxId.Text.Trim();
            if (customerId == previousId)
            {
                return;
            }
            if(null != this.CustomerSelected)
            {
                this.CustomerSelected(this, new CustomerEventArgs{ CustomerId = customerId});
            }
        }

        protected virtual void OnCustomerSaving(Customer customer)
        {
            if(null != this.CustomerSaving)
            {
                this.CustomerSaving(this, new CustomerEventArgs{ Customer = customer});
            }
        }

        private void dataGridViewCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {   
            var currentRow = this.dataGridViewCustomers.Rows[e.RowIndex];
            var customerId = currentRow.Cells[0].Value.ToString();
            this.OnCustomerSelected(customerId);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            var customer        = new Customer();
            customer.Id         = this.textBoxId.Text.Trim();
            customer.FirstName  = this.textBox1stName.Text.Trim();
            customer.LastName   = this.textBoxLastName.Text.Trim();
            customer.Address    = this.textBoxAddress.Text.Trim();
            this.OnCustomerSaving(customer);
        }
    }
}