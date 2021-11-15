using System;

namespace Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   Write a program that prints all possible cards from a standard deck
                 of cards, without jokers (there are 52 cards: 4 suits of 13 cards) */

                  Console.WriteLine("Welcome! Here Is The S.B Card Spin!");

                 for(int suit=1; suit<=4; suit++)
                 {
                    switch(suit)
                    {
                        case 1:
                        Console.WriteLine(" For Club : ");
                        break;

                        case 2:
                        Console.WriteLine(" For Diamond:  ");
                        break;

                        case 3:
                        Console.WriteLine(" For Heart: ");
                        break;

                        case 4:
                        Console.WriteLine(" For Spade: ");
                        break;

                    }
                  
                  for (int cards=2; cards<=14; cards++)
                  {
                    switch (cards)
                    {
                        case 2:
                          Console.WriteLine("2");
                        break;
                        case 3:
                        Console.WriteLine("3");
                        break;
                        case 4:
                        Console.WriteLine("4");
                        break;
                        case 5:
                        Console.WriteLine("5");
                        break;
                        case 6:
                        Console.WriteLine("6");
                        break;
                        case 7:
                        Console.WriteLine("7");
                        break;
                        case 8:
                        Console.WriteLine("8");
                        break;
                        case 9:
                        Console.WriteLine("9");
                        break;
                        case 10:
                        Console.WriteLine("10");
                        break;
                        case 11:
                        Console.WriteLine("J");
                        break;
                        case 12:
                        Console.WriteLine("Q");
                        break;
                        case 13:
                        Console.WriteLine("K");
                        break;
                        case 14:
                        Console.WriteLine("A");
                        break;
                        

                    }

                  }



                 }
                   
                     


        }
    }
}
