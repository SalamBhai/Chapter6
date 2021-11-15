using System;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*           Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.*/

                 Console.WriteLine("Enter A Number");
                 int number= int.Parse(Console.ReadLine());
                 Console.WriteLine(number);


                int i=1;
                for(i=1; i<=number; i++)
                {
                    Console.WriteLine(i);
                }
        }
    }
}
