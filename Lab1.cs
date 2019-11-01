using System;

namespace Week1NeilMadaczky
{
	class Program
	{
		static void Main(string[] args)
		{
            // This program multiplies two numbers.

            string str1, str2;
            str1 = "Hello world";
            str2 = "Neil Madaczky";
            
            int num1, num2, num3;

            num1 = 27;
            num2 = 55;

            num3 = num1 * num2;

            Console.WriteLine("The product of " + "num1" + " and " + num2 + " is " + num3);
            Console.WriteLine(str1 + " from " + str2);

            int x = 10;
            x = 20;
            x = 30;
            x = 10;

            Console.WriteLine(x);
        }
	}
}
