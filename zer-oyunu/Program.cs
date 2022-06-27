using System;

namespace zer_oyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum,rivalRandomNum;
            int playerPoints=0,rivalPoints = 0;
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("press any key");
                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);

                Console.WriteLine(playerRandomNum);

                Console.WriteLine("------");
                System.Threading.Thread.Sleep(700);

                rivalRandomNum = random.Next(1, 7);
                Console.WriteLine(rivalRandomNum);
                if (playerRandomNum>rivalRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("you won this round  ");
                    Console.WriteLine($"your point: {playerPoints} | rival point:{rivalPoints}");
                }
                else if(playerRandomNum<rivalRandomNum)
                {
                    rivalPoints++;
                    Console.WriteLine("rival won this round  ");
                    Console.WriteLine($"your point: {playerPoints} | rival point:{rivalPoints}");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
            }
            if (playerPoints > rivalPoints)
            {
                Console.WriteLine("You won! ");
            }
            else if (rivalPoints > playerPoints)
            {
                Console.WriteLine("Rival won!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }
}
