using System.Data;

namespace BasicGroceryStore
{
    public interface IStaffServices
    {
        /// <summary>
        /// Get full information of a staff
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Staff GetStaff(string id);

        /// <summary>
        /// Get all staff in DBMS
        /// </summary>
        /// <returns></returns>
        DataTable GetAllStaff();

        /// <summary>
        /// Get the number of staff who are working for the store
        /// </summary>
        /// <returns></returns>
        int GetNumberOfStaff();

        /// <summary>
        /// Get staff data with the staff's address (use for searching)
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        DataTable FindStaffByAddress(string address);

        /// <summary>
        /// Get staff data with the staff's name (use for searching)
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        DataTable FindStaffByName(string name);

        /// <summary>
        /// Get staff data with an age range (use for searching)
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        DataTable FindStaffByAgeRange(float from, float to);

        /// <summary>
        /// Get staff data with the contract status (use for searching)
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        DataTable FindStaffByContractStatus(string status);

        /// <summary>
        /// Get staff data with the staff's gender (use for searching)
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        DataTable FindStaffByGender(string gender);

        /// <summary>
        /// Get staff data with the spells, not use for full-time work (use for searching)
        /// </summary>
        /// <param name="spells"></param>
        /// <returns></returns>
        DataTable FindStaffBySpells(string spells);

        /// <summary>
        /// Get staff data with the type of work, part-time or full-time (use for searching)
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        DataTable FindStaffByTypeWork(string typeWork);
    }
}
