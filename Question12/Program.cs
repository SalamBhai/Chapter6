using System;

namespace Question12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number in decimal to be converted to binary");
            int value= int.Parse(Console.ReadLine());

            string toBinary= Convert.ToString(value);
            Console.WriteLine($"The Conversion of the number you entered from decimal to binary is {toBinary}");
        }
    }
}
