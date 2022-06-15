namespace BasicGroceryStore
{
    public class ImportedDetail : BillDetail
    {
        public ImportedDetail(int iD, string billID, string productID, float price, int quantity) : base(iD, billID, productID, price, quantity)
        {
        }
    }
}
