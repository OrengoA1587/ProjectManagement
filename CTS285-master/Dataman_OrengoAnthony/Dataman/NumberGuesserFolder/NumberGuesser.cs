using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanLibrary;
namespace Dataman.NumberGuesser
{
    public class NumberGuesser
    {
        public static void GuessDatamansNumber(ref Player player, ref int numberGuesserScore)
        {
            Console.Clear();
            Random randint = new Random();//Create random object

            bool guessLoop = false;
            string input = "";
            int userGuess = 0; //Users number guess 
            int correctNum = 0; // Correct number

            int numOne = 0; // Hint number one
            int numTwo = 0; // Hint number two
            

            correctNum = randint.Next(9, 100);

            do
            {
                Console.WriteLine(StandardMessages.NumberCheckerTitle());
                Console.WriteLine("Guess the random number from 9-100");
                input = Console.ReadLine();
                if(int.TryParse(input, out userGuess))
                {
                    if (userGuess == correctNum)
                    {
                        Console.WriteLine("Great job! You guessed the random number.\n\nPress Enter..");
                        Console.ReadLine();
                        numberGuesserScore++;
                        Console.Clear();
                        guessLoop = true;
                    }
                    else
                    {
                        int numAdjustOne = randint.Next(1, 10);
                        int numAdjustTwo = randint.Next(1, 10);

                      
                        
                        numOne = correctNum + numAdjustOne;
                        numTwo = correctNum - numAdjustTwo;
                        if (numOne > 100)
                        {
                            numOne = 100;
                        }
                        if (numTwo < 9)
                        {
                            numTwo = 9;
                        }

                        Console.WriteLine($"Wrong number!");
                        Console.WriteLine($"Hint: The number is between {numTwo} and {numOne}.\nPress Enter...");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else 
                {
                    Console.WriteLine("Invalid Entry.");
                }  
            } while (guessLoop == false);
        }
    }
}
