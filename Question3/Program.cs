using System;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Write a program that reads from the console a series of integers and prints the smallest and largest of them.  */

           
           int biggest=0;
           int smallest=0;

           for(int s=1; s<=4; s++)
            {  Console.WriteLine("Enter Number");
              int number= int.Parse(Console.ReadLine());
              
              if (s==1)
              {
                  smallest=number;
              }
              if(number>biggest)
              {
                  biggest=number;
              }
              if(number<smallest)
              {
                  smallest=number;
              }
            }Console.WriteLine($"The Biggest of  the series of integers is {biggest} and the smallest is {smallest}  ");
             

        }
    }
}
