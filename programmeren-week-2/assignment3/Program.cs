using System;
using System.Globalization;
using System.Threading;

namespace Oefening_3
{
    class Program
    {
        const int DivisionNumber = 60;
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // Ask user for input
            Console.Write("Enter a number of seconds: ");
            // Read input and convert to int
            int seconds = int.Parse(Console.ReadLine());

            // Calculate seconds, minutes and hours
            int leftOverSeconds = seconds % DivisionNumber;
            int minutes = (seconds - leftOverSeconds) / DivisionNumber;
            int leftOverMinutes = minutes % DivisionNumber;
            int hours = (minutes - leftOverMinutes) / DivisionNumber;

            // Display result
            Console.WriteLine($"{hours:00}:{leftOverMinutes:00}:{leftOverSeconds:00}");
            // End program
            Console.Write("Press any key to exit program");
            Console.ReadKey();
        }
    }
}
