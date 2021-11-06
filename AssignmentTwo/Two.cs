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

        static public void Start2() // unfinished
        {
            //string input = "C# is not C++, and PHP is not Delphi!";
            string input = "The quick brown fox jumps over the lazy dog /Yes! Really!!!/.";
            char[] splitDelimiters = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            string[] splitWords = input.Split(splitDelimiters);
            int punct = 0;

            for(int i = splitWords.Length - 2; i > 0; i--)
            {
                Console.Write(splitWords[i]);
            }
        }

        //static public void Start2()
        //{
        //    string input = "C# is not C++, and PHP is not Delphi!";
        //    char[] inputChars = input.ToCharArray();

        //    string[] words = new string[0];
        //    string[] tempWords;
        //    char[] punctuation = new char[0];


        //    int tempStart;
        //    int tempEnd;

        //    tempStart = 0;

        //    for(int i = 0; i < inputChars.Length; i++)
        //    {
        //        switch (inputChars[i])
        //        {
        //            case '.':
        //                punctuation = addPunct('.', punctuation);

        //                break;

        //            case ',':
        //                punctuation = addPunct(',', punctuation);

        //                break;

        //            case ':':
        //                punctuation = addPunct(':', punctuation);

        //                break;

        //            case ';':
        //                punctuation = addPunct(';', punctuation);

        //                break;

        //            case '=':
        //                punctuation = addPunct('=', punctuation);

        //                break;

        //            case '(':
        //                punctuation = addPunct('(', punctuation);

        //                break;

        //            case ')':
        //                punctuation = addPunct(')', punctuation);

        //                break;

        //            case '&':
        //                punctuation = addPunct('&', punctuation);

        //                break;

        //            case '[':
        //                punctuation = addPunct(']', punctuation);

        //                break;

        //            case '"':
        //                punctuation = addPunct('"', punctuation);

        //                break;

        //            case '\'':
        //                punctuation = addPunct('\'', punctuation);

        //                break;

        //            case '\\':
        //                punctuation = addPunct('\\', punctuation);

        //                break;

        //            case '/':
        //                punctuation = addPunct('/', punctuation);

        //                break;

        //            case '!':
        //                punctuation = addPunct('!', punctuation);

        //                break;

        //            case '?':
        //                punctuation = addPunct('?', punctuation);
        //                break;

        //            case ' ':
        //                punctuation = addPunct(' ', punctuation);

        //                break;
        //            default:

        //                break;
        //        }

        //    }

        //    Console.WriteLine(punctuation.Length);
        //    Console.WriteLine(words.Length);

        //}

        private static char[] addPunct(char charToAdd, char[] listOfChars)
        {
            char[] tempPunctuation;
            tempPunctuation = new char[listOfChars.Length + 1];
            for(int i = 0; i < listOfChars.Length; i++)
            {
                tempPunctuation[i] = listOfChars[i];
            }
            tempPunctuation[tempPunctuation.Length - 1] = charToAdd;
            listOfChars = tempPunctuation;
            return listOfChars;
        }

        private static void addString(string stringToAdd, string[] listOfStrings)
        {
            string[] tempString;
            tempString = new string[listOfStrings.Length + 1];
            for (int i = 0; i < listOfStrings.Length; i++)
            {
                tempString[i] = listOfStrings[i];
            }
            tempString[tempString.Length - 1] = stringToAdd;
            listOfStrings = tempString;
        }

        static public void Start3() // unfinished
        {
            string input = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
            char[] splitDelimeters = { ' ', ',', '.', '!', '?', '/', ':', ';' };
            string[] splitResult = input.Split(splitDelimeters);

            foreach(string i in splitResult)
            {
                bool isPalan = true;
                if (i == string.Empty)
                {
                    continue;
                }
                for(int j = 0; j < i.Length / 2; j++)
                {
                    if(i[j] != i[i.Length - j - 1])
                    {
                        isPalan = false;
                        break;
                    }
                }

                if(isPalan)
                {
                    Console.WriteLine(i);
                }


                //Console.WriteLine(i);
            }
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
