using System;

namespace ClassProperties
{
    public class Person
    {
        // auto-implemented properties
        public String Firstname { get; set; }
        public String Lastname { get; set; }

        // Properties with backing field
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    _age = 0;
                }
                else
                {
                    _age = value;
                }                
            }
        }

        private int _height;
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Height can't be less than zero");
                }
                else
                {
                    _height = value;
                }
            }
        }

        // Data validation and Error checking

        // Construtors

        // read-only properties
        public bool IsOver21
        {
            get
            {
                return IsUnder21 == false;
            }
        }

        // restricted-access properties
        private bool IsUnder21
        { 
            get
            {
                return _age < 21;
            }
        }


        public Person()
        {
            // default constructor
        }

        public Person(string firstname, string lastname, int age, int height)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Height = height;
        }

        public override string ToString()
        {
            return string.Format("Firstname: {0} Lastname: {1} Age: {2} Height {3}", Firstname, Lastname, Age, Height);
        }
    }

    class Program
    {
        static void Main(string[] args)
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