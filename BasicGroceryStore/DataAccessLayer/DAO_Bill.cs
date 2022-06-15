using System;
using System.Data;
using System.Data.SqlClient;


namespace BasicGroceryStore
{
    internal class DAO_Bill
    {
        // Imported or Ordered

        public static bool createBill(Bill bill, string typeBill, string customerName)
        {
            SqlParameter[] param = new SqlParameter[] {
                    new SqlParameter("@ID", bill.ID),
                    new SqlParameter("@DateCreate", bill.DateCreate),
                    new SqlParameter("@Value", bill.Value),
                    new SqlParameter("@StaffID", bill.StaffID) };

            if (typeBill == "Ordered") // for Ordered
            {
                param[param.Length] = new SqlParameter("@CustomerName", customerName);
            }

            return (DAO.Instance.ExecuteNonQuery($"sp_Insert{typeBill}", CommandType.StoredProcedure, param) > 0) ? true : false;
        }

        public static bool updateBill(Bill bill, string typeBill, string customerName)
        {
            SqlParameter[] param = new SqlParameter[] {
                    new SqlParameter("@ID", bill.ID),
                    new SqlParameter("@DateCreate", bill.DateCreate),
                    new SqlParameter("@Value", bill.Value),
                    new SqlParameter("@StaffID", bill.StaffID) };

            if (typeBill == "Ordered") // for Ordered
            {
                param[param.Length] = new SqlParameter("@CustomerName", customerName);
            }

            return (DAO.Instance.ExecuteNonQuery($"sp_Update{typeBill}", CommandType.StoredProcedure, param) > 0) ? true : false;
        }

        public static bool deleteBill(string typeBill, string id)
        {
            return (DAO.Instance.ExecuteNonQuery($"exec sp_Delete{typeBill}", CommandType.StoredProcedure, 
                new SqlParameter("@ID", id)) > 0) ? true : false;
        }

        public static DataTable getAllBill(string typeBill)
        {
            return DAO.Instance.ExecuteQuery($"select * from {typeBill}", CommandType.Text, null);
        }

        public static int getQuantityOfBill(string typeBill)
        {
            return (int)DAO.Instance.ExecuteScalar($"select dbo.func_NumberOf{typeBill}()", CommandType.Text);
        }

        public static float getTotalValueOfBill_Single(string typeBill, string id)
        {
            return (float)DAO.Instance.ExecuteScalar($"select sum(Price * Quantity) from {typeBill} where Id={id}", CommandType.Text);
        }

        public static float? getTotalValueOfBill_All(string typeBill)
        {
            return (float?)DAO.Instance.ExecuteScalar($"select sum(Price * Quantity) from {typeBill}", CommandType.Text);
        }

        public static float getTotalValueOfBill_Day(string typeBill, DateTime date)
        {
            return 0;
        }

        public static float getTotalValueOfBill_Month(string typeBill)
        {
            return 0;
        }

        public DataTable FindBillByDateRange(string typeBill, DateTime from, DateTime to)
        {
            string dateFrom = AdditionalFunctions.getDateString(from);
            string dateTo = AdditionalFunctions.getDateString(to);
            return DAO.Instance.ExecuteQuery($"select * from dbo.func_Find{typeBill}ByDateRange('{dateFrom}', {dateTo})", CommandType.Text);
        }
    }
}
