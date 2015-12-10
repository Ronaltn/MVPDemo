using MVPDemo.CustomerPresenterFactory;
using MVPDemo.VIPCustomerPresenterFactory;
using Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MVPDemo
{
    public partial class DemoGuide : Form
    {
        private IKernel ioc = null;

        public DemoGuide()
        {
            InitializeComponent();
        }

        private void DemoGuide_Load(object sender, EventArgs e)
        {
            ioc = new StandardKernel(new CustomerInjectModule());
        }

        private void DemoGuide_FormClosed(object sender, FormClosedEventArgs e)
        {
            ioc.Dispose();
        }

        private void buttonCustomerView_Click(object sender, EventArgs e)
        {
            var p = ioc.Get<CustomerPresenter>();
            (p.View as Form).Show();
        }

        private void buttonVIPCustomerView_Click(object sender, EventArgs e)
        {
            var p = ioc.Get<VIPCustomerPresenter>();
            (p.View as Form).Show();
        }
    }
}
