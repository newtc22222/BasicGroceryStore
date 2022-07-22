using System;
using System.Drawing;

namespace BasicGroceryStore
{
    public class Staff
    {
        private string iD;
        private string name;
        private string gender;
        private DateTime dateOfBirth;
        private string citizenID;
        private string address;
        private string phone;
        private string email;
        private Image images;

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string CitizenID { get => citizenID; set => citizenID = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public Image Images { get => images; set => images = value; }

        public Staff()
        {
            this.iD = GetFormatString.MakingIDNow();
            this.name = "";
            this.gender = "nam";
            this.dateOfBirth = new DateTime(2000, 1, 1);
            this.citizenID = "";
            this.address = "";
            this.phone = "";
            this.email = "";
            this.images = null;
        }

        ~Staff() { }
        
        public Staff(string iD, string name, string gender, DateTime dateOfBirth, string citizenID,
                     string address, string phone, string email, Image images)
        {
            this.iD = iD;
            this.name = name;
            this.gender = gender;
            this.dateOfBirth = dateOfBirth;
            this.citizenID = citizenID;
            this.address = address;
            this.phone = phone;
            this.email = email;
            this.images = images;
        }

        public int getAge()
        {
            return (DateTime.Now.Year - this.dateOfBirth.Year);
        }
    }
}
