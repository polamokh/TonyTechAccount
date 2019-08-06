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

        public Account(string firstName, string lastName, string mobileNumber, int bD_Day, int bD_Month, int bD_Year, string email, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.mobileNumber = mobileNumber;
            this.bD_Day = bD_Day;
            this.bD_Month = bD_Month;
            this.bD_Year = bD_Year;
            this.email = email;
            this.password = password;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string MobileNumber { get => mobileNumber; set => mobileNumber = value; }
        public int BD_Day { get => bD_Day; set => bD_Day = value; }
        public int BD_Month { get => bD_Month; set => bD_Month = value; }
        public int BD_Year { get => bD_Year; set => bD_Year = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
    }
}
