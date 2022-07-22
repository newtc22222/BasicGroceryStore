using System;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;

namespace BasicGroceryStore
{
    internal class DAO_Staff : IControl<Staff>, IStaffServices
    {
        public bool Create(Staff staff)
        {
            return (DataProvider.Instance.ExecuteNonQuery("sp_InsertStaff",
                    CommandType.StoredProcedure,
                    new SqlParameter("@ID", staff.ID),
                    new SqlParameter("@Name", staff.Name),
                    new SqlParameter("@Gender", staff.Gender),
                    new SqlParameter("@DateOfBirth", staff.DateOfBirth),
                    new SqlParameter("@CitizenID", staff.CitizenID),
                    new SqlParameter("@Address", staff.Address),
                    new SqlParameter("@Phone", staff.Phone),
                    new SqlParameter("@Email", staff.Email),
                    new SqlParameter("@Image", Convert.ImageToByteArray(staff.Images))) > 0) ? true : false;
        }

        public bool Update(Staff staff)
        {
            return (DataProvider.Instance.ExecuteNonQuery("sp_UpdateStaff",
                     CommandType.StoredProcedure,
                     new SqlParameter("@ID", staff.ID),
                     new SqlParameter("@Name", staff.Name),
                     new SqlParameter("@Gender", staff.Gender),
                     new SqlParameter("@DateOfBirth", staff.DateOfBirth),
                     new SqlParameter("@CitizenID", staff.CitizenID),
                     new SqlParameter("@Address", staff.Address),
                     new SqlParameter("@Phone", staff.Phone),
                     new SqlParameter("@Email", staff.Email),
                     new SqlParameter("@Image", Convert.ImageToByteArray(staff.Images))) > 0) ? true : false;
        }

        public bool Delete(Staff staff)
        {
            return (DataProvider.Instance.ExecuteNonQuery("sp_DeleteStaff",
                    CommandType.StoredProcedure, new SqlParameter("@id", staff.ID)) > 0) ? true : false;
        }

        public Staff GetStaff(string id)
        {
            if (id == "")
                return null;

            DataTable dt = DataProvider.Instance.ExecuteQuery($"select * from Staff where Id='{id}'", CommandType.Text, null);
            DataRow row = dt.Rows[0];

            Image image = null;
            if (row[8] != DBNull.Value)
                image = Convert.ByteArrayToImage((byte[])row[8]);

            Staff staff =  new Staff(row[0].ToString(), row[1].ToString(), row[2].ToString(), 
                                        (DateTime)row[3], row[4].ToString(), row[5].ToString(), 
                                        row[6].ToString(), row[7].ToString(), image);
            return staff;
        }

        public DataTable GetAllStaff()
        {
            return DataProvider.Instance.ExecuteQuery("select * from Staff", CommandType.Text, null);
        }

        public int GetNumberOfStaff()
        {
            return (int)DataProvider.Instance.ExecuteScalar("select func_NumberOfStaff()", CommandType.Text);
        }

        public DataTable FindStaffByAddress(string address)
        {
            return DataProvider.Instance.ExecuteQuery($"select * from func_FindStaffByAddress('{address}')", CommandType.Text);
        }

        public DataTable FindStaffByName(string name)
        {
            return DataProvider.Instance.ExecuteQuery($"select * from func_FindStaffByName('{name}')", CommandType.Text);
        }

        public DataTable FindStaffByAgeRange(float from, float to)
        {
            return DataProvider.Instance.ExecuteQuery($"select * from func_FindStaffByAgeRange({from}, {to})", CommandType.Text);
        }

        public DataTable FindStaffByContractStatus(string status)
        {
            return DataProvider.Instance.ExecuteQuery($"select * from func_FindStaffByContract('{status}')", CommandType.Text);
        }

        public DataTable FindStaffByGender(string gender)
        {
            return DataProvider.Instance.ExecuteQuery($"select * from func_FindStaffByGender('{gender}')", CommandType.Text);
        }

        public DataTable FindStaffBySpells(string spells)
        {
            return DataProvider.Instance.ExecuteQuery($"select * from func_FindStaffBySpells('{spells}')", CommandType.Text);
        }

        public DataTable FindStaffByTypeWork(string typeWork)
        {
            return DataProvider.Instance.ExecuteQuery($"select * from func_FindStaffByTypeWork('{typeWork}')", CommandType.Text);
        }
    }
}
