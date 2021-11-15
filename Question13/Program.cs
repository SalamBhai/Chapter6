using System;

namespace Question13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Write a program that converts a given number from binary to decimal notation.*/
           
           Console.WriteLine("Enter A Binary Number i.e 0 and 1 digits number To Be Converted To Decimal Notation ");
           long binNumb= int.Parse(Console.ReadLine());
           
           long toDeci= Convert.ToInt32(binNumb.ToString() , 2);
           Console.WriteLine($"Result of conversion from binary to decimal is {toDeci}");
              

        }
    }
}
