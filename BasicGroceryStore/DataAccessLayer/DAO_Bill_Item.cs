using System.Data;
using System.Data.SqlClient;

namespace BasicGroceryStore
{
    internal class DAO_Bill_Item : IControl<Bill_Item>
    {
        private string typeBill;

        public DAO_Bill_Item(string typeBill)
        {
            this.typeBill = typeBill;
        }

        public bool Create(Bill_Item item)
        {
            return (DataProvider.Instance.ExecuteNonQuery($"sp_Insert{typeBill}Detail", CommandType.StoredProcedure,
                new SqlParameter("@ID", item.ID),
                new SqlParameter($"@{typeBill}ID", item.BillID),
                new SqlParameter("@ProductID", item.ProductID),
                new SqlParameter("@Price", item.Price),
                new SqlParameter("@Quantity", item.Quantity),
                new SqlParameter("@Total", item.Price * item.Quantity)) > 0) ? true : false;
        }

        public bool Update(Bill_Item item)
        {
            return (DataProvider.Instance.ExecuteNonQuery($"sp_Update{typeBill}Detail", CommandType.StoredProcedure,
                new SqlParameter("@ID", item.ID),
                new SqlParameter($"@{typeBill}ID", item.BillID),
                new SqlParameter("@ProductID", item.ProductID),
                new SqlParameter("@Price", item.Price),
                new SqlParameter("@Quantity", item.Quantity),
                new SqlParameter("@Total", item.Price * item.Quantity)) > 0) ? true : false;
        }

        public bool Delete(Bill_Item item)
        {
            return (DataProvider.Instance.ExecuteNonQuery($"sp_Delete{typeBill}Detail", CommandType.StoredProcedure,
                new SqlParameter("@ID", item.ID),
                new SqlParameter($"@{typeBill}ID", item.BillID)) > 0) ? true : false;
        }
    }
}
