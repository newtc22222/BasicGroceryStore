using System;

namespace BasicGroceryStore
{
    public class Contract
    {
        private string iD;
        private string staffID;
        private DateTime dayStart;
        private DateTime dayEnd;
        private string e_typeWork;
        private string e_spells;
        private float solidSalary;

        public string ID { get => iD; set => iD = value; }
        public string StaffID { get => staffID; set => staffID = value; }
        public DateTime DayStart { get => dayStart; set => dayStart = value; }
        public DateTime DayEnd { get => dayEnd; set => dayEnd = value; }
        public string E_typeWork { get => e_typeWork; set => e_typeWork = value; }
        public string E_spells { get => e_spells; set => e_spells = value; }
        public float SolidSalary { get => solidSalary; set => solidSalary = value; }

        public Contract()
        {
            this.iD = GetFormatString.MakingIDNow();
            this.staffID = "";
            this.dayStart = DateTime.Now;
            this.DayEnd = DateTime.Now.AddDays(30);
            this.e_typeWork = TypeWork.fulltime.ToString();
            this.e_spells = null;
            this.solidSalary = 0;
        }

        ~Contract() { }

        public Contract(string iD, string staffID, DateTime dayStart, DateTime dayEnd, 
                         string e_typeWork, string e_spells, float solidSalary)
        {
            this.iD = iD;
            this.staffID = staffID;
            this.dayStart = dayStart;
            this.dayEnd = dayEnd;
            this.e_typeWork = e_typeWork;
            this.e_spells = e_spells;
            this.solidSalary = solidSalary;
        }
    }
}
