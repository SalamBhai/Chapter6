using System;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            
         /*Write A program that calculates  N!*K!/(N-K)! for given N and K taking note that:  (1<K<N)*/

            
               ulong factorialK = 1;
               ulong factorialN=1;
               ulong factorialNKdiff=1;

               Console.WriteLine("Enter Number For N Factorial");
               ulong x=  ulong.Parse(Console.ReadLine());
               
             for(ulong i=1; i<=x; i++)
               
             {
                factorialN= factorialN*i;
             } Console.WriteLine(factorialN);


               Console.WriteLine("Enter Number For K Factorial");
               ulong y= ulong.Parse(Console.ReadLine());
             
             for (ulong f =1 ; f<=y; f++)
             {
               factorialK*=f;   
             }
              Console.WriteLine(factorialK);
             ulong difference = x-y;

             for(ulong a=1; a <=difference; a++)
             {
                 factorialNKdiff*=a;
             } Console.WriteLine(factorialNKdiff);

             ulong multFactorialNK= factorialN*factorialK;

             ulong divAndMultFactorialNK= multFactorialNK/(factorialNKdiff);
             Console.WriteLine($"The resultant of the program for the calculation of N!*K!/(N-K)! for given N and K taking note that (1<K<N) is {divAndMultFactorialNK}");
 
             

               
                  

        }
    }
}
