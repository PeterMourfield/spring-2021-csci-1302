using System;
using System.Collections.Generic;
using System.Text;

namespace csci_1302
{
    public class ArrayTests
    {
        public static void Run()
        {
            int[] anArray1 = new int[10];
            for(int i = 0; i < anArray1.Length; i++)
            {
                anArray1[i] = i * 2;
            }

            int[] anArray2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int j = 0; j < anArray2.Length; j++)
            {
                Console.WriteLine(anArray2[j]);
            }

            int lookingFor = 8;
            int result1 = LinearSearch(anArray1, lookingFor);
            Console.WriteLine(string.Format("Linear Search found {0} at position {1}", lookingFor, result1));

            int result2 = BinarySearch(anArray2, lookingFor);
            Console.WriteLine(string.Format("Binary Search found {0} at position {1}", lookingFor, result2));
        }

        // 1/10,000 per comparison (==)
        // 142,000
        // WORST CASE = N
        // 142,000 / 10,000  = 14.2 seconds 
        public static int LinearSearch(int[] anArray, int someValueToFind)
        {
            for(int i = 0; i < anArray.Length; i++)
            {
                if (someValueToFind == anArray[i])
                    return i;
            }

            return -1; // not found
        }


        // int[] anArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // Assumption == array is sorted
        // 1/10,000 per comparision (==)
        // 142,000
        // WORST CASE = LOG(N) = 17/10,000
        public static int BinarySearch(int[] anArray, int someValueToFind)
        {
            int mid, first = 0, last = anArray.Length - 1;

            while (first <= last)
            {
                mid = (first + last) / 2;

                if (someValueToFind > anArray[mid]) // search the right half
                    first = mid + 1;
                else if (someValueToFind < anArray[mid]) // search the left half
                    last = mid - 1;
                else
                    return mid; // found it
            }

            return -1; // not found
        }
    }
}