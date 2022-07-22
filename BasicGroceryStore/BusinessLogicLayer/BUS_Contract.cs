using System;
using System.Data;

namespace BasicGroceryStore
{
    internal class BUS_Contract : IControl<Contract>, IContractServices
    {
        private DAO_Contract dao;

        public BUS_Contract()
        {
            dao = new DAO_Contract();
        }

        public bool Create(Contract contract)
        {
            return dao.Create(contract);
        }

        public bool Update(Contract contract)
        {
            return dao.Update(contract);
        }

        public bool Delete(Contract contract)
        {
            return dao.Delete(contract);
        }

        public DataTable GetAllContractOfStaff(string staff_id)
        {
            return dao.GetAllContractOfStaff(staff_id);
        }

        public Contract GetNewestContractOfStaff(string staff_id)
        {
            return dao.GetNewestContractOfStaff(staff_id);
        }
    }
}
