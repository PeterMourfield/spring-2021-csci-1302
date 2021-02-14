using System;
using System.Collections.Generic;
using System.Text;

namespace csci_1302
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
                    throw new NegativeNumberException("Can't have negative age");
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
                    // Data validation and Error checking
                    throw new ArgumentException("Height can't be less than zero");
                }
                else
                {
                    _height = value;
                }
            }
        }

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

        // Construtors
        public Person()
        {
            // default constructor
        }

        public Person(string firstname, string lastname, int age, int height)
        {
            // Constructor with Property Parameters
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
}
