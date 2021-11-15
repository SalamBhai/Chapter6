using System;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a positive integer number 
              //N (N < 20) and prints a matrix of numbers as on the figures below:
               
               int sum=1;
               int a=1;
               int b=1;

              Console.WriteLine("Enter Number ");
              int number= int.Parse(Console.ReadLine());

              for(int k=0; k < number; k++)
              {
                  for(int y=0; y<number; y++)
                  {
                      if(y==0)
                      {
                        Console.Write(sum);
                    
                      }
                      if(y > 0)
                      {
                          sum+=a;
                        Console.Write(sum);
                      }
                      
                  }
                  b++;
                      sum = b;
                      Console.WriteLine();
              } 

        }
    }
}
