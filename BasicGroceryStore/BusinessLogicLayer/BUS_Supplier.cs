using System;
using System.Collections.Generic;
using System.Data;

namespace BasicGroceryStore
{
    internal class BUS_Supplier : IControl<Supplier>, ISupplierServices
    {
        private DAO_Supplier dao;

        public BUS_Supplier()
        {
            dao = new DAO_Supplier();
        }

        public bool Create(Supplier supplier)
        {
            return dao.Create(supplier);
        }

        public bool Update(Supplier supplier)
        {
            return dao.Update(supplier);
        }

        public bool Delete(Supplier supplier)
        {
            return dao.Delete(supplier);
        }

        public DataTable GetAllSupplier()
        {
            return dao.GetAllSupplier();
        }

        public Dictionary<string, string> GetDictionarySupplier()
        {
            return dao.GetDictionarySupplier();
        }

        public Supplier GetSupplier(string supplier_id)
        {
            try
            {
                return dao.GetSupplier(supplier_id);
            }
            catch (Exception)
            {
                throw new Exception("Can not find this supplier");
            }
            
        }

        public DataTable FindSupplierByAddress(string address)
        {
            return dao.FindSupplierByAddress(address);
        }

        public DataTable FindSupplierByName(string name)
        {
            return dao.FindSupplierByName(name);
        }

        public DataTable FindSupplierByTypeProduct(string typeProduct)
        {
            return dao.FindSupplierByTypeProduct(typeProduct);
        }
    }
}
