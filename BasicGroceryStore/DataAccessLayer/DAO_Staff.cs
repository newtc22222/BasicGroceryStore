using System;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;

namespace BasicGroceryStore
{
    internal class DAO_Staff
    {
        public static bool createStaff(Staff staff)
        {
            return (DAO.Instance.ExecuteNonQuery("sp_InsertStaff",
                    CommandType.StoredProcedure,
                    new SqlParameter("@ID", staff.ID),
                    new SqlParameter("@Name", staff.Name),
                    new SqlParameter("@Gender", staff.Gender),
                    new SqlParameter("@DateOfBirth", staff.DateOfBirth),
                    new SqlParameter("@CitizenID", staff.CitizenID),
                    new SqlParameter("@Address", staff.Address),
                    new SqlParameter("@Phone", staff.Phone),
                    new SqlParameter("@Email", staff.Email),
                    new SqlParameter("@Image", AdditionalFunctions.ConvertImageToByteArray(staff.Images))) > 0) ? true : false;
        }

        public static bool updateStaff(Staff staff)
        {
            return (DAO.Instance.ExecuteNonQuery("sp_UpdateStaff",
                     CommandType.StoredProcedure,
                     new SqlParameter("@ID", staff.ID),
                     new SqlParameter("@Name", staff.Name),
                     new SqlParameter("@Gender", staff.Gender),
                     new SqlParameter("@DateOfBirth", staff.DateOfBirth),
                     new SqlParameter("@CitizenID", staff.CitizenID),
                     new SqlParameter("@Address", staff.Address),
                     new SqlParameter("@Phone", staff.Phone),
                     new SqlParameter("@Email", staff.Email),
                     new SqlParameter("@Image", AdditionalFunctions.ConvertImageToByteArray(staff.Images))) > 0) ? true : false;
        }

        public static bool deleteStaff(string id)
        {
            return (DAO.Instance.ExecuteNonQuery("sp_DeleteStaff",
                    CommandType.StoredProcedure, new SqlParameter("@id", id)) > 0) ? true : false;
        }

        public static Staff getStaff(string id)
        {
            if (id == "")
                return null;

            DataTable dt = DAO.Instance.ExecuteQuery($"select * from Staff where Id='{id}'", CommandType.Text, null);
            DataRow row = dt.Rows[0];

            Image image = null;
            if (row[8] != DBNull.Value)
                image = AdditionalFunctions.ConvertByteArrayToImage((byte[])row[8]);

            Staff staff =  new Staff(row[0].ToString(), row[1].ToString(), row[2].ToString(), 
                                        (DateTime)row[3], row[4].ToString(), row[5].ToString(), 
                                        row[6].ToString(), row[7].ToString(), image);
            return staff;
        }

        public static DataTable getAllStaff()
        {
            return DAO.Instance.ExecuteQuery("select * from Staff", CommandType.Text, null);
        }

        public static int getNumberOfStaff()
        {
            return (int)DAO.Instance.ExecuteScalar("select func_NumberOfStaff()", CommandType.Text);
        }

        public static DataTable FindStaffByAddress(string address)
        {
            return DAO.Instance.ExecuteQuery($"select * from func_FindStaffByAddress('{address}')", CommandType.Text);
        }

        public static DataTable FindStaffByName(string name)
        {
            return DAO.Instance.ExecuteQuery($"select * from func_FindStaffByName('{name}')", CommandType.Text);
        }

        public static DataTable FindStaffByAgeRange(float from, float to)
        {
            return DAO.Instance.ExecuteQuery($"select * from func_FindStaffByAgeRange({from}, {to})", CommandType.Text);
        }

        public static DataTable FindStaffByContract(string status)
        {
            return DAO.Instance.ExecuteQuery($"select * from func_FindStaffByContract('{status}')", CommandType.Text);
        }

        public static DataTable FindStaffByGender(string gender)
        {
            return DAO.Instance.ExecuteQuery($"select * from func_FindStaffByGender('{gender}')", CommandType.Text);
        }

        public static DataTable FindStaffBySpells(string spells)
        {
            return DAO.Instance.ExecuteQuery($"select * from func_FindStaffBySpells('{spells}')", CommandType.Text);
        }

        public static DataTable FindStaffByTypeWork(string type)
        {
            return DAO.Instance.ExecuteQuery($"select * from func_FindStaffByTypeWork('{type}')", CommandType.Text);
        }
    }
}
