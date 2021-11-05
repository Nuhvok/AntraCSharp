using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    abstract class Person : IPersonService
    {
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string sex;
        private string address;
        private decimal hourly;

        protected Person(string firstName, string lastName, DateTime dateOfBirth, string sex, string address, decimal hourly)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.sex = sex;
            this.address = address;
            this.hourly = hourly;
        }

        public string FirstName
        {
            get => firstName;
        }

        public string LastName
        {
            get => lastName;
        }

        public DateTime DateOfBirth
        {
            get => dateOfBirth;
        }

        public string Sex
        {
            get => sex;
        }

        virtual public string Address
        {
            get => address;
        }

        public decimal Hourly
        {
            get => hourly;
        }

        public int calculateAge()
        {
            return Convert.ToInt32(((DateTime.Now - DateOfBirth).Days / 365.25f));
        }

        public decimal calculateSalary()
        {
            return hourly * 40.0m * 50.0m;
        }

        virtual public string[] getAddresses()
        {
            string[] addresses = { Address };
            return addresses;
        }
    }
}
