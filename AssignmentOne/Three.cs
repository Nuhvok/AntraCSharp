using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Three
    {
        static public void Start()
        {
            // Loops through the values 1-100
            for(int i = 1; i <=100; i++)
            {
                // If the current value is divisible by three evenly
                if ((i / 3.0f) % 1 == 0)
                {
                    // If the current value is divisible by three and five evenly
                    if ((i / 5.0f) % 1 == 0)
                    {
                        Console.WriteLine("/fizzbuzz/");
                    }
                    else
                    {
                        Console.WriteLine("/fizz/");
                    }

                }
                // If the current value is divisible by five evenly
                else if ((i / 5.0f) % 1 == 0)
                {
                    Console.WriteLine("/buzz/");
                }
                // If the current value is divisible by neither evenly
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static public void Start2()
        {
            checked
            {
                int max = 500;
                for (byte i = 0; i < max; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static public void Start3()
        {
            int correctNumber = new Random().Next(3) + 1;
            int guessedNumber;

            Console.WriteLine("The computer has chosen a number between 1 and 3.");
            Console.WriteLine("You may guess until you get it right. Good luck.");

            Console.WriteLine("\nTake a guess: ");
            guessedNumber = int.Parse(Console.ReadLine());

            // Loops while the guess is incorrect
            while (correctNumber != guessedNumber)
            {
                // If the guess was below the correct answer
                if(guessedNumber < correctNumber)
                {
                    Console.WriteLine("Your guess was low.");
                }
                // If the guess was above the correct answer
                else
                {
                    Console.WriteLine("Your guess was high.");
                }

                // If the guess was out of the possible range
                if (guessedNumber > 3 || guessedNumber < 1)
                {
                    Console.WriteLine("Your guess was also out of range.");
                }

                // Gets the next guess
                Console.WriteLine("\nTake a guess: ");
                guessedNumber = int.Parse(Console.ReadLine());
            }

            // Prints out the correct guess
            Console.WriteLine("Your guess was correct.");
            Console.WriteLine("The correct answer was " + correctNumber);
        }

        static public void Start4()
        {
            int pyramidHeight; // Number of rows tall the pyramid will be

            Console.WriteLine("How tall would you like your pyramid(Only enter odd numbers): ");
            pyramidHeight = int.Parse(Console.ReadLine());

            int spaces = pyramidHeight - 1; // Number of spaces in a row
            int stars = 1;                  // Number of stars  in a row

            // Loops for each row of the pyramid
            for (int rows = 0; rows < pyramidHeight; rows++)
            {
                // Prints the spaces for a single row    
                for(int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }

                // Prints the stars  for a single row
                for (int j = 0; j < stars; j++)
                {
                    Console.Write("*");
                }

                // Adjusts the spaces and stars for the next row and jumps to the next line
                spaces--;
                stars += 2;
                Console.Write("\n");
            }
        }

        static public void Start5()
        {
            DateTime bd = new DateTime(1970, 1, 1); // Sample date to be evaluated
            DateTime current = DateTime.Now;        // Current date to be evaluated against

            // Prints the number of days between the current date and the sample birthday
            Console.WriteLine((current - bd).Days);
        }

        static public void Start6()
        {
            DateTime current = DateTime.Now;

            // If the hour is between 5am and 12pm
            if(current.Hour >=5 && current.Hour <= 12)
            {
                Console.WriteLine("Good Morning");
            }

            // If the hour is between 1pm and 5pm
            if (current.Hour >= 13 && current.Hour <= 17)
            {
                Console.WriteLine("Good Afternoon");
            }

            // If the hour is between 6pm and 10pm
            if (current.Hour >= 18 && current.Hour <= 22)
            {
                Console.WriteLine("Good Evening");
            }

            // If the hour is between 11pm and 4am
            if (current.Hour >= 23 || current.Hour <= 4)
            {
                Console.WriteLine("Good Night");
            }    
        }

        static public void Start7() // unfinished
        {
            for(int index1 = 0; index1 < 4; index1++)
            {
                //for(int index2 = 0; )
            }
        }
    }
}
