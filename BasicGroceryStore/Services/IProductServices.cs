using System.Data;
using System.Collections.Generic;

namespace BasicGroceryStore
{
    public interface IProductServices
    {
        /// <summary>
        /// Get product's data in DBMS
        /// </summary>
        /// <returns></returns>
        DataTable GetAllProduct();

        /// <summary>
        /// Get data of a product
        /// </summary>
        /// <param name="product_id"></param>
        /// <returns></returns>
        Product GetProduct(string product_id);

        /// <summary>
        /// Get all products of a supplier in DBMS
        /// </summary>
        /// <param name="supplier_id"></param>
        /// <returns></returns>
        DataTable GetProductOfSupplier(string supplier_id);

        /// <summary>
        /// Get a list of product type (use for combobox)
        /// </summary>
        /// <returns></returns>
        List<string> GetAllTypeOfProduct();

        /// <summary>
        /// Get a list of product unit (use for combobox)
        /// </summary>
        /// <returns></returns>
        List<string> GetAllUnit();

        /// <summary>
        /// Get the number of products in stock (use for statistic)
        /// </summary>
        /// <returns></returns>
        int GetNumberOfProduct_depot();

        /// <summary>
        /// Get product data with the product type (use for searching)
        /// </summary>
        /// <param name="typeProduct"></param>
        /// <returns></returns>
        DataTable FindProductByTypeProduct(string typeProduct);

        /// <summary>
        /// Get product data with the product name (use for searching)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        DataTable FindProductByName(string name);

        /// <summary>
        /// Get product data with a price range (use for searching)
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        DataTable FindProductByPriceRange(float from, float to);

        /// <summary>
        /// Get product data with the supplier's name (use for searching)
        /// </summary>
        /// <param name="supplierName"></param>
        /// <returns></returns>
        DataTable FindProductBySupplier(string supplierName);
    }
}
