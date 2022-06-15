using System.Data;
using System.Data.SqlClient;

namespace BasicGroceryStore
{
    internal class DAO_BillDetails
    {
        public static bool createBillDetail(BillDetail item, string typeBill)
        {
            return (DAO.Instance.ExecuteNonQuery($"sp_Insert{typeBill}Detail", CommandType.StoredProcedure,
                new SqlParameter("@ID", item.ID),
                new SqlParameter($"@{typeBill}ID", item.BillID),
                new SqlParameter("@ProductID", item.ProductID),
                new SqlParameter("@Price", item.Price),
                new SqlParameter("@Quantity", item.Quantity),
                new SqlParameter("@Total", item.Price * item.Quantity)) > 0) ? true : false;
        }

        public static bool updateBillDetail(BillDetail item, string typeBill)
        {
            return (DAO.Instance.ExecuteNonQuery($"sp_Update{typeBill}Detail", CommandType.StoredProcedure,
                new SqlParameter("@ID", item.ID),
                new SqlParameter($"@{typeBill}ID", item.BillID),
                new SqlParameter("@ProductID", item.ProductID),
                new SqlParameter("@Price", item.Price),
                new SqlParameter("@Quantity", item.Quantity),
                new SqlParameter("@Total", item.Price * item.Quantity)) > 0) ? true : false;
        }

        public static bool deleteBillDetail(BillDetail item, string typeBill)
        {
            return (DAO.Instance.ExecuteNonQuery($"sp_Delete{typeBill}Detail", CommandType.StoredProcedure,
                new SqlParameter("@ID", item.ID),
                new SqlParameter($"@{typeBill}ID", item.BillID)) > 0) ? true : false;
        }

        public static DataTable getAllItem_BillDetail(string typeBill, string id)
        {
            return DAO.Instance.ExecuteQuery($"select * from {typeBill}Details where {typeBill}Id={id}", CommandType.Text, null);
        }
    }
}
