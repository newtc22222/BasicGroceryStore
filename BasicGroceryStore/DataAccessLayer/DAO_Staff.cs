using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicGroceryStore
{
    internal class DAO_Staff
    {
        public static bool createStaff(Staff staff)
        {
            return (DAO.Instance.ExcuteNonQuery("sp_InsertStaff",
                    CommandType.StoredProcedure,
                    new SqlParameter("@ID", staff.ID),
                    new SqlParameter("@Name", staff.Name),
                    new SqlParameter("@Gender", staff.Gender),
                    new SqlParameter("@DateOfBirth", staff.DateOfBirth),
                    new SqlParameter("@CitizenID", staff.CitizenID),
                    new SqlParameter("@Address", staff.Address),
                    new SqlParameter("@Phone", staff.Phone),
                    new SqlParameter("@Email", staff.Email),
                    new SqlParameter("@Image", staff.Images)) > 0) ? true : false;
        }

        public static bool updateStaff(Staff staff)
        {
            return (DAO.Instance.ExcuteNonQuery("sp_UpdateStaff",
                     CommandType.StoredProcedure,
                     new SqlParameter("@ID", staff.ID),
                     new SqlParameter("@Name", staff.Name),
                     new SqlParameter("@Gender", staff.Gender),
                     new SqlParameter("@DateOfBirth", staff.DateOfBirth),
                     new SqlParameter("@CitizenID", staff.CitizenID),
                     new SqlParameter("@Address", staff.Address),
                     new SqlParameter("@Phone", staff.Phone),
                     new SqlParameter("@Email", staff.Email),
                     new SqlParameter("@Image", staff.Images)) > 0) ? true : false;
        }

        public static bool deleteStaff(string id)
        {
            return (DAO.Instance.ExcuteNonQuery("sp_DeleteStaff",
                    CommandType.StoredProcedure, new SqlParameter("@id", id)) > 0) ? true : false;
        }

        public static DataTable getAllStaff()
        {
            return DAO.Instance.ExecuteQuery("SELECT * FROM Staff", CommandType.Text, null);
        }

        public static int getNumberOfStaff()
        {
            return 0;
        }

        public static DataTable FindStaffByTAddress(string address)
        {
            return null;
        }

        public static DataTable FindStaffByName(string name)
        {
            return null;
        }

        public static DataTable FindStaffByAgeRange(float from, float to)
        {
            return null;
        }

        public static DataTable FindStaffByConstract(string status)
        {
            return null;
        }

        public static DataTable FindStaffByGender(string gender)
        {
            return null;
        }

        public static DataTable FindStaffBySpells(string spells)
        {
            return null;
        }

        public static DataTable FindStaffByTypeWork(string type)
        {
            return null;
        }
    }
}
