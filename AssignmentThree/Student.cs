using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    class Student : Person
    {
        string year;
        string major;
        string schoolAddress;

        public Student(string firstName, string lastName, DateTime dateOfBirth, string sex, string address, decimal hourly, string year, string major, string schoolAddress) : base(firstName, lastName, dateOfBirth, sex, address, hourly)
        {
            this.year  = year;
            this.major = major;
            this.schoolAddress = schoolAddress;
        }

        public string Year
        {
            get => year;
        }

        public string Major
        {
            get => major;
            set => major = value;
        }

        public string SchoolAddress
        {
            get => schoolAddress;
        }

        public override string[] getAddresses()
        {
            string[] addresses = { Address, SchoolAddress };
            return addresses;
        }

        // Sets the year of the student to the next acidemic year
        public void increaseYear()
        {
            switch(year)
            {
                case "freshman":
                    year = "sophomore";
                    break;
                case "sophomore":
                    year = "junior";
                    break;
                case "junior":
                    year = "senior";
                    break;
                default:
                    break;
            }
        }
    }
}
