using System;

namespace New_folder__10_
{
    class Program
    {
        static void Main(string[] args)
        {
            // To calculate the sum of the given integers n and x//

            Console.WriteLine("Enter Number 1");
            double x= double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            double y= double.Parse(Console.ReadLine());
              double sum= 1;
            double factorialx=1;

            for(long i=1; i<=x; i++ )
            {
                 factorialx= factorialx * i;
                 y= Math.Pow(y,x);
                 
                sum= sum +factorialx/y;
            }
               Console.WriteLine($"The sum of the given integers n and x in accordance with the formula is {sum}");

            
        }
    }
}
