using System;
using System.Data;

namespace BasicGroceryStore
{
    internal class BUS_Imported : IBillServices
    {
        private DAO_Bill dao;

        public BUS_Imported()
        {
            dao = new DAO_Bill("Imported");
        }

        public bool Create(Bill bill, string customerName = "")
        {
            return dao.Create(bill, customerName);
        }

        public bool Update(Bill bill, string customerName = "")
        {
            return dao.Update(bill, customerName);
        }

        public bool Delete(Bill bill)
        {
            return dao.Delete(bill);
        }

        public DataTable GetAllBill()
        {
            return dao.GetAllBill();
        }

        public int GetQuantityOfBill()
        {
            return dao.GetQuantityOfBill();
        }

        public float GetValueOfBill(string bill_id)
        {
            return dao.GetValueOfBill(bill_id);
        }

        public DataTable GetAllItemInBill(string bill_id)
        {
            return dao.GetAllItemInBill(bill_id);
        }

        public double? GetValueOfAllBills()
        {
            double? value = dao.GetValueOfAllBills();
            return (value != null) ? value.Value : 0;
        }

        public double? GetValueOfAllBills_Day(DateTime date)
        {
            double? value = dao.GetValueOfAllBills_Day(date);
            return (value != null) ? value.Value : 0;
        }

        public double? GetValueOfAllBills_Month(DateTime date)
        {
            double? value = dao.GetValueOfAllBills_Month(date);
            return (value != null) ? value.Value : 0;
        }
    }
}
