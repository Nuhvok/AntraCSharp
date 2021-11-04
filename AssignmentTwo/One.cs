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
            int[] arrayOne = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }; // Sample array
            int[] arrayTwo = new int[arrayOne.Length];

            // Copies all of the values from arrayOne into arrayTwo
            for (int i = 0; i < arrayOne.Length; i++)
            {
                arrayTwo[i] = arrayOne[i];
            }

            // Prints the values of arrayOne
            Console.WriteLine("Values of arrayOne:");
            foreach (int i in arrayOne)
            {
                Console.WriteLine(i);
            }

            // Prints the values of arrayTwo
            Console.WriteLine("Values of arrayTwo:");
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

            // Loop infinitely
            while (true)
            {
                // Prompt the user and get an input
                Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
                input = Console.ReadLine();

                // Makes a decision based on the first two characters of the input
                switch (input[0] + input[1])
                {
                    // Adds an item to the list
                    case 75: // "+ "
                        // Creates an array that is one slot larger than the old one
                        tempList = new string[aList.Length + 1];
                        // Copies the values into the new array
                        aList.CopyTo(tempList, 0);
                        // Adds the new value
                        tempList[tempList.Length - 1] = input.Split(' ', 2)[1];
                        // Overwrites the old array with the new one and clears the temp array
                        aList = tempList;
                        tempList = null;
                        break;

                    // Deletes an item from the list
                    case 77: // "- "
                        int indexDelete = 0;
                        // Loops through each value in the list
                        foreach (String i in aList)
                        {
                            // If the list item is the same as the requested deletion
                            if (i.CompareTo(input.Split(' ', 2)[1]) == 0)
                            {
                                // Loops through the items following the deletion and moves them up one
                                for (int j = indexDelete + 1; j < aList.Length; j++)
                                {
                                    aList[j - 1] = aList[j];
                                }
                                // Initializes a temporary array one size smaller than the old array
                                tempList = new string[aList.Length - 1];

                                // Puts the values into the temporary array
                                for (int j = 0; j < tempList.Length; j++)
                                {
                                    tempList[j] = aList[j];
                                }

                                // Overwrites the old array with the new one and clears the temp array
                                aList = tempList;
                                tempList = null;

                                // Break the loop so as to only delete one item
                                break;
                            }
                            // Increments the index for the item to be deleted
                            indexDelete++;
                        }
                        break;

                    // Deletes the entire list
                    case 90: // "--"
                        aList = new string[0];
                        break;

                    // Prints an error if the input is not valud
                    default:
                        Console.WriteLine("Input not recognized.");
                        break;
                }

                // Prints the list
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
            int start = 4; // Sample start
            int end = 11;  // Sample end

            int[] primes = new int[0]; // Array to hold the found prime numbers
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
            int[] baseA = { 1, 3, 5, 7 }; // Sample array
            int[] rotatedA;               // Array that has been rotated the allotted amount of times
            int[] sumA;                   // Sum of the values from the same index on the base and rotated array

            int rotate = 11; // Sample number of times to rotate

            // Remove extra full rotations
            rotate = rotate % baseA.Length;

            // Create an array for the rotated values that is the same size as the base
            rotatedA = new int[baseA.Length];

            // Loops through the base array
            for(int i = 0; i < baseA.Length; i++)
            {
                // If the index plus the rotation would be out of bounds, subtract one full array length
                if (i + rotate >= baseA.Length)
                {
                    rotatedA[i + rotate - baseA.Length] = baseA[i];
                }
                // Else place the value at the index plus rotation
                else
                {
                    rotatedA[i + rotate] = baseA[i];
                }

            }

            // Print out the base array
            Console.WriteLine("Base array:");
            foreach (int i in baseA)
            {
                Console.WriteLine(i);
            }

            // Print out the rotated array
            Console.WriteLine("\nRotated array:");
            foreach (int i in rotatedA)
            {
                Console.WriteLine(i);
            }

            // Creates the sum array
            sumA = new int[baseA.Length];

            // Sums the values by index from the base and rotated array
            for (int i = 0; i < baseA.Length; i++)
            {
                sumA[i] = baseA[i] + rotatedA[i];
            }

            // Print out the sum array
            Console.WriteLine("Base array:");
            foreach ( int i in sumA)
            {
                Console.WriteLine(i);
            }
        }

        static public void Start5()
        {
            int[] input = { 2, 4, 4, 5, 5, 5 }; // Sample array

            int longestNumber = input[0]; // Holds the value for the longest consecutive number
            int longestNumberLength = 0;  // Holds the value for the longest consecutive number length
            int currentNumber = input[0]; // Holds the value for the current consecutive number
            int currentNumberLength = 1;  // Holds the value for the current consecutive number length

            // Loops through each value in the input
            for (int i = 1; i < input.Length; i++)
            {
                // if the if the current value is equal to the next value
                if(input[i] == input[i - 1])
                {
                    // Increment the current number length
                    currentNumberLength++;
                }
                // Else check if a new longest consecutive number has been found
                else
                {
                    // If a new longest consecutive number has been found
                    if(currentNumberLength > longestNumberLength)
                    {
                        // Update the longest number and longest number length
                        longestNumber = currentNumber;
                        longestNumberLength = currentNumberLength;
                    }
                    // Set the current number to the next value and reset the current number length
                    currentNumber = input[i];
                    currentNumberLength = 1;
                }
            }

            // One final check for the last group in the array
            if (currentNumberLength > longestNumberLength)
            {
                longestNumber = currentNumber;
                longestNumberLength = currentNumberLength;
            }

            // Print the longest number and the longest number length
            Console.WriteLine(longestNumber);
            Console.WriteLine(longestNumberLength);
        }

        static public void Start6()
        {
            int[] input = { 1, 2, 2, 3, 3, 4, 5 }; // Sample input
            int[][] counts = new int[0][]; // Holds the counts from the input
            int[][] tempCounts;

            // Loops through every value in the input
            foreach (int i in input)
            {
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
