using System;
using System.Collections.Generic;
using System.Text;

namespace csci_1302
{
    public class ExceptionTests
    {
        public static void Run()
        {
            string socialsecuritynumber = "hello world";

            try
            {
                int nSSN = int.Parse(socialsecuritynumber);
            }
            catch (FormatException ex)
            {
                throw new ApplicationException("invalid ssn", ex);
            }


            int n1 = 555;
            int n2 = 0;
            int n3 = 0;
            bool theFileIsOpen = false;

            try
            {
                theFileIsOpen = true;
                n3 = n1 / n2;
                //throw new ApplicationException("Foo");
                //Person person = new Person("test", "User", -5, 6);
            }
            catch (System.DivideByZeroException x)
            {
                throw new NegativeNumberException("not really negative", x);
                //Console.WriteLine("Whoops that's bad");
            }
            catch (System.Exception e)
            {
                // write to log
                // buuble up to user
                // ...

                Console.WriteLine("An error occurred");
            }
            finally
            {
                theFileIsOpen = false;
            }

            Console.WriteLine("Hello World!");
        }
    }
}