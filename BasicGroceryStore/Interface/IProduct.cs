using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGroceryStore
{
    interface IProduct
    {
        void Insert(Product product);
        void Update(Product product);
        void Delete(string productID);
        void FindProductByName(string name);
        void FindProductByPriceRange(float from, float to);
        void FindProductBySupplier(string supplierID);
        void FindProductByTypeProduct(string typeProduct);
    }
}
