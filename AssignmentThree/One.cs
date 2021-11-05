using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentThree
{
    class One
    {
        // The other methods are static because of how I am doing a pseudo main here. Normally they would not be.
        static public void Start()
        {
            int[] numbers = GenerateNumbers(11);
            Reverse(numbers);
            PrintNumbers(numbers);
        }

        private static int[] GenerateNumbers(int pLength)
        {
            int[] newArray = new int[pLength];

            // Loops through a new array of pLength and populates it
            for (int i = 0; i < pLength; i++)
            {
                newArray[i] = i + 1;
            }
            return newArray;
        }

        private static void Reverse(int[] numbers)
        {
            int tempInt;

            // Loops through hafl of the array, swapping the correspond number on each half
            for (int i = 0; i < (numbers.Length / 2); i++)
            {
                tempInt = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = tempInt;
            }
        }

        private static void PrintNumbers(int[] numbers)
        {
            Console.WriteLine("List of numbers:");
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            return;
        }

        static public void Start2()
        {
            int input = 8;

            Console.WriteLine("First ten Fibonacci numbers:");
            Console.WriteLine(1);
            Console.WriteLine(1);
            for (int i = 3; i <= 10; i++)
            {
                Console.WriteLine(Fibonacci(1, 1, i - 2));
            }

            Console.WriteLine("Sample Fibonacci number:");
            switch (input)
            {
                case 1:
                    Console.WriteLine(1);
                    break;

                case 2:
                    Console.WriteLine(1);
                    break;

                default:
                    Console.WriteLine(Fibonacci(1, 1, input - 2));
                    break;
            }
        }

        // This method can calculate a Fibonacci number. The input should be the number desired minus 2.
        private static int Fibonacci(int precedentOne, int precedentTwo, int input)
        {
            int nextNum = precedentOne + precedentTwo;
            input--;

            if (input > 0)
            {
                return Fibonacci(precedentTwo, nextNum, input);
            }
            else
            {
                return nextNum;
            }
        }

        static public void Start3()
        {
            DateTime firstDate = DateTime.Now.AddDays(30);
            DateTime secondDate = DateTime.Now;
            int daysCount = 0;
            bool isNotHoliday = false;
            bool isNotWeekend = false;

            DateTime somedate = new DateTime(2021, 11, 11);
            int dayoyr = somedate.DayOfYear;

            while ((firstDate - secondDate).Days > 0)
            {
                switch (secondDate.Date.DayOfYear)
                {
                    case 315:
                        break;
                    case 329:
                        break;
                    case 358:
                        break;
                    default:
                        isNotHoliday = true;
                        break;
                }

                switch (secondDate.Date.DayOfWeek)
                {
                    case DayOfWeek.Saturday:
                        break;
                    case DayOfWeek.Sunday:
                        break;
                    default:
                        isNotWeekend = true;
                        break;
                }

                if(isNotHoliday && isNotWeekend)
                {
                    daysCount++;
                }

                secondDate = secondDate.AddDays(1);
            }
            Console.WriteLine(daysCount);
        }

        static public void Start4()
        {
            Console.WriteLine(new DateTime(2021, 11, 11).DayOfYear);
            Console.WriteLine(new DateTime(2021, 11, 25).DayOfYear);
            Console.WriteLine(new DateTime(2021, 12, 24).DayOfYear);
        }
    }
}
