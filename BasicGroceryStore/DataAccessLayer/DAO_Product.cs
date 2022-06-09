using System.Data;
using System.Data.SqlClient;


namespace BasicGroceryStore
{
    internal class DAO_Product
    {
        public static bool createProduct(Product product)
        {
            return (DAO.Instance.ExcuteNonQuery("sp_InsertProduct", 
                    CommandType.StoredProcedure, 
                    new SqlParameter("@ID", product.ID),
                    new SqlParameter("@Name", product.Name),
                    new SqlParameter("@TypeProduct", product.TypeProduct),
                    new SqlParameter("@Unit", product.Unit),
                    new SqlParameter("@Quantity", product.Quantity),
                    new SqlParameter("@Image", product.Image),
                    new SqlParameter("@Note", product.Note),
                    new SqlParameter("@Price", product.Price),
                    new SqlParameter("@SupplierID", product.SupplierID)) > 0) ? true : false;
        }

        public static bool updateProduct(Product product)
        {
            return (DAO.Instance.ExcuteNonQuery("sp_UpdateProduct",
                     CommandType.StoredProcedure,
                     new SqlParameter("@ID", product.ID),
                     new SqlParameter("@Name", product.Name),
                     new SqlParameter("@TypeProduct", product.TypeProduct),
                     new SqlParameter("@Unit", product.Unit),
                     new SqlParameter("@Quantity", product.Quantity),
                     new SqlParameter("@Image", product.Image),
                     new SqlParameter("@Note", product.Note),
                     new SqlParameter("@Price", product.Price),
                     new SqlParameter("@SupplierID", product.SupplierID)) > 0) ? true : false;
        }

        public static bool deleteProduct(string id)
        {
            return (DAO.Instance.ExcuteNonQuery("sp_DeleteProduct",
                    CommandType.StoredProcedure, new SqlParameter("@id", id)) > 0) ? true : false;
        }

        public static DataTable getAllProduct()
        {
            return DAO.Instance.ExecuteQuery("SELECT * FROM Product", CommandType.Text, null);
        }

        public static int getNumberOfProduct_depot()
        {
            return (int)DAO.Instance.ExecuteScalar("select dbo.func_NumberOfProduct_depot()", CommandType.Text);
        }

        public static DataTable FindProductByTypeProduct(string typeProduct)
        {
            return DAO.Instance.ExecuteQuery($"select * from dbo.func_FindProductByTypeProduct('{typeProduct}')", CommandType.Text);
        }

        public static DataTable FindProductByName(string name)
        {
            return DAO.Instance.ExecuteQuery($"select * from dbo.func_FindProductByName('{name}')", CommandType.Text);
        }

        public static DataTable FindProductByPriceRange(float from, float to)
        {
            return DAO.Instance.ExecuteQuery($"select * from dbo.func_FindProductByPriceRange({from}, {to})", CommandType.Text);
        }

        public static DataTable FindProductBySupplier(string supplierID)
        {
            return DAO.Instance.ExecuteQuery($"select * from dbo.func_FindProductBySupplier('{supplierID}')", CommandType.Text);
        }
    }
}
