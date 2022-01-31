using System;

namespace GroceryStore
{
    abstract class Bills
    {
        private string iD;
        private DateTime dateCreate;
        private float value;
        private string staffID;

        public string ID { get => iD; set => iD = value; }
        public DateTime DateCreate { get => dateCreate; set => dateCreate = value; }
        public float Value { get => value; set => this.value = value; }
        public string StaffID { get => staffID; set => staffID = value; }

        public Bills()
        {
            this.iD = AdditionalFunctions.MakeIDByTime();
            this.dateCreate = DateTime.Now;
            this.value = 0;
            this.staffID = "";
        }

        ~Bills() { }

        public Bills(string iD, DateTime dateCreate, float value, string staffID)
        {
            this.iD = iD;
            this.dateCreate = dateCreate;
            this.value = value;
            this.staffID = staffID;
        }
    }
}
