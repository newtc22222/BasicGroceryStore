using System;
using System.Data;
using System.Data.SqlClient;

namespace BasicGroceryStore
{
    internal class DAO_Contract : IControl<Contract>, IContractServices
    {
        public bool Create(Contract contract)
        {
            return (DataProvider.Instance.ExecuteNonQuery("exec sp_Insertcontracts", CommandType.StoredProcedure,
                new SqlParameter("@ID", contract.ID),
                new SqlParameter("@StaffID", contract.StaffID),
                new SqlParameter("@DayStart", contract.DayStart),
                new SqlParameter("@DayEnd", contract.DayEnd),
                new SqlParameter("@TypeWork", contract.E_typeWork),
                new SqlParameter("@Spells", contract.E_spells),
                new SqlParameter("@SolidSalary", contract.SolidSalary)) > 0) ? true : false;
        }

        public bool Update(Contract contract)
        {
            return (DataProvider.Instance.ExecuteNonQuery("exec sp_Updatecontracts", CommandType.StoredProcedure,
                new SqlParameter("@ID", contract.ID),
                new SqlParameter("@StaffID", contract.StaffID),
                new SqlParameter("@DayStart", contract.DayStart),
                new SqlParameter("@DayEnd", contract.DayEnd),
                new SqlParameter("@TypeWork", contract.E_typeWork),
                new SqlParameter("@Spells", contract.E_spells),
                new SqlParameter("@SolidSalary", contract.SolidSalary)) > 0) ? true : false;
        }

        public bool Delete(Contract contract)
        {
            return (DataProvider.Instance.ExecuteNonQuery("exec sp_Deletecontracts", CommandType.StoredProcedure,
                new SqlParameter("@ID", contract.ID)) > 0) ? true : false;
        }

        public DataTable GetAllContractOfStaff(string staff_id)
        {
            return DataProvider.Instance.ExecuteQuery($"select * from contracts where StaffID={staff_id}", CommandType.Text, null);
        }

        public Contract GetNewestContractOfStaff(string staff_id)
        {
            DataTable dt = DataProvider.Instance.ExecuteQuery($"select * from contracts where StaffID={staff_id} order by DayStart DESC", CommandType.Text, null);
            return new Contract(dt.Rows[0][0].ToString(), staff_id, (DateTime)dt.Rows[0][2], (DateTime)dt.Rows[0][3],
                dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), float.Parse(dt.Rows[0][6].ToString()));
        }
    }
}
