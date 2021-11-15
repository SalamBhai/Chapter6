using System;

namespace New_folder__9_
{
    class Program
    {
        static void Main(string[] args)
        {
          /*          Question 8 for Catalan Number : 2n!/n+1!(n!)    Write a program that 
             calculates the nth Catalan number by given n.                                                                                                                           */

             ulong factorialN= 1;
             ulong factorialnumberbyTwo=1;
             ulong factorialnadd=1;
             Console.WriteLine("Enter A Number For N Factorial!");
             ulong number= ulong.Parse(Console.ReadLine());

             for(ulong a=1; a<=number; a++)
             {
               factorialN= factorialN*a;
             } Console.WriteLine(factorialN);

             ulong numberbyTwo= 2*number;
            
            for(ulong b=1; b<=numberbyTwo; b++)
            {
              factorialnumberbyTwo= factorialnumberbyTwo * b;
            } 

            ulong numberadd= number+1;
            for(ulong i=1; i<=numberadd; i++ )
            {
              factorialnadd= factorialnadd*i;
            }

            ulong catalan= factorialnumberbyTwo/factorialnadd*factorialN;
            Console.WriteLine($"The nth catalan number is {catalan}");






        }
    }
}
