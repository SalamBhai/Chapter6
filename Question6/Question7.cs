using System;

namespace New_folder__6_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    Write a program that calculates N!/K! for given N and K (1<K<N)*/
            Console.WriteLine("Enter first number for N Factorial");
            int x= int.Parse(Console.ReadLine());

            int factorialN= 1;

            for(int i= x; i >0; i-- )
            {
                factorialN= factorialN*i;
            }
            Console.WriteLine(factorialN);

            Console.WriteLine("Enter first number for  K Factorial");
            int y= int.Parse(Console.ReadLine());

            int factorialK= 1;

            for(int i= y; i > 0; i-- )
            {
                factorialK= factorialK*i;
            }
            Console.WriteLine(factorialK);

            int average= factorialN / factorialK;
            Console.WriteLine(average);

           

        }
    }
}


