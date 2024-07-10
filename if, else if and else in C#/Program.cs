using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if__else_if_and_else_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter the Marks: ");
             int number =Convert.ToInt32(Console.ReadLine());

             // if statement
             if (number > 0)
             {
                 Console.WriteLine("The number is positive.");
             }
             // else if statement
             else if (number < 0)
             {
                 Console.WriteLine("The number is negative.");
             }
             // else statement
             else
             {
                 Console.WriteLine("The number is zero.");
             }

             // Multiple else if conditions
             int grade = 85;

             if (grade >= 90)
             {
                 Console.WriteLine("Grade is A.");
             }
             else if (grade >= 80)
             {
                 Console.WriteLine("Grade is B.");
             }
             else if (grade >= 70)
             {
                 Console.WriteLine("Grade is C.");
             }
             else if (grade >= 60)
             {
                 Console.WriteLine("Grade is D.");
             }
             else
             {
                 Console.WriteLine("Grade is F.");
             }
            */



            Console.WriteLine("Please enter the current hour (0-23): ");
            int hour = Convert.ToInt32(Console.ReadLine());

            if (hour < 12)
            {
                Console.WriteLine("Good morning!");
            }
            else if (hour < 18)
            {
                Console.WriteLine("Good afternoon!");
            }
            else
            {
                Console.WriteLine("Good evening!");
            }
            Console.ReadLine();
        }
    }
}
