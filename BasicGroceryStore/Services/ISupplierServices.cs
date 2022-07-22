using System.Collections.Generic;
using System.Data;

namespace BasicGroceryStore
{
    public interface ISupplierServices
    {
        /// <summary>
        /// Get information of a supplier
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Supplier GetSupplier(string id);
        
        /// <summary>
        /// Get all supplier in DBMS
        /// </summary>
        /// <returns></returns>
        DataTable GetAllSupplier();
        
        /// <summary>
        /// Get List for supplier with id and name (use for combobox)
        /// </summary>
        /// <returns></returns>
        Dictionary<string, string> GetDictionarySupplier();

        /// <summary>
        /// Get supplier data with address (use for searching)
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        DataTable FindSupplierByAddress(string address);

        /// <summary>
        /// Get supplier data with name (use for searching)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        DataTable FindSupplierByName(string name);

        /// <summary>
        /// Get supplier data with the type of product (use for searching)
        /// </summary>
        /// <param name="typeProduct"></param>
        /// <returns></returns>
        DataTable FindSupplierByTypeProduct(string typeProduct);
    }
}
