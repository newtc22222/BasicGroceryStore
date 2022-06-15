namespace BasicGroceryStore
{
    public class OrderedDetail : BillDetail
    {
        public OrderedDetail(int iD, string billID, string productID, float price, int quantity) : base(iD, billID, productID, price, quantity)
        {
        }
    }
}
