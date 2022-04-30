using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_game
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int playerRandomNum;
            int computerRandomNum;

            int playerPoints = 0;
            int computerPoints = 0;

            Random random = new Random();

                Console.WriteLine("You have 10 Rolls");
                Console.WriteLine("");
                System.Threading.Thread.Sleep(2000);
            for (int i = 0; i < 10; i++)

            {

                Console.WriteLine("Press The Space-Bar to Roll Dice");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 8);
                Console.WriteLine(" You Rolled  " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                computerRandomNum = random.Next(1, 8);
                Console.WriteLine(" CPU Rolled " + computerRandomNum);

                Console.WriteLine("");
                System.Threading.Thread.Sleep(1000);

                Console.WriteLine("******************************");

                if (computerRandomNum == playerRandomNum)
                {
                    Console.WriteLine("Its a Tie");
                }else if(computerRandomNum > playerRandomNum)
                {
                    computerPoints++;
                    Console.WriteLine("Sorry!!! You Lost");
                }
                else
                {   playerPoints++;
                    Console.WriteLine("Congratulations!!! You Won");
                }

                Console.WriteLine("******************************");
                Console.WriteLine("");


            }
            Console.ReadKey(true);
            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("TOTAL SCORE = ");

            Console.WriteLine(playerPoints);
            Console.WriteLine(computerPoints);
            if (computerPoints == playerPoints)
            {
                Console.WriteLine("Its a Tie");
            }
            else if (computerPoints > playerPoints)
            {
                Console.WriteLine("Sorry!!! The Computer Won");
                Console.WriteLine("Bettter Luck Next Time");
            }
            else
            {
                Console.WriteLine("Congratulations!!! You Won");
                Console.WriteLine("YOU ARE THE CHAMPION!!!");
            }


        }
    }
}
