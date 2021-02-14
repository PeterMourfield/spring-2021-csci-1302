using System;
using System.Collections.Generic;
using System.Text;

namespace csci_1302
{
    public class NegativeNumberException : System.Exception
    {
        public NegativeNumberException() : base()
        {

        }

        public NegativeNumberException(string message) : base(message)
        {

        }
        public NegativeNumberException(string message, Exception ex) : base(message, ex)
        {

        }

        public override string ToString()
        {
            return "You got NegativeNumberException";
        }
    }
}
