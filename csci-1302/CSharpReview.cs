using System;
namespace csci_1302
{
    public class CSharpReview
    {
        public static void Run()
        {
            // initialize loop condition
            int i = 0;
            // loop condition
            while(i < 10)
            {
                // do some work
                Console.WriteLine(string.Format("i = {0}", i));
                // update loop condition
                i++;
            }

            for(int j = 0; j < 10; j++)
            {
                Console.WriteLine(string.Format("j = {0}", j));
            }
        }
    }
}
