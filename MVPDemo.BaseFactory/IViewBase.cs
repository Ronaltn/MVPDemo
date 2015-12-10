using System;
using System.ComponentModel;

namespace MVPDemo.BaseFactory
{
   public interface IViewBase
    {
       event EventHandler Load;
       event EventHandler Closed;
       event CancelEventHandler Closing;
    }
}
