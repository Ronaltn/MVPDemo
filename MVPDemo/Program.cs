using MVPDemo.CustomerPresenterFactory;
using MVPDemo.CustomerViewFactory;
using MVPDemo.VIPCustomerPresenterFactory;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MVPDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DemoGuide());

            //using (IKernel kernel = new StandardKernel(new CustomerInjectModule()))
            //{
            //    var p = kernel.Get<CustomerPresenter>();
            //    Application.Run(p.View as Form);
            //}

            //using (IKernel kernel = new StandardKernel(new VIPCustomerInjectModule()))
            //{
            //    var p = kernel.Get<VIPCustomerPresenter>();
            //    Application.Run(p.View as Form);
            //}
        }
    }
}
