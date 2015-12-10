using System;
using System.ComponentModel;

namespace MVPDemo.ViewBaseFactory
{
   public interface IViewBase
    {
       event EventHandler Load;
       event EventHandler Closed;
       event CancelEventHandler Closing;

       void ShowMessage(string msg, string title);
    }
}
