using System;
using System.Globalization;
using System.Threading;

namespace programming_week_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // ask, read and parse input 1
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            // ask, read and parse input 2
            Console.Write("Enter seconds number: ");
            int num2 = int.Parse(Console.ReadLine());

            // check highest num and display result
            if (num1 > num2)
            {
                Console.WriteLine($"highest value is: {num1}");
                Console.WriteLine($"lowest value is: {num2}");
            }
            else
            {
                Console.WriteLine($"highest value is: {num2}");
                Console.WriteLine($"lowest value is: {num1}");
            }
        }
    }
}
