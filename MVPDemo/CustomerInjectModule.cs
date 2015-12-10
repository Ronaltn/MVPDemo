using MVPDemo.CustomerPresenterFactory;
using MVPDemo.CustomerViewFactory;
using MVPDemo.VIPCustomerPresenterFactory;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MVPDemo
{
    public class CustomerInjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ICustomerView>().To<CustomerView>();
            Bind<CustomerPresenter>().ToSelf();
            Bind<VIPCustomerPresenter>().ToSelf();
        }
    }
}
