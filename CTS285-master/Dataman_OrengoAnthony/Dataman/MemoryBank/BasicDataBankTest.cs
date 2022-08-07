using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanLibrary;
using System.IO;
namespace Dataman.MemoryBank
{
    public class BasicDataBankTest
    {
        public static void TakeDataBankTest(ref Player player, ref string [] arithArray)
        {
            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Data Bank Game
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithArray.Length)
            {
                //Get answer

                tokens = arithArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('+', '-','x','X','/','=');

                num1 = double.Parse(tokenize[0]);
                num2 = double.Parse(tokenize[1]);

                answer = num1 + num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Answer!");
                }
                index++;
            }


            #endregion Data Bank Game

            #region Player Score Message
            if (player.Score <= 5)
            {
                Console.WriteLine("Good Job, but you need some work. \nKeep playing to get better!");
            }
            Console.WriteLine($"Players Score: {player.Score}");
            if (player.Score >= 5 && player.Score < 8)
            {
                Console.WriteLine("Good Job, but you need some work. \nKeep playing to get better!");
            }
            if (player.Score >= 8 && player.Score <= 9)
            {
                Console.WriteLine("Great Job, Keep up the good work!");
            }
            if (player.Score >= 10)
            {
                Console.WriteLine("Great Job, Flawless Score!");
            }
            Console.ReadLine();
            #endregion Player Score Message
            Console.Clear();
        }
    }
    
}
