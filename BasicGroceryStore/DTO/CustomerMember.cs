using System;

namespace GroceryStore
{
    class CustomerMember
    {
        private string name;
        private string phone;
        private DateTime dateJoin;
        private float value;
        private Level e_level;

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public DateTime DateJoin { get => dateJoin; set => dateJoin = value; }
        public float Value { get => value; set => this.value = value; }
        public Level E_level { get => e_level; set => e_level = value; }

        public CustomerMember()
        {
            this.name = "";
            this.phone = "";
            this.dateJoin = DateTime.Now;
            this.Value = 0;
            this.e_level = Level.None;
        }

        ~CustomerMember() { }

        public CustomerMember(string name, string phone, DateTime dateJoin, float value, Level e_level)
        {
            this.name = name;
            this.phone = phone;
            this.dateJoin = dateJoin;
            this.value = value;
            this.e_level = e_level;
        }
    }
}
