using System;
using System.Globalization;
using System.Threading;
namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // ask and read
            Console.Write("Enter a number (1..4): ");
            string input = Console.ReadLine();

            // check input and display correct result
            switch (input)
            {
                case "1":
                    Console.WriteLine("clubs");
                    break;
                case "2":
                    Console.WriteLine("diamonds");
                    break;
                case "3":
                    Console.WriteLine("hearts");
                    break;
                case "4":
                    Console.WriteLine("spades");
                    break;
                default:
                    Console.WriteLine("Incorrect number!");
                    break;
            }
        }
    }
}
