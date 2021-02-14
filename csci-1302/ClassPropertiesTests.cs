using System;
using System.Collections.Generic;
using System.Text;

namespace csci_1302
{
    public class ClassPropertiesTests
    {
        public static void Run()
        {
            // test harness
            Person p1 = new Person();
            p1.Firstname = "Steve";
            p1.Lastname = "Williams";
            p1.Age = 25;
            p1.Height = 6;
            Console.WriteLine(p1.ToString());

            Person p2 = new Person
            {
                Firstname = "Larry",
                Lastname = "Adams",
                Age = 50,
                Height = 7
            };
            Console.WriteLine(p2.ToString());

            Person p3 = new Person
            {
                Firstname = "Larry",
                Lastname = "Adams, Jt",
                Age = -5,
                Height = 7
            };
            Console.WriteLine(p3.ToString());

            Person p4 = new Person();
            p4.Firstname = "Steve";
            p4.Lastname = "Williams jr";
            p4.Age = 25;
            //p4.Height = -6; // throws an exception
            Console.WriteLine(p4.ToString());

            Person p5 = new Person("Sally", "Smith", 18, 5);
            Console.WriteLine(p5.ToString());

            Console.WriteLine(p5.IsOver21);
        }
    }
}
