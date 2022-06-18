using System;
using System.Data;
using System.Data.SqlClient;

namespace BasicGroceryStore
{
    internal class DAO_Contract
    {
        public static bool createContract(Contracts contracts)
        {
            return (DAO.Instance.ExecuteNonQuery("exec sp_InsertContracts", CommandType.StoredProcedure,
                new SqlParameter("@ID", contracts.ID),
                new SqlParameter("@StaffID", contracts.StaffID),
                new SqlParameter("@DayStart", contracts.DayStart),
                new SqlParameter("@DayEnd", contracts.DayEnd),
                new SqlParameter("@TypeWork", contracts.E_typeWork),
                new SqlParameter("@Spells", contracts.E_spells),
                new SqlParameter("@SolidSalary", contracts.SolidSalary)) > 0) ? true : false;
        }

        public static bool updateContract(Contracts contracts)
        {
            return (DAO.Instance.ExecuteNonQuery("exec sp_UpdateContracts", CommandType.StoredProcedure,
                new SqlParameter("@ID", contracts.ID),
                new SqlParameter("@StaffID", contracts.StaffID),
                new SqlParameter("@DayStart", contracts.DayStart),
                new SqlParameter("@DayEnd", contracts.DayEnd),
                new SqlParameter("@TypeWork", contracts.E_typeWork),
                new SqlParameter("@Spells", contracts.E_spells),
                new SqlParameter("@SolidSalary", contracts.SolidSalary)) > 0) ? true : false;
        }

        public static bool deleteContract(string id)
        {
            return (DAO.Instance.ExecuteNonQuery("exec sp_DeleteContracts", CommandType.StoredProcedure,
                new SqlParameter("@ID", id)) > 0) ? true : false;
        }

        public static DataTable getAllConstractOfStaff(string staff_id)
        {
            return DAO.Instance.ExecuteQuery($"select * from Contracts where StaffID={staff_id}", CommandType.Text, null);
        }

        public static Contracts getNewestConstractOfStaff(string staff_id)
        {
            DataTable dt = DAO.Instance.ExecuteQuery($"select * from Contracts where StaffID={staff_id} order by DayStart DESC", CommandType.Text, null);
            return new Contracts(dt.Rows[0][0].ToString(), staff_id, (DateTime)dt.Rows[0][2], (DateTime)dt.Rows[0][3],
                dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), float.Parse(dt.Rows[0][6].ToString()));
        }
    }
}
