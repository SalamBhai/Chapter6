using System;

namespace Question14
{
    class Program
    {
        static void Main(string[] args)
        {
          /*   Write a program that converts a given number from decimal to 
              hexadecimal notation.   */

              Console.WriteLine("Enter a decimal to get its hexadecimal notation");
              int numDeci= int.Parse(Console.ReadLine());

              string toHex= Convert.ToString(numDeci , 16);
              Console.WriteLine($"The result of conversion from decimal to hexadecimal notation is {toHex}");


        }
    }
}
