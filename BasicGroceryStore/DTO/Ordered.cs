using System;

namespace BasicGroceryStore
{
    public class Ordered : Bill
    {
        private string customerName;

        public string CustomerName { get => customerName; set => customerName = value; }
    
        public Ordered() : base()
        {
            customerName = "";
        }

        public Ordered(string iD, DateTime dateCreate, float value, string staffID, string customerName) 
            : base(iD, dateCreate, value, staffID)
        {
            this.customerName = customerName;
        }
    }
}
