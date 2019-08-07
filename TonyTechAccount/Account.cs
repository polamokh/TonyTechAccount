using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TonyTechAccount
{
    class Account
    {
        private string firstName;
        private string lastName;
        private string mobileNumber;
        private int bD_Day;
        private int bD_Month;
        private int bD_Year;
        private string email;
        private string password;
        private string type;
        private string created_On;

        public Account(string firstName, string lastName, string mobileNumber, int bD_Day, int bD_Month, int bD_Year, string email, string password, string type, string created_On)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.MobileNumber = mobileNumber;
            this.BD_Day = bD_Day;
            this.BD_Month = bD_Month;
            this.BD_Year = bD_Year;
            this.Email = email;
            this.Password = password;
            this.Type = type;
            this.Created_On = created_On;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string MobileNumber { get => mobileNumber; set => mobileNumber = value; }
        public int BD_Day { get => bD_Day; set => bD_Day = value; }
        public int BD_Month { get => bD_Month; set => bD_Month = value; }
        public int BD_Year { get => bD_Year; set => bD_Year = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }
        public string Created_On { get => created_On; set => created_On = value; }
    }
}
