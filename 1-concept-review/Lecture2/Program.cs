using System;

namespace Lecture2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			int a = 1;
			int b = 2;

			Console.Write(1 == b);

			if (a == 1)
			{
				// true
			}
			else if (b < 1000)
			{
				// another
			}
			else
			{

				// false
			}

			switch (a)
			{
				case 1:
					// one thing
					Console.WriteLine("1");
					break;
				case 2:
					// two thing
					Console.WriteLine("2");
					break;
				default:
					Console.WriteLine("3");
					break;
			}

			/*			for (int num1 = 23; num1 < 50; num1++)
						{
						}
			*/
			/*			int num1 = 23;
						while (num1 < 50)
						{
							num1++;
						}

						do
						{
							// inside
						} while (num1 < 50);
			*/
			int c = AddTwoNumbers(1);
			// 3



			var x = "some string";
			Console.WriteLine(x);
		}

		static int AddTwoNumbers(int a, int b = 5)
		{
			return a + b;
		}
	}
}
