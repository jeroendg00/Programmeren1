using System;

namespace Oefening_1
{
    class Program
    {
        const double VAT = 0.21;
        static void Main(string[] args)
        {
            Console.Write("Enter a price: ");
            double price = double.Parse(Console.ReadLine());

            double vatPrice = price * VAT;
            double total = price + vatPrice;

            Console.WriteLine($"Price: {price:0.00}, VAT: {vatPrice:0.00}, total: {total:0.00}");

            Console.Write("Enter any key to exit the program");
            Console.ReadKey();
        }
    }
}