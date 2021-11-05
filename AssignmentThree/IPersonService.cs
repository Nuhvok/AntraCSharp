using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    interface IPersonService
    {
        public abstract int calculateAge();
        public abstract decimal calculateSalary();
        public abstract string[] getAddresses();
    }
}
