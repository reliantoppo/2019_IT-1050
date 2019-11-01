using System;

namespace InClass_Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            //int myNumber;
            Car myMobile = new Car();

            myMobile.make = "Ford";
            myMobile.model = "Mustang";
            myMobile.color = "white";

            Console.WriteLine("Enter the year of your car: ");
            //myMobile.year = Console.ReadLine();
            myMobile.year = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine("My car is a {0} {1} {2} {3}", 
                               myMobile.year, myMobile.color, myMobile.make, myMobile.model);
        }
    }
}
