using System;
using System.Data;

namespace BasicGroceryStore
{
    /// <summary>
    /// using for both Import and Order
    /// </summary>
    public interface IBillServices
    {
        /// <summary>
        /// Insert Import bill or Order bill to DBMS
        /// </summary>
        /// <param name="bill"></param>
        
        /// <param name="customerName"></param>
        /// <returns></returns>
        bool Create(Bill bill, string customerName);

        /// <summary>
        /// Update bill or Order bill in DBMS 
        /// </summary>
        /// <param name="bill"></param>
        
        /// <param name="customerName"></param>
        /// <returns></returns>
        bool Update(Bill bill, string customerName);

        /// <summary>
        /// Delete Import bill or Order bill from DBMS
        /// </summary>
        /// <param name="bill"></param>
        
        /// <returns></returns>
        bool Delete(Bill bill);

        /// <summary>
        /// Get all bill in DBMS
        /// </summary>
        /// <returns></returns>
        DataTable GetAllBill();

        /// <summary>
        /// Get value of bill (using for Bill check)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        float GetValueOfBill(string id);

        /// <summary>
        /// get all items of the bill
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable GetAllItemInBill(string id);

        /// <summary>
        /// Get total quantity of bill (using for statistic)
        /// </summary>
        /// <returns></returns>
        int GetQuantityOfBill();

        /// <summary>
        /// Get total value of all bills (using for statistic)
        /// </summary>
        /// <returns></returns>
        double? GetValueOfAllBills();

        /// <summary>
        /// Get total value of all bills in a day (using for statistic)
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        double? GetValueOfAllBills_Day(DateTime date);

        /// <summary>
        /// Get total value of all bills in a month (using for statistic)
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        double? GetValueOfAllBills_Month(DateTime date);


        //DataTable FindBillByDateRange(DateTime from, DateTime to);
    }
}
