using System;
using System.Collections.Generic;
using System.Text;

namespace csci_1302
{
    public class ArrayTests
    {
        public static void Run()
        {
            int[] anArray = new int[10];
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
        }
    }
}
