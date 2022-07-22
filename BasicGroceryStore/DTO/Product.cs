using System.Drawing;

namespace BasicGroceryStore
{
    public class Product
    {
        private string iD;
        private string name;
        private string typeProduct;
        private string unit;
        private int quantity;
        private Image image;
        private string note;
        private float price;
        private string supplierID;

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string TypeProduct { get => typeProduct; set => typeProduct = value; }
        public string Unit { get => unit; set => unit = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public Image Image { get => image; set => image = value; }
        public string Note { get => note; set => note = value; }
        public float Price { get => price; set => price = value; }
        public string SupplierID { get => supplierID; set => supplierID = value; }

        public Product()
        {
            this.iD = GetFormatString.MakingIDNow();
            this.name = "";
            this.typeProduct = "";
            this.unit = "";
            this.quantity = 0;
            this.image = null;
            this.note = null;
            this.price = 0.0f;
            this.supplierID = "null";
        }

        ~Product() { }

        public Product(string iD, string name, string typeProduct, string unit, int quantity, 
            Image image, string note, float price, string supplierID)
        {
            this.iD = iD;
            this.name = name;
            this.typeProduct = typeProduct;
            this.unit = unit;
            this.quantity = quantity;
            this.image = image;
            this.note = note;
            this.price = price;
            this.supplierID = supplierID;
        }
    }
}
