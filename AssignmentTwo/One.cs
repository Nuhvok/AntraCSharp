using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTwo
{
    class One
    {
        static public void Start()
        {
            int[] arrayOne = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int[] arrayTwo = new int[arrayOne.Length];

            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayTwo[i] = arrayOne[i];
            }

            Console.WriteLine("Values or arrayOne:");
            foreach (int i in arrayOne)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Values or arrayTwo:");
            foreach (int i in arrayTwo)
            {
                Console.WriteLine(i);
            }
        }

        static public void Start2()
        {
            // This should definitely use a List, but the question wanted it done with an array.
            String[] aList = new string[0];
            String[] tempList;
            String input;

            while (true)
            {
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                input = Console.ReadLine();
                Console.WriteLine(input[0] + input[1]);
                switch (input[0] + input[1])
                {
                    case 75: // "+ "
                        tempList = new string[aList.Length + 1];
                        aList.CopyTo(tempList, 0);
                        tempList[tempList.Length - 1] = input.Split(' ', 2)[1];
                        aList = tempList;
                        tempList = null;
                        break;
                    case 77: // "- "
                        int indexDelete = 0;
                        foreach (String i in aList)
                        {
                            if (i.CompareTo(input.Split(' ', 2)[1]) == 0)
                            {
                                for (int j = indexDelete + 1; j < aList.Length; j++)
                                {
                                    aList[j - 1] = aList[j];
                                }
                                tempList = new string[aList.Length - 1];

                                for (int j = 0; j < tempList.Length; j++)
                                {
                                    tempList[j] = aList[j];
                                }

                                aList = tempList;
                                tempList = null;

                                break;
                            }
                            indexDelete++;
                        }

                        break;

                    case 90: // "--"
                        aList = new string[0];
                        break;

                    default:
                        Console.WriteLine("Input not recognized.");
                        break;
                }

                Console.WriteLine("\nFull list:");
                foreach (String i in aList)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("\n");
            }
        }

        static public void Start3() // broke
        {
            int start = 4;
            int end = 11;

            int[] primes = new int[0];
            int[] tempArray;

            for(int i = start; i <= end; i++)
            {
                for(int j = 2; j < i; j++)
                {
                    Console.WriteLine(i);
                    if ((j/(float)i) % 1 == 0)
                    {
                        
                        tempArray = new int[primes.Length + 1];

                        for (int tempI = 0; tempI < primes.Length; tempI++)
                        {
                            tempArray[tempI] = primes[tempI];
                        }
                        tempArray[tempArray.Length - 1] = i;
                        primes = tempArray;
                        tempArray = null;
                        break;
                    }
                }
            }

            foreach (int i in primes)
                Console.WriteLine(i);
        }

        static public void Start4()
        {
            int[] baseA = { 1, 3, 5, 7 };
            int[] rotatedA;
            int[] sumA;

            int rotate = 11;

            rotate = rotate % baseA.Length;
            rotatedA = new int[baseA.Length];

            for(int i = 0; i < baseA.Length; i++)
            {
                if (i + rotate >= baseA.Length)
                {
                    rotatedA[i + rotate - baseA.Length] = baseA[i];
                }
                else
                {
                    rotatedA[i + rotate] = baseA[i];
                }

            }

            foreach (int i in baseA)
            {
                Console.WriteLine(i);
            }

            foreach (int i in rotatedA)
            {
                Console.WriteLine(i);
            }

            sumA = new int[baseA.Length];
            for (int i = 0; i < baseA.Length; i++)
            {
                sumA[i] = baseA[i] + rotatedA[i];
            }

            foreach( int i in sumA)
            {
                Console.WriteLine(i);
            }
        }

        static public void Start5()
        {
            int[] input = { 2, 4, 4, 5, 5, 5 };
            int longestNumber = input[0];
            int longestNumberLength = 0;
            int currentNumber = input[0];
            int currentNumberLength = 1;

            for(int i = 1; i < input.Length; i++)
            {
                if(input[i] == input[i - 1])
                {
                    currentNumberLength++;
                }
                else
                {
                    if(currentNumberLength > longestNumberLength)
                    {
                        longestNumber = currentNumber;
                        longestNumberLength = currentNumberLength;
                    }
                    currentNumber = input[i];
                    currentNumberLength = 1;
                    
                }
            }

            if (currentNumberLength > longestNumberLength)
            {
                longestNumber = currentNumber;
                longestNumberLength = currentNumberLength;
            }

            Console.WriteLine(longestNumber);
            Console.WriteLine(longestNumberLength);
        }

        static public void Start6()
        {
            int[] input = { 1, 2, 2, 3, 3, 4, 5 };
            int[][] counts = new int[0][];
            int[][] tempCounts;

            foreach (int i in input)
            {
                //bool alreadyFound = false;
                for(int j = 0; j < counts.Length; j++)
                {
                    if(counts[j][1] == input[i])
                    {
                        counts[j][2]++;
                    }
                    else
                    {
                        tempCounts = new int[counts.Length][];
                        for (int tempI = 0; tempI < counts.Length; tempI++)
                        {
                            tempCounts[tempI] = counts[tempI];
                        }
                        tempCounts[tempCounts.Length - 1][1] = i;
                        tempCounts[tempCounts.Length - 1][2] = 1;
                        counts = tempCounts;
                    }
                }
            }

            for (int j = 0; j < counts.Length; j++)
            {
                Console.WriteLine(counts[j][1]);
                Console.WriteLine(counts[j][2]);
            }
        }
    }
}
