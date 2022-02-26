using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGroceryStore
{
    public class BLL : IProduct, IStaff
    {
        #region Product
        public void Delete(string ID)
        {
            throw new NotImplementedException();
        }

        public void FindProductByName(string name)
        {
            throw new NotImplementedException();
        }

        public void FindProductByPriceRange(float from, float to)
        {
            throw new NotImplementedException();
        }

        public void FindProductBySupplier(string supplierID)
        {
            throw new NotImplementedException();
        }

        public void FindProductByTypeProduct(string typeProduct)
        {
            throw new NotImplementedException();
        }

        public void Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Staff
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

        public void Insert(Staff staff)
        {
            throw new NotImplementedException();
        }

        public void Update(Staff staff)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
