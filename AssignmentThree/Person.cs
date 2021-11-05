using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    abstract class Person
    {
        protected abstract string FirstName { get; }
        protected abstract string LastName { get; }
        protected abstract DateTime DateOfBirth { get; }
        protected abstract string Sex { get; }

        public int getAge()
        {
            return Convert.ToInt32(((DateTime.Now - DateOfBirth).Days / 365.25f));
        }
    }
}
