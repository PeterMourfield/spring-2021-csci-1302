using System;
using System.Collections.Generic;
using System.Text;

namespace csci_1302
{
    public class ArrayTests
    {
        public static void Run()
        {
            int[] anArray = new int[11];
            //int[] anArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for(int i = 0; i < anArray.Length; i++)
            {
                anArray[i] = i * 2;
            }

            // anArray[16] = 999;

            for (int j = 0; j < anArray.Length; j++)
            {
                Console.WriteLine(anArray[j]);
            }

            int someNumber = 14;
            // int result = LinearSearch(anArray, someNumber);
            int result = BinarySearch(anArray, someNumber);
            Console.WriteLine(string.Format("Found {0} at position {1}", someNumber, result));
        }

        // comparison (==) 1/10,000
        // 142,000 items
        // 142,000 / 10,000 = 14.2 worst case 
        public static int LinearSearch(int[] anArray, int valueToSearchFor)
        {
            for (int k = 0; k < anArray.Length; k++)
            {
                if (valueToSearchFor == anArray[k])
                    return k; // return index where found
            }
            return -1; // not found case
        }

        // IMPORTANT: BinarySearch MUST BE SORTED!
        // int[] anArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // comparison (==) 1/10,000
        // 142,000 items
        // worst case LOG n - 17 searchs        
        // 17 / 10,000 = 
        public static int BinarySearch(int[] anArray, int valueToSearchFor)
        {
            int mid, first = 0, last = anArray.Length - 1;

            while (first <= last)
            {
                mid = (first + last) / 2;

                if (valueToSearchFor > anArray[mid]) // search right half
                    first = mid + 1;
                else if (valueToSearchFor < anArray[mid]) // search left half
                    last = mid - 1;
                else
                    return mid;
            }

            return -1; // not found case
        }
    }
}
