using System;

namespace Question11
{
    class Program
    {
        static void Main(string[] args)
        {
                ulong factorialNumber= 1;
                Console.WriteLine("Enter A number");
                ulong number= ulong.Parse(Console.ReadLine());
                long count=0;
            

                for(ulong a=1; a<=number; a++ )
                {
                    factorialNumber*=a;
                } Console.WriteLine(factorialNumber);
                
                for(ulong i=1; i<=number; i++)
             {
                ulong division= factorialNumber/10;
                ulong checkForRemainder= factorialNumber % 10;
              
                if(checkForRemainder==0)
                { 
                    count++;  
                }
                else 
                {
                   break;
                }
                factorialNumber=division; 
             }
               Console.WriteLine($"The amount of zeros in the factorial of the given number is {count}");




        }
    }
}
