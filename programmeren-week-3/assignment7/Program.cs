using System;
using System.Globalization;
using System.Threading;

namespace assignment7
{
    class Program
    {
        const int MeterInCM = 100;
        const int MinBmiMale = 20;
        const int MaxBmiMale = 25;
        const int MinBmiFemale = 19;
        const int MaxBmiFemale = 24;

        static void Main(string[] args)
        {
            // set culture of program
            CultureInfo ci = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = ci;
            Thread.CurrentThread.CurrentCulture = ci;

            // ask read and parse input
            Console.Write("Enter weight (kg): ");
            int weight = int.Parse(Console.ReadLine());
            Console.Write("Enter length (cm): ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("Enter gender (male/female): ");
            string gender = Console.ReadLine();

            // do calculations and display result
            double bmi = weight / (((double)length / MeterInCM) * ((double)length / MeterInCM));
            Console.WriteLine($"bmi-value: {bmi:0.0}");

            if (gender.ToLower() == "male")
            {
                double healthyWeightMin = MinBmiMale * (((double)length / MeterInCM) * ((double)length / MeterInCM));
                double healthyWeightMax = MaxBmiMale * (((double)length / MeterInCM) * ((double)length / MeterInCM));
                Console.WriteLine($"normal bmi-values (min .. max): {MinBmiMale}..{MaxBmiMale}");
                Console.WriteLine($"healthy weight range: {healthyWeightMin:0.0} .. {healthyWeightMax:0.0}");
            }
            else if (gender.ToLower() == "female")
            {
                double healthyWeightMin = MinBmiFemale * (((double)length / MeterInCM) * ((double)length / MeterInCM));
                double healthyWeightMax = MaxBmiFemale * (((double)length / MeterInCM) * ((double)length / MeterInCM));
                Console.WriteLine($"normal bmi-values (min .. max): {MinBmiFemale}..{MaxBmiFemale}");
                Console.WriteLine($"healthy weight range: {healthyWeightMin:0.0} .. {healthyWeightMax:0.0}");
            }
            else
            {
                Console.WriteLine("Unable to calculate normal values for your gender, invalid gender input.");
            }
        }
    }
}
