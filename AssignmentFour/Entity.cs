using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentFour
{
    class Entity
    {
        int id;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public override string ToString()
        {
            return "id:   " + id;
        }
    }
}
