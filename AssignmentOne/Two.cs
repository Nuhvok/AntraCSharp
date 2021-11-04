using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Two
    {
        static public void Start()
        {
            Console.WriteLine("{0,-10} {1,5} {2,30} {3,30}\n", "Type", "Bytes", "MaxSize", "MinSize");

            Console.WriteLine("{0,-10} {1,5} {2,30} {3,30}", "SByte", sizeof(sbyte), sbyte.MaxValue, sbyte.MaxValue);
            Console.WriteLine("{0,-10} {1,5} {2,30} {3,30}", "Byte", sizeof(byte), byte.MaxValue, byte.MaxValue);
            Console.WriteLine("{0,-10} {1,5} {2,30} {3,30}", "Short", sizeof(short), short.MaxValue, short.MaxValue);
            Console.WriteLine("{0,-10} {1,5} {2,30} {3,30}", "UShort", sizeof(ushort), ushort.MaxValue, ushort.MaxValue);
            Console.WriteLine("{0,-10} {1,5} {2,30} {3,30}", "Int", sizeof(int), int.MaxValue, int.MaxValue);
            Console.WriteLine("{0,-10} {1,5} {2,30} {3,30}", "UInt", sizeof(uint), uint.MaxValue, uint.MaxValue);
            Console.WriteLine("{0,-10} {1,5} {2,30} {3,30}", "Long", sizeof(long), long.MaxValue, long.MaxValue);
            Console.WriteLine("{0,-10} {1,5} {2,30} {3,30}", "ULong", sizeof(ulong), ulong.MaxValue, ulong.MaxValue);
            Console.WriteLine("{0,-10} {1,5} {2,30} {3,30}", "Float", sizeof(float), float.MaxValue, float.MaxValue);
            Console.WriteLine("{0,-10} {1,5} {2,30} {3,30}", "Double", sizeof(double), double.MaxValue, double.MaxValue);
            Console.WriteLine("{0,-10} {1,5} {2,30} {3,30}", "Decimal", sizeof(decimal), decimal.MaxValue, decimal.MaxValue);
        }

        static public void Start2()
        {
            int centuries;
            int years;
            int days;
            int hours;
            long minutes;
            long seconds;
            long milliseconds;
            long nanoseconds;
            try
            {
                Console.WriteLine("Enter a number of centuries: ");
                centuries = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Not a valid integer.");
                return;
            }

            try
            {
                years = checked(centuries * 100);
                days = checked((years * 365) + (years / 4));
                hours = checked(days * 24);
                minutes = checked(hours * 60l);
                seconds = checked(minutes * 60l);
                milliseconds = checked(seconds * 1000l);
                nanoseconds = checked(milliseconds * 1000l);
            }
            catch(Exception)
            {
                Console.WriteLine("An overflow occurred");
                    return;
            }
            Console.WriteLine("{0,-20} {1,20}\n", "Type", "Amount");

            Console.WriteLine("{0,-20} {1,20}\n", "Centuries", centuries);
            Console.WriteLine("{0,-20} {1,20}\n", "Years", years);
            Console.WriteLine("{0,-20} {1,20}\n", "Days", days);
            Console.WriteLine("{0,-20} {1,20}\n", "Hours", hours);
            Console.WriteLine("{0,-20} {1,20}\n", "Minutes", minutes);
            Console.WriteLine("{0,-20} {1,20}\n", "Seconds", seconds);
            Console.WriteLine("{0,-20} {1,20}\n", "Milliseconds", milliseconds);
            Console.WriteLine("{0,-20} {1,20}\n", "Nanoseconds", nanoseconds);
        }
    }
}
