using System;

namespace Delegates
{
    class SingleDelegate
    {
         public delegate double CalculateSimpleInterest(double p, double t, double r);
        static CalculateSimpleInterest SI = getTotalInterest;

        static void Main()
        {
            Console.WriteLine("Invoke Method");
            double totalInterest;
            totalInterest = SI.Invoke(100, 2, 6.78);
            Console.WriteLine($"Total Interest of $100 in  two year at rate of 6.78 % APR is {totalInterest}", totalInterest);

            Console.WriteLine("Passing Method ");
            CalculateSimpleInterest D = new CalculateSimpleInterest(getTotalInterest);
            totalInterest = D(100, 5, 6.78);
            Console.WriteLine($"Total Interest of $100 in five year at rate of 6.78 % APR is {totalInterest}", totalInterest);
            Console.ReadKey();
        }
       
        static double getTotalInterest(double p, double t, double r)
        {
            return (p * t * r) / 100;
        }
    }

}

