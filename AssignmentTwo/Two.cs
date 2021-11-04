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

            // Gets a string
            Console.WriteLine("please enter a string:");
            input = Console.ReadLine();

            // Loops through the string backwards, printing each character
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
        // I apologize for not getting all of this done. The array stuff was very cumbersome
        // because of the contstant changing of size and moving of data and really threw me
        // for a loop. Lists would have made this much easier, but the assignments called
        // for array for some reason.

        // This assignment was also a good deal larger than I thought it would me.
        // I will budget my time better next time.

        static public void Start4()
        {
            string sampleURL = "ftp://www.example.com/employee"; // Sample string
            string[] results = new string[3];
            string[] splitResults;

            // Splits the string on "://" and stores the first string
            splitResults = sampleURL.Split("://", 2);
            results[0] = splitResults[0];
            // Splits the remaining string on "/" and stores the first and second string
            splitResults = splitResults[1].Split("/", 2);
            results[1] = splitResults[0];
            results[2] = splitResults[1];

            // Prints the results
            Console.WriteLine("[protocol] = \"" + results[0] + "\"");
            Console.WriteLine("[server] = \"" + results[1] + "\"");
            Console.WriteLine("[resource] = \"" + results[2] + "\"");
        }
    }
}
