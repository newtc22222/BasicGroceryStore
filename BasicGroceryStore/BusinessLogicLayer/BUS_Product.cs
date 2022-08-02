using System.Collections.Generic;
using System.Data;

namespace BasicGroceryStore
{
    internal class BUS_Product : IControl<Product>, IProductServices
    {
        private DAO_Product dao;

        public BUS_Product()
        {
            dao = new DAO_Product();
        }

        public bool Create(Product product)
        {
            return dao.Create(product);
        }

        public bool Update(Product product)
        {
            return dao.Update(product);
        }

        public bool Delete(Product product)
        {
            return dao.Delete(product);
        }

        public DataTable GetAllProduct()
        {
            return dao.GetAllProduct();
        }

        public Product GetProduct(string product_id)
        {
            return dao.GetProduct(product_id);
        }

        public DataTable GetProductOfSupplier(string supplier_id)
        {
            return dao.GetProductOfSupplier(supplier_id);
        }

        public List<string> GetAllTypeOfProduct()
        {
            return dao.GetAllTypeOfProduct();
        }

        public List<string> GetAllUnit()
        {
            return dao.GetAllUnit();
        }

        public int GetNumberOfProduct_depot()
        {
            return dao.GetNumberOfProduct_depot();
        }

        public DataTable FindProductByTypeProduct(string typeProduct)
        {
            return dao.FindProductByTypeProduct(typeProduct);
        }

        public DataTable FindProductByName(string name)
        {
            return dao.FindProductByName(name);
        }

        public DataTable FindProductByPriceRange(float from, float to)
        {
            return dao.FindProductByPriceRange(from, to);
        }

        public DataTable FindProductBySupplier(string supplierName)
        {
            return dao.FindProductBySupplier(supplierName);
        }
    }
}
