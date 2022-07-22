namespace BasicGroceryStore
{
    public abstract class Bill_Item
    {
        private int iD;
        private string billID;
        private string productID;
        private float price;
        private int quantity;

        public int ID { get => iD; set => iD = value; }
        public string BillID { get => billID; set => billID = value; }
        public string ProductID { get => productID; set => productID = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Bill_Item()
        {
            this.iD = 0;
            this.billID = "";
            this.productID = "";
            this.price = 0;
            this.quantity = 0;
        }

        ~Bill_Item() { }

        public Bill_Item(int iD, string billID, string productID, float price, int quantity)
        {
            this.iD = iD;
            this.billID = billID;
            this.productID = productID;
            this.price = price;
            this.quantity = quantity;
        }

        public float Total()
        {
            return this.price * this.Quantity;
        }
    }
}
