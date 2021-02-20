using System;

namespace LRCsharp1
{
    class Program
    {
        static void CheckCardsRepetition(int[] takeDeck)
        {
            Random obj = new Random();

            for (int i = 0; i < 36; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (takeDeck[i] == takeDeck[j])
                    {
                        takeDeck[i] = obj.Next(36);

                        CheckCardsRepetition(takeDeck);
                    }
                }
            }
        }
        
        static void Main(string[] args)
        {
            int[] deck = new int[]
            {
                6, 6, 6, 6, // 6
                7, 7, 7, 7, // 7
                8, 8, 8, 8, // 8
                9, 9, 9, 9, // 9
                10, 10, 10, 10, // 10
                11, 11, 11, 11, // Jack
                12, 12, 12, 12, // Lady
                13, 13, 13, 13, // King
                14, 14, 14, 14 // Ace
            };
            
            int[] takeDeck = new int[36];
            int[] arrOne = new int[36];
            int[] arrTwo = new int[36];

            Random obj = new Random();
            
            for (int i = 0; i < 36; i++)
            {
                takeDeck[i] = obj.Next(36);
            }
            
            CheckCardsRepetition(takeDeck);
            
            Console.WriteLine("Hello, this is a popular children's game drunkard");
            Console.WriteLine("This game is played by two bots, you can watch them play");
            Console.WriteLine("Do you want to see cards and operations? (1 - yes / 0 - no)");
            
            string decision = Console.ReadLine();
            int decisionInt = Convert.ToInt32(decision);

            for (int i = 0; i < 18; i++)
            {
                arrOne[i] = takeDeck[i];
            }
            
            int y = 0;

            for (int i = 18; i < 36; i++)
            {
                arrTwo[y] = takeDeck[i];
                y++;
            }
            
            
        }
    }
}