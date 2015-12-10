using System;
namespace MVPDemo
{
    public class Customer: ICloneable
    {
        public string Id
        { get; set; }

        public string FirstName
        { get; set; }

        public string LastName
        { get; set; }

        public string Address
        { get; set; }       

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Customer Clone()
        {
            return new Customer { 
                Id          = this.Id, 
                FirstName   = this.FirstName, 
                LastName    = this.LastName, 
                Address     = this.Address 
            };
        }
    }
}
