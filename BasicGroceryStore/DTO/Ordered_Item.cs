namespace BasicGroceryStore
{
    public class Ordered_Item : Bill_Item
    {
        public Ordered_Item(int iD, string billID, string productID, float price, int quantity) : 
            base(iD, billID, productID, price, quantity)
        {
        }
    }
}
