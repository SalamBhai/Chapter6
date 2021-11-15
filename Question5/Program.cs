using System;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*       Write a program that reads from the console number N and print the sum
                of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8,13, 21, 34, 55, 89, 144, 233, 377, …                                                                                                      */


             double firstVal= 0;
             double secondVal=1;
             
             
               Console.WriteLine("Enter Number");
               double number= double.Parse(Console.ReadLine());
               for(int i=0; i<=number; i++)
               {
                   double nextVal= secondVal+firstVal;

                   
                     firstVal=secondVal;
                     secondVal=nextVal;

                   Console.WriteLine(nextVal);
               }
            





        }
    }
}
