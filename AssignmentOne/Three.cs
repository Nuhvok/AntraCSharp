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
            for(int i = 1; i <=100; i++)
            {
                //Console.WriteLine(i);
                if ((i / 3.0f) % 1 == 0)
                {
                    if ((i / 5.0f) % 1 == 0)
                    {
                        Console.WriteLine("/fizzbuzz/");
                    }
                    else
                    {
                        Console.WriteLine("/fizz/");
                    }

                }
                else if((i / 5.0f) % 1 == 0)
                {
                    Console.WriteLine("/buzz/");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        static public void Start2()
        {
            Console.WriteLine("The max exceeds the possible range and will create an infinite loop.");

            int max = 500;
            for (byte i = 0; i < max; i++)
            {
                Console.WriteLine(i);
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

            while (correctNumber != guessedNumber)
            {
                if(guessedNumber < correctNumber)
                {
                    Console.WriteLine("Your guess was low.");
                }
                else
                {
                    Console.WriteLine("Your guess was high.");
                }

                if(guessedNumber > 3 || guessedNumber < 1)
                {
                    Console.WriteLine("Your guess was also out of range.");
                }
                Console.WriteLine("\nTake a guess: ");
                guessedNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your guess was correct.");
            Console.WriteLine("The correct answer was " + correctNumber);
        }

        static public void Start4()
        {
            int pyramidHeight;

            Console.WriteLine("How tall would you like your pyramid(Only enter odd numbers): ");
            pyramidHeight = int.Parse(Console.ReadLine());

            int spaces = pyramidHeight - 1;
            int stars = 1;

            for (int rows = 0; rows < pyramidHeight; rows++)
            {
                
                    
                for(int i = 0; i < spaces; i++)
                {
                    Console.Write(" ");
                }

                for(int j = 0; j < stars; j++)
                {
                    Console.Write("*");
                }

                spaces--;
                stars += 2;
                Console.Write("\n");
            }
        }

        static public void Start5()
        {
            DateTime bd = new DateTime(1970, 1, 1);
            DateTime current = DateTime.Now;

            Console.WriteLine((current - bd).Days);
        }

        static public void Start6()
        {
            DateTime current = DateTime.Now;

            if(current.Hour >=5 && current.Hour <= 12)
            {
                Console.WriteLine("Good Morning");
            }

            if (current.Hour >= 13 && current.Hour <= 17)
            {
                Console.WriteLine("Good Afternoon");
            }

            if (current.Hour >= 18 && current.Hour <= 22)
            {
                Console.WriteLine("Good Evening");
            }

            if (current.Hour >= 23 || current.Hour <= 4)
            {
                Console.WriteLine("Good Night");
            }    
        }

        static public void Start7()
        {
            for(int index1 = 0; index1 < 4; index1++)
            {
                //for(int index2 = 0; )
            }
        }
    }
}
