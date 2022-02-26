using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGroceryStore
{
    interface IStaff
    {
        void Insert(Staff staff);
        void Update(Staff staff);
        void Delete(string staffID);
        void FindStaffByName(string name);
        void FindStaffByAgeRange(int from, int to);
        void FindStaffByAddress(string address);
        void FindStaffByGender(string gender);
        void FindStaffByContractsStatus(string contractsStatus);
        void FindStaffByTypeWork(TypeWork type);
        void FindStaffBySpells(Spells spells);
    }
}
