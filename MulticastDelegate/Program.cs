using System;

namespace Delegates
{
    class SingleDelegate
    {
        public delegate int CalculateSimpleInterest(int a,int b);
        static CalculateSimpleInterest SI = Add;

        static void Main()
        {       
           int add = SI.Invoke(20, 2);
            Console.WriteLine($"Addition of 20 and 2 is {add}", add);
            SI +=  new CalculateSimpleInterest(Multiply);        
   
            int multiply= SI(100, 5);
            Console.WriteLine($"Multiplication of 5 and 100 is {multiply}",multiply);
            Console.ReadKey();
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Multiply(int a,int b)
        {
            return a*b;
        }
    }

}

