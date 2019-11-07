using System;

/*
 * Optionally instead of answering questions in word document you can just answer the question in comments like this:
 * Question 1: Life is awsome
 */

namespace InClassWeek3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isTrue;

            isTrue = true;

            if (isTrue)
            {
                Console.Write("Hello ");
                Console.Write("World!");
            }

            // Just inserting a blank line to break up between examples.
            Console.WriteLine("");

            int num1 = 30;
            if (num1 > 30)
            {
                Console.WriteLine("num1 is greater than 30");
            }
            else
            {
                if (num1 < 30)
                {
                    Console.WriteLine("num1 is less than 30");
                }
                else
                {
                    Console.WriteLine("num1 is equal to 30");
                }
            }

            // Just inserting a blank line to break up between examples.
            Console.WriteLine("");
            // Grading if else example
            int grade = -100;
            if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("D");
            }
            else if (grade > 0)
            {
                Console.WriteLine("F");
            }
            else
            {
                Console.WriteLine("Invalid Grade");
            }

            // Just inserting a blank line to break up between examples.
            Console.WriteLine("");
            // While loop example
            int counter = 10;
            while (counter > 0)
            {
                Console.WriteLine(counter);
                counter = counter - 2;
            }
        }
    }
}
