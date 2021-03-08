using System;

namespace csci_1302
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //ClassPropertiesTests.Run();
            //ExceptionTests.Run();
            //Homework2.Run();
            //ArrayTests.Run();
            //ArrayTests2D.Run();

            #region Lists

            //GenericList<int> theList = new GenericList<int>();
            //theList.AddHead(1);
            //theList.AddHead(2);
            //theList.AddHead(3);
            //theList.AddTail(1);
            //theList.AddTail(2);
            //theList.AddTail(3);
            GenericList<Person> theList = new GenericList<Person>();
            theList.AddHead(new Person("Sam", "Smith", 55, 4));
            theList.AddTail(new Person("Sally", "Smith", 35, 7));
            foreach (var item in theList)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
