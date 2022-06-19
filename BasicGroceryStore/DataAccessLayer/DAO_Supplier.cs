using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace BasicGroceryStore
{
    internal class DAO_Supplier
    {
        public static bool createSupplier(Supplier supplier)
        {
            return (DAO.Instance.ExecuteNonQuery("sp_InsertSupplier", CommandType.StoredProcedure,
                new SqlParameter("@Id", supplier.ID),
                new SqlParameter("@Name", supplier.Name),
                new SqlParameter("@Address", supplier.Address),
                new SqlParameter("@Email", supplier.Email),
                new SqlParameter("@Contact", supplier.Contact)) > 0) ? true : false;
        }

        public static bool updateSupplier(Supplier supplier)
        {
            return (DAO.Instance.ExecuteNonQuery("sp_UpdateSupplier", CommandType.StoredProcedure,
                new SqlParameter("@Id", supplier.ID),
                new SqlParameter("@Name", supplier.Name),
                new SqlParameter("@Address", supplier.Address),
                new SqlParameter("@Email", supplier.Email),
                new SqlParameter("@Contact", supplier.Contact)) > 0) ? true : false;
        }

        public static bool deleteSupplier(string id)
        {
            return (DAO.Instance.ExecuteNonQuery("sp_DeleteSupplier", CommandType.StoredProcedure,
                new SqlParameter("@Id", id)) > 0) ? true : false;
        }

        public static DataTable getAllSupplier()
        {
            return DAO.Instance.ExecuteQuery("select * from Supplier", CommandType.Text, null);
        }

        public static Dictionary<string, string> getDictionarySupplier()
        {
            Dictionary<string, string> supplier = new Dictionary<string, string>();
            DataTable tb = DAO.Instance.ExecuteQuery("select Id, Name from Supplier", CommandType.Text, null);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                supplier.Add(tb.Rows[i][0].ToString(), tb.Rows[i][1].ToString());
            }
            return supplier;
        }

        public static Supplier getSupplier(string id)
        {
            DataTable data = DAO.Instance.ExecuteQuery($"select * from Supplier where Id={id}", CommandType.Text);
            if (data.Rows.Count == 0)
                return null;

            DataRow row = data.Rows[0];
            if(!row.IsNull("Name"))
                return new Supplier(id, row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
            return null;
        }

        public static DataTable FindSupplierByAddress(string address)
        {
            return DAO.Instance.ExecuteQuery($"select * from func_FindSupplierByAddress(N'{address}')", CommandType.Text);
        }

        public static DataTable FindSupplierByName(string name)
        {
            return DAO.Instance.ExecuteQuery($"select * from func_FindSupplierByName(N'{name}')", CommandType.Text);
        }

        public static DataTable FindSupplierByTypeProduct(string typeProduct)
        {
            return DAO.Instance.ExecuteQuery($"select * from func_FindSupplierByTypeProduct(N'{typeProduct}')", CommandType.Text);
        }
    }
}
