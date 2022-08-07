using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Threading;
using System.Timers;
using Dataman.ElectroFlashClasses;
using DatamanLibrary;
namespace Dataman
{
    public class ElectroFlashCardCreator
    {
        #region Electro Flash Card Creator(ADD,SUB,MUL,DIV)
        public static void CreateAdditionFlashCards(ref Player player,string[] addArray,double number1, double number2, Random randNum)
        {
            Console.Clear();
            #region Variable, Sentinels, and Objects
            string fnum1 = "";
            string fnum2 = "";
            bool numberMenu = false;
            Timer t = new Timer(1000);
            
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo();
            #endregion

            #region Create Addition Flash Cards
            do
            {
                Console.WriteLine(StandardMessages.ElectroFlashCardOption());
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        for (int i = 0; i < addArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 9);
                            number2 = randNum.Next(0, 9);
                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();
                            addArray[i] = fnum1 + "+" + fnum2 + "=";
                        }
                        ElectroFlashGame.AddZeroToNine(ref player, ref addArray);
                        
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        for (int i = 0; i < addArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 49);
                            number2 = randNum.Next(0, 49);

                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();

                            addArray[i] = fnum1 + " + " + fnum2 + " = ";

                        }
                        ElectroFlashGame.AddZeroToFourNine(ref player, ref addArray);
                        
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        for (int i = 0; i < addArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 99);
                            number2 = randNum.Next(0, 99);

                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();

                            addArray[i] = fnum1 + " + " + fnum2 + " = ";

                        }
                        ElectroFlashGame.AddZeroToNinetyNine(ref player, ref addArray);
                        
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        for (int i = 0; i < addArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 499);
                            number2 = randNum.Next(0, 499);

                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();

