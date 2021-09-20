using System;
using System.Globalization;
using System.Threading;

namespace Oefening_2
{
    class Program
    {
        const int Nums = 3;
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;
            
            // Ask input numbers
            Console.Write("Enter 1st number ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter 3rd number ");
            int num3 = int.Parse(Console.ReadLine());

            // Calculate average
            double average = (num1 + num2 + num3) / Nums;

            // Display result
            Console.WriteLine($"The average is: {average:0}");
            // End program
            Console.Write("Enter any key to exit program");
            Console.ReadKey();
        }
    }
}
