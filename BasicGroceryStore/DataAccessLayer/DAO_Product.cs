using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace BasicGroceryStore
{
    internal class DAO_Product : IControl<Product>, IProductServices
    {
        public bool Create(Product product)
        {
            return (DataProvider.Instance.ExecuteNonQuery("sp_InsertProduct", 
                    CommandType.StoredProcedure, 
                    new SqlParameter("@ID", product.ID),
                    new SqlParameter("@Name", product.Name),
                    new SqlParameter("@TypeProduct", product.TypeProduct),
                    new SqlParameter("@Unit", product.Unit),
                    new SqlParameter("@Quantity", product.Quantity),
                    new SqlParameter("@Image", Convert.ImageToByteArray(product.Image)),
                    new SqlParameter("@Note", product.Note),
                    new SqlParameter("@Price", product.Price),
                    new SqlParameter("@SupplierID", product.SupplierID)) > 0) ? true : false;
        }

        public bool Update(Product product)
        {
            return (DataProvider.Instance.ExecuteNonQuery("sp_UpdateProduct",
                     CommandType.StoredProcedure,
                     new SqlParameter("@ID", product.ID),
                     new SqlParameter("@Name", product.Name),
                     new SqlParameter("@TypeProduct", product.TypeProduct),
                     new SqlParameter("@Unit", product.Unit),
                     new SqlParameter("@Quantity", product.Quantity),
                     new SqlParameter("@Image", Convert.ImageToByteArray(product.Image)),
                     new SqlParameter("@Note", product.Note),
                     new SqlParameter("@Price", product.Price),
                     new SqlParameter("@SupplierID", product.SupplierID)) > 0) ? true : false;
        }

        public bool Delete(Product product)
        {
            return (DataProvider.Instance.ExecuteNonQuery("sp_DeleteProduct",
                    CommandType.StoredProcedure, new SqlParameter("@id", product.ID)) > 0) ? true : false;
        }

        public DataTable GetAllProduct()
        {
            return DataProvider.Instance.ExecuteQuery("sp_GetAllProduct", CommandType.StoredProcedure, null);
        }

        public Product GetProduct(string product_id)
        {
            if (product_id == "")
                return null;

            DataTable dt = DataProvider.Instance.ExecuteQuery($"select * from Product where Id='{product_id}'", CommandType.Text, null);
            DataRow row = dt.Rows[0];

            Image image = null;
            if (row[5] != DBNull.Value)
            {
                image = Convert.ByteArrayToImage((byte[])row[5]);
            }

            Product product = new Product(
                iD: row[0].ToString(),
                name: row[1].ToString(),
                typeProduct: row[2].ToString(),
                unit: row[3].ToString(),
                quantity: int.Parse(row[4].ToString()),
                image: image,
                note: row[6].ToString(),
                price: float.Parse(row[7].ToString()),
                supplierID: row[8].ToString());
            return product;
        }

        public DataTable GetProductOfSupplier(string supplier_id)
        {
            return DataProvider.Instance.ExecuteQuery("select * from Product where SupplierID = @sup_id", CommandType.Text, new SqlParameter("@sup_id", supplier_id));
        }

        public List<string> GetAllTypeOfProduct()
        {
            List<string> typeProduct = new List<string>();
            DataTable tb = DataProvider.Instance.ExecuteQuery("select distinct TypeProduct from Product", CommandType.Text);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                typeProduct.Add(tb.Rows[i][0].ToString());
            }
            return typeProduct;
        }

        public List<string> GetAllUnit()
        {
            List<string> unit = new List<string>();
            DataTable tb = DataProvider.Instance.ExecuteQuery("select distinct Unit from Product", CommandType.Text);
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                unit.Add(tb.Rows[i][0].ToString());
            }
            return unit;
        }

        public int GetNumberOfProduct_depot()
        {
            return (int)DataProvider.Instance.ExecuteScalar("select dbo.func_NumberOfProduct_depot()", CommandType.Text);
        }

        public DataTable FindProductByTypeProduct(string typeProduct)
        {
            return DataProvider.Instance.ExecuteQuery($"select * from dbo.func_FindProductByTypeProduct(N'{typeProduct}')", CommandType.Text);
        }

        public DataTable FindProductByName(string name)
        {
            return DataProvider.Instance.ExecuteQuery($"select * from dbo.func_FindProductByName(N'{name}')", CommandType.Text);
        }

        public DataTable FindProductByPriceRange(float from, float to)
        {
            return DataProvider.Instance.ExecuteQuery($"select * from dbo.func_FindProductByPriceRange({from}, {to})", CommandType.Text);
        }

        public DataTable FindProductBySupplier(string supplierName)
        {
            return DataProvider.Instance.ExecuteQuery($"select * from dbo.func_FindProductBySupplier(N'{supplierName}')", CommandType.Text);
        }
    }
}
