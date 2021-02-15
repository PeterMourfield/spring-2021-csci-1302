using System;
namespace csci_1302
{
    public class Homework2
    {
        public static void Run()
        {
            var result = AddTwoNumbers(uint.MaxValue - 1, 5);
            Console.WriteLine(result);
        }

        public static uint AddTwoNumbers(uint num1, uint num2)
        {
            uint result = num1 + num2;

            if (result < num1 || result < num2)
                throw new ArgumentOutOfRangeException("Number are hard");

            return result;
        }
    }

}