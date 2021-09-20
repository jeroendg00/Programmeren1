using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace assignment4
{
    class Program
    {
        const int NumAmount = 3;
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
            Console.Write("Enter thirt number: ");
            int num3 = int.Parse(Console.ReadLine());

            // calculate results
            int sum = num1 + num2 + num3;
            double average = ((double)num1 + (double)num2 + (double)num3) / NumAmount;
            int product = num1 * num2 * num3;

            int[] nums = new int[] { num1, num2, num3 };
            int highest = nums.Max();
            int lowest = nums.Min();

            // display results
            Console.WriteLine($"sum = {sum}");
            Console.WriteLine($"average = {average:0.00}");
            Console.WriteLine($"product = {product}");
            Console.WriteLine($"highest = {highest}");
            Console.WriteLine($"lowest = {lowest}");
        }
    }
}
