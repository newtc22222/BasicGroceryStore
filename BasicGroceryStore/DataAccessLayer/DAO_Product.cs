using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BasicGroceryStore
{
    internal class DAO_Product
    {
        public static bool createProduct(Product product)
        {
            return (DAO.Instance.ExecuteNonQuery("sp_InsertProduct", 
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
            return (DAO.Instance.ExecuteNonQuery("sp_UpdateProduct",
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
            return (DAO.Instance.ExecuteNonQuery("sp_DeleteProduct",
                    CommandType.StoredProcedure, new SqlParameter("@id", id)) > 0) ? true : false;
        }

        public static DataTable getAllProduct()
        {
            return DAO.Instance.ExecuteQuery("select * from Product", CommandType.Text, null);
        }

        public static DataTable getAllProductOfSupplier(string supplier_id)
        {
            return DAO.Instance.ExecuteQuery("select * from Product where SupplierID = @sup_id", CommandType.Text, new SqlParameter("@sup_id", supplier_id));
        }

        public static List<string> getAllTypeOfProduct()
        {
            List<string> typeProduct = new List<string>();
            DataTable tb = DAO.Instance.ExecuteQuery("select distinct TypeProduct from Product", CommandType.Text);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                typeProduct.Add(tb.Rows[i][0].ToString());
            }
            return typeProduct;
        }

        public static List<string> getAllUnit()
        {
            List<string> unit = new List<string>();
            DataTable tb = DAO.Instance.ExecuteQuery("select distinct Unit from Product", CommandType.Text);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                unit.Add(tb.Rows[i][0].ToString());
            }
            return unit;
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
