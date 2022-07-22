using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace BasicGroceryStore
{
    internal class DAO_Supplier : IControl<Supplier>, ISupplierServices
    {
        public bool Create(Supplier supplier)
        {
            return (DataProvider.Instance.ExecuteNonQuery("sp_InsertSupplier", CommandType.StoredProcedure,
                new SqlParameter("@Id", supplier.ID),
                new SqlParameter("@Name", supplier.Name),
                new SqlParameter("@Address", supplier.Address),
                new SqlParameter("@Email", supplier.Email),
                new SqlParameter("@Contact", supplier.Contact)) > 0) ? true : false;
        }

        public bool Update(Supplier supplier)
        {
            return (DataProvider.Instance.ExecuteNonQuery("sp_UpdateSupplier", CommandType.StoredProcedure,
                new SqlParameter("@Id", supplier.ID),
                new SqlParameter("@Name", supplier.Name),
                new SqlParameter("@Address", supplier.Address),
                new SqlParameter("@Email", supplier.Email),
                new SqlParameter("@Contact", supplier.Contact)) > 0) ? true : false;
        }

        public bool Delete(Supplier supplier)
        {
            return (DataProvider.Instance.ExecuteNonQuery("sp_DeleteSupplier", CommandType.StoredProcedure,
                new SqlParameter("@Id", supplier.ID)) > 0) ? true : false;
        }

        public DataTable GetAllSupplier()
        {
            return DataProvider.Instance.ExecuteQuery("select * from Supplier", CommandType.Text, null);
        }

        public Dictionary<string, string> GetDictionarySupplier()
        {
            Dictionary<string, string> supplier = new Dictionary<string, string>();
            DataTable tb = DataProvider.Instance.ExecuteQuery("select Id, Name from Supplier", CommandType.Text, null);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                supplier.Add(tb.Rows[i][0].ToString(), tb.Rows[i][1].ToString());
            }
            return supplier;
        }

        public Supplier GetSupplier(string id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery($"select * from Supplier where Id={id}", CommandType.Text);
            if (data.Rows.Count == 0)
                return null;

            DataRow row = data.Rows[0];
            if(!row.IsNull("Name"))
                return new Supplier(id, row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
            return null;
        }

        public DataTable FindSupplierByAddress(string address)
        {
            return DataProvider.Instance.ExecuteQuery($"select * from func_FindSupplierByAddress(N'{address}')", CommandType.Text);
        }

        public DataTable FindSupplierByName(string name)
        {
            return DataProvider.Instance.ExecuteQuery($"select * from func_FindSupplierByName(N'{name}')", CommandType.Text);
        }

        public DataTable FindSupplierByTypeProduct(string typeProduct)
        {
            return DataProvider.Instance.ExecuteQuery($"select * from func_FindSupplierByTypeProduct(N'{typeProduct}')", CommandType.Text);
        }
    }
}
