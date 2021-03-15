using System;
namespace csci_1302
{
    public class Homework3
    {
        public static void Run()
        {
            // GenericList<int> aList = new GenericList<int>();
            // GenericList<string> aList2 = new GenericList<string>();
            // GenericList<Person> people = new GenericList<Person>();
            GenericList<double> myList = new GenericList<double>();
            // 1. Empty List
            myList.RemoveLast();
            if (myList.Count != 0)
                Console.WriteLine("Error in test case 1");
            else
                Console.WriteLine("test case 1 passed");

            // 2.  One Item
            myList.AddHead(5);
            myList.RemoveLast();
            if (myList.Count != 0)
                Console.WriteLine("Error in test case 2");
            else
                Console.WriteLine("test case 2 passed");

            // 3. multiple items
            myList.AddHead(5);
            myList.AddHead(5);
            myList.AddHead(5);
            myList.RemoveLast();
            if (myList.Count != 2)
                Console.WriteLine("Error in test case 3");
            else
                Console.WriteLine("test case 3 passed");


        }
    }
}
