using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class Two
    {
        static public void Start()
        {
            String input;

            Console.WriteLine("please enter a string:");
            input = Console.ReadLine();

            for(int i = input.Length; i > 0; i--)
            {
                Console.Write(input[i - 1]);
            }
        }

        static public void Start2()
        {
        }

        static public void Start3()
        {
        }

        static public void Start4()
        {
            string sampleURL = "ftp://www.example.com/employee";
            string[] results = new string[3];
            string[] splitResults;

            splitResults = sampleURL.Split("://", 2);
            results[0] = splitResults[0];
            splitResults = splitResults[1].Split("/", 2);
            results[1] = splitResults[0];
            results[2] = splitResults[1];

            Console.WriteLine("[protocol] = \"" + results[0] + "\"");
            Console.WriteLine("[server] = \"" + results[1] + "\"");
            Console.WriteLine("[resource] = \"" + results[2] + "\"");
        }
    }
}
