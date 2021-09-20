using System;
using System.Globalization;
using System.Threading;

namespace assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // ask read and parse input
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            // check for multiples and display result
            if (num1 % num2 == 0)
            {
                Console.WriteLine("Number 1 is multiple of number 2");
            }
            else if (num2 % num1 == 0)
            {
                Console.WriteLine("Number 2 is multiple of number 1");
            }
            else
            {
                Console.WriteLine("Numbers are no multiples");
            }
        }
    }
}
