using System;
using System.Data;

namespace BasicGroceryStore
{
    public class BLL
    {
        private static BLL instance;
        public static BLL Instance
        {
            get 
            {
                if (instance == null)
                    instance = new BLL();
                return instance;
            }
        }

        #region Product
        public DataTable getAllProduct()
        {
            return DAO_Product.getAllProduct();
        }

        public DataTable FindProductByName(string name)
        {
            return DAO_Product.FindProductByName(name);
        }

        public DataTable FindProductByPriceRange(float from, float to)
        {
            return DAO_Product.FindProductByPriceRange(from, to);
        }

        public DataTable FindProductBySupplier(string supplierID)
        {
            return DAO_Product.FindProductBySupplier(supplierID);
        }

        public DataTable FindProductByTypeProduct(string typeProduct)
        {
            return DAO_Product.FindProductByTypeProduct(typeProduct);
        }
        #endregion

        #region Staff
        public DataTable getAllStaff()
        {
            return DAO_Staff.getAllStaff();
        }

        public void FindStaffByAddress(string address)
        {
            throw new NotImplementedException();
        }

        public void FindStaffByAgeRange(int from, int to)
        {
            throw new NotImplementedException();
        }

        public void FindStaffByContractsStatus(string contractsStatus)
        {
            throw new NotImplementedException();
        }

        public void FindStaffByGender(string gender)
        {
            throw new NotImplementedException();
        }

        public void FindStaffByName(string name)
        {
            throw new NotImplementedException();
        }

        public void FindStaffBySpells(Spells spells)
        {
            throw new NotImplementedException();
        }

        public void FindStaffByTypeWork(TypeWork type)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Account

        #endregion

        #region CustomerMember

        #endregion

        #region Imported
        
        #endregion

        #region ImportedDetail
        
        #endregion

        #region Ordered
        
        #endregion

        #region OrderedDetail
        
        #endregion

        #region Supplier
        
        #endregion

        #region Contract
        
        #endregion
    }
}
