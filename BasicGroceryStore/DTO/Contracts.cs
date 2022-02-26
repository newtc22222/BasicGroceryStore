﻿using System;

namespace BasicGroceryStore
{
    public class Contracts
    {
        private string iD;
        private string staffID;
        private DateTime dayStart;
        private DateTime dayEnd;
        private TypeWork e_typeWork;
        private Spells? e_spells;
        private float solidSalary;

        public string ID { get => iD; set => iD = value; }
        public string StaffID { get => staffID; set => staffID = value; }
        public DateTime DayStart { get => dayStart; set => dayStart = value; }
        public DateTime DayEnd { get => dayEnd; set => dayEnd = value; }
        public TypeWork E_typeWork { get => e_typeWork; set => e_typeWork = value; }
        public Spells? E_spells { get => e_spells; set => e_spells = value; }
        public float SolidSalary { get => solidSalary; set => solidSalary = value; }

        public Contracts()
        {
            this.iD = AdditionalFunctions.MakeIDByTime();
            this.staffID = "";
            this.dayStart = DateTime.Now;
            this.DayEnd = DateTime.Now.AddDays(30);
            this.e_typeWork = TypeWork.fulltime;
            this.e_spells = null;
            this.solidSalary = 0;
        }

        ~Contracts() { }

        public Contracts(string iD, string staffID, DateTime dayStart, DateTime dayEnd, 
                         TypeWork e_typeWork, Spells? e_spells, float solidSalary)
        {
            this.iD = iD;
            this.staffID = staffID;
            this.dayStart = dayStart;
            this.DayEnd = dayEnd;
            this.e_typeWork = e_typeWork;
            this.e_spells = e_spells;
            this.solidSalary = solidSalary;
        }
    }
}
