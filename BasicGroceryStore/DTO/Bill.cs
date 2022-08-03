using System;

namespace BasicGroceryStore
{
    public abstract class Bill
    {
        private string iD;
        private DateTime dateCreate;
        private double value;
        private string staffID;

        public string ID { get => iD; set => iD = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public double Value { get => value; set => this.value = value; }
        public string StaffID { get => staffID; set => staffID = value; }

        public Bill()
        {
            this.iD = GetFormatString.MakingIDNow();
            this.dateCreate = DateTime.Now;
            this.value = 0;
            this.staffID = "";
        }

        ~Bill() { }

        public Bill(string iD, DateTime dateCreate, float value, string staffID)
        {
            this.iD = iD;
            this.dateCreate = dateCreate;
            this.value = value;
            this.staffID = staffID;
        }
    }
}
