using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanLibrary;
namespace Dataman
{
    public class ElectroFlashMain
    {
        public static void ElectroFlashMenu(ref Player player, ref int electroFlashScore)
        {
            Console.Clear();
            #region Variable, Sentinels,Classes, and Objects
            double number1 = 0, number2 = 0, answer = 0;           
            const int CARDSIZE = 10;//Set const size for string array
            string[] flashArray = new string[CARDSIZE];
            bool electroLoop = false;
            string input = "";
            
            Random randNum = new Random();//Declare and initialize Random class           
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo();//Declare and initialize console key class
            #endregion

            #region Electro Flash Menu
            do
            {
                Console.WriteLine(StandardMessages.ArithmeticMenu());               
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.Add:
                        Console.Clear();
                        ElectroFlashCardCreator.CreateAdditionFlashCards(ref player, flashArray, number1, number2, randNum);
                        electroFlashScore += player.Score;
                        break;

                    case ConsoleKey.Subtract:
                        Console.Clear();
                        ElectroFlashCardCreator.CreateSubtractionFlashCards(ref player, flashArray, number1, number2, randNum);
                        electroFlashScore += player.Score;
                        break;
                    case ConsoleKey.Multiply:
                        Console.Clear();
                        ElectroFlashCardCreator.CreateMultiplyFlashCards(ref player, flashArray, number1, number2, randNum);
                        electroFlashScore += player.Score;
                        break;
                    case ConsoleKey.Divide:
                        Console.Clear();
                        ElectroFlashCardCreator.CreateDivisionFlashCards(ref player, flashArray, number1, number2, randNum);
                        electroFlashScore += player.Score;
                        break;
                    case ConsoleKey.Escape:
                        electroLoop = true;
                        break;
                }
            } while (electroLoop == false);
            Console.Clear();
            #endregion
        }
    }
}