                            addArray[i] = fnum1 + " + " + fnum2 + " = ";

                        }
                        ElectroFlashGame.AddZeroToFourNinetyNine(ref player, ref addArray);
                        break;

                    case ConsoleKey.Escape:

                        numberMenu = true;
                        break;
                }
                Console.Clear();
            } while (numberMenu == false);
            Console.Clear();
        }
        #endregion
            

        public static void CreateSubtractionFlashCards(ref Player player, string[] subtractArray, double number1, double number2, Random randNum)
        {
            Console.Clear();
            #region Variable, Sentinels, and Objects
            string fnum1 = "";
            string fnum2 = "";
            bool numberMenu = false;
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo();
            #endregion

            #region Create Subtraction Flash Cards
            do
            {
                Console.Write(StandardMessages.ElectroFlashCardOption());
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        for (int i = 0; i < subtractArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 9);
                            number2 = randNum.Next(0, 9);
                            while(number1 < number2)
                            {
                                number1 = randNum.Next(0, 9);
                                number2 = randNum.Next(0, 9);
                            }   
                            
                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();
                            subtractArray[i] = fnum1 + "-" + fnum2 + "=";
                        }
                        ElectroFlashGame.SubtractZeroToNine(ref player, ref subtractArray);
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        for (int i = 0; i < subtractArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 49);
                            number2 = randNum.Next(0, 49);

                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();

                            subtractArray[i] = fnum1 + " - " + fnum2 + " = ";

                        }
                        ElectroFlashGame.SubtractZeroToFourNine(ref player, ref subtractArray);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        for (int i = 0; i < subtractArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 99);
                            number2 = randNum.Next(0, 99);

                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();

                            subtractArray[i] = fnum1 + " - " + fnum2 + " = ";

                        }
                        ElectroFlashGame.SubtractZeroToNinetyNine(ref player, ref subtractArray);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        for (int i = 0; i < subtractArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 499);
                            number2 = randNum.Next(0, 499);

                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();

                            subtractArray[i] = fnum1 + " - " + fnum2 + " = ";

                        }
                        ElectroFlashGame.SubtractZeroToFourNinetyNine(ref player, ref subtractArray);
                        break;

                    case ConsoleKey.Escape:

                        numberMenu = true;
                        break;
                }
                Console.Clear();
            } while (numberMenu == false);
            Console.Clear();
        }

        #endregion

        public static void CreateMultiplyFlashCards(ref Player player, string[] multiplyArray, double number1, double number2, Random randNum)
        {
            Console.Clear();
            #region Variable, Sentinels, and Objects
            string fnum1 = "";
            string fnum2 = "";
            bool numberMenu = false;
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo();
            #endregion

            #region Create Multiplication Flash Cards
            do
            {
                Console.Write(StandardMessages.ElectroFlashCardOption());
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        for (int i = 0; i < multiplyArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 9);
                            number2 = randNum.Next(0, 9);
                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();
                            multiplyArray[i] = fnum1 + "*" + fnum2 + "=";
                        }
                        ElectroFlashGame.MultiplyZeroToNine(ref player, ref multiplyArray);

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        for (int i = 0; i < multiplyArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 49);
                            number2 = randNum.Next(0, 49);

                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();

                            multiplyArray[i] = fnum1 + " * " + fnum2 + " = ";

                        }
                        ElectroFlashGame.MultiplyZeroToFourNine(ref player, ref multiplyArray);                        
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        for (int i = 0; i < multiplyArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 99);
                            number2 = randNum.Next(0, 99);

                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();

                            multiplyArray[i] = fnum1 + " * " + fnum2 + " = ";
                        }
                        ElectroFlashGame.MultiplyZeroToNinetyNine(ref player, ref multiplyArray);                         
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        for (int i = 0; i < multiplyArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 499);
                            number2 = randNum.Next(0, 499);

                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();

                            multiplyArray[i] = fnum1 + " * " + fnum2 + " = ";
                        }
                        ElectroFlashGame.MultiplyZeroToFourNinetyNine(ref player, ref multiplyArray);                         
                        break;
                    case ConsoleKey.Escape:
                        numberMenu = true;
                        break;
                }
                Console.Clear();
            } while (numberMenu == false);
            Console.Clear();
        }
        #endregion

        public static void CreateDivisionFlashCards(ref Player player, string[] divideArray, double number1, double number2, Random randNum)
        {
            Console.Clear();
            #region Variable, Sentinels, and Objects
            string fnum1 = "";
            string fnum2 = "";
            bool numberMenu = false;
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo();
            #endregion

            #region Create Division Flash Cards
            do
            {
                Console.Write(StandardMessages.ElectroFlashCardOption());
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        for (int i = 0; i < divideArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 9);
                            number2 = randNum.Next(0, 9);
                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();
                            divideArray[i] = fnum1 + "/" + fnum2 + "=";
                        }
                        ElectroFlashGame.DivideZeroToNine(ref player, ref divideArray);

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        for (int i = 0; i < divideArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 49);
                            number2 = randNum.Next(0, 49);

                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();

                            divideArray[i] = fnum1 + " / " + fnum2 + " = ";

                        }
                        ElectroFlashGame.DivideZeroToFourNine(ref player, ref divideArray);
                        
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        for (int i = 0; i < divideArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 99);
                            number2 = randNum.Next(0, 99);

                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();

                            divideArray[i] = fnum1 + " / " + fnum2 + " = ";
                        }
                        ElectroFlashGame.DivideZeroToNinetyNine(ref player, ref divideArray);                       
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        for (int i = 0; i < divideArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 499);
                            number2 = randNum.Next(0, 499);

                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();

                            divideArray[i] = fnum1 + " / " + fnum2 + " = ";
                        }
                        ElectroFlashGame.DivideZeroToFourNinetyNine(ref player, ref divideArray);                         
                        break;

                    case ConsoleKey.Escape:

                        numberMenu = true;
                        break;
                }
                Console.Clear();
            } while (numberMenu == false);
            Console.Clear();
        }
        #endregion
    }
    #endregion
}
