using System;
using System.Globalization;
using System.Threading;

namespace assignment8
{
    class Program
    {
        const int MaxWorkHours = 10000;
        const int MaxYearsOfService = 7;
        const int MaxFailures = 25;

        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // ask read and parse input
            Console.Write("Enter first number: ");
            int workHours = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int yearsOfService = int.Parse(Console.ReadLine());
            Console.Write("Enter thirt number: ");
            int failures = int.Parse(Console.ReadLine());

            // check if the machine needs replacement and display result
            if (workHours > MaxWorkHours || yearsOfService >= MaxYearsOfService || failures > MaxFailures)
            {
                Console.WriteLine("Machine needs to be replaced");
            }
            else
            {
                Console.WriteLine("Machine does not need to be replaced");
            }
        }
    }
}
