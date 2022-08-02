using System;

namespace BasicGroceryStore
{
    public class Customer
    {
        private string name;
        private string phone;
        private DateTime dateJoin;
        private float value;
        private string e_level;

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime DateJoin { get => dateJoin; set => dateJoin = value; }
        public float Value { get => value; set => this.value = value; }
        public string E_level { get => e_level; set => e_level = value; }

        public Customer()
        {
            this.name = "";
            this.phone = "";
            this.dateJoin = DateTime.Now;
            this.Value = 0;
            this.e_level = Level.None.ToString();
        }

        ~Customer() { }

        public Customer(string name, string phone, DateTime dateJoin, float value, string e_level)
        {
            this.name = name;
            this.phone = phone;
            this.dateJoin = dateJoin;
            this.value = value;
            this.e_level = e_level;
        }
    }
}
