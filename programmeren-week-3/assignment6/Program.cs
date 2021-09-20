using System;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // ask read parse input
            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine());

            // detmire grade and display result
            if (Enumerable.Range(90, 11).Contains(score))
            {
                Console.WriteLine("grade: A");
                Console.WriteLine("course passed");
            }
            else if (Enumerable.Range(89, 10).Contains(score))
            {
                Console.WriteLine("grade: B");
                Console.WriteLine("course passed");
            }
            else if (Enumerable.Range(70, 10).Contains(score))
            {
                Console.WriteLine("grade: C");
                Console.WriteLine("course passed");
            }
            else if (Enumerable.Range(60, 10).Contains(score))
            {
                Console.WriteLine("grade: D");
                Console.WriteLine("course not passed");
            }
            else if (Enumerable.Range(0, 60).Contains(score))
            {
                Console.WriteLine("grade: F");
                Console.WriteLine("course not passed");
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
        }
    }
}
