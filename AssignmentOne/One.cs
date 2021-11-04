using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class One
    {
        static public void Start()
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("This program will create your \"hacker\" name.");

            Console.WriteLine("Please enter your favorite color: ");
            sb.Append(Console.ReadLine());

            Console.WriteLine("Please enter your favorite animal: ");
            sb.Append(Console.ReadLine());

            Console.WriteLine("Please enter your favorite number: ");
            sb.Append(Console.ReadLine());

            Console.WriteLine("Hello " + sb.ToString());
            return;
        }
    }
}
