using System;

namespace Question16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*     Write a program that by a given integer N prints the numbers from 1 to N 
         in random order                                                                                */
            
            Console.WriteLine("Enter Number");
            int choice = int.Parse(Console.ReadLine());

            int[] number= new int[choice];

            bool flag = true;
            while(flag)
            {
                Random random= new Random();
                int rand= random.Next(1, number.Length);

                foreach(int a in number)
                {
                    if (a != rand)
                    {
                        
                    }
                }
                

                
            }

            for(int i=1; i<=number; i++)
            {
                Console.WriteLine(i);
            }


            

        }
    }
}
