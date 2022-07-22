namespace BasicGroceryStore
{
    public class Supplier
    {
        private string iD;
        private string name;
        private string address;
        private string email;
        private string contact;

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public string Contact { get => contact; set => contact = value; }

        public Supplier()
        {
            this.iD = GetFormatString.MakingIDNow();
            this.name = "";
            this.address = "";
            this.email = "";
            this.contact = "";
        }

        ~Supplier() { }

        public Supplier(string iD, string name, string address, string email, string contact)
        {
            this.iD = iD;
            this.name = name;
            this.address = address;
            this.email = email;
            this.contact = contact;
        }
    }
}
