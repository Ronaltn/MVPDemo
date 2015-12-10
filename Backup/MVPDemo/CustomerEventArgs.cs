using System;
namespace MVPDemo
{
    public class CustomerEventArgs : EventArgs
    {
        public string CustomerId
        { get; set; }

        public Customer Customer
        { get; set; }
    }
}
