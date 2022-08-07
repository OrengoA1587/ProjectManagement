using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanLibrary;
namespace Dataman
{
    public class AnswerChecker
    {
        public static void CheckUsersAnswer(ref Player player, ref int answerCheckerScore)
        {
            #region Variables
            int number1 = 0;
            int number2 = 0;
            int userAnswer = 0;
            int correctAnswer = 0;
            string arithOperator = "";
            string mathProblem;
            string revisedMathProblem;
            string input2;
            #endregion

            Console.Clear();
            try
            {
                //Display title to user
                Console.WriteLine(StandardMessages.AnswerCheckerTitle());
                //Get input from user
                Console.Write("Enter math problem: ");
                mathProblem = Console.ReadLine();
                //Removes all the whitespace in string
                mathProblem = mathProblem.Replace(" ", String.Empty); 
                //Tokenize users string 
                string[] tokens = mathProblem.Split(' ', '+', '-', '*', '/', '=', '\t');
                
                //Parse string of tokens to integers
                number1 = int.Parse(tokens[0]);
                number2 = int.Parse(tokens[1]);
                userAnswer = int.Parse(tokens[2]);
                #region Math Problem Checker
                if (mathProblem.Contains("+"))
                {
                    if (userAnswer == Calculator.CheckAddition(number1, number2, correctAnswer))
                    {
                        Console.WriteLine("Great Job!");
                        answerCheckerScore++;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is incorrect!");
                        Console.WriteLine("\nThe correct answer is: " + Calculator.CheckAddition(number1, number2, correctAnswer));
                    }
                }
                else if (mathProblem.Contains("-"))
                {
                    if (number1 < number2)
                    {
                        Console.WriteLine("Invalid entry! Negative number!");
                    }
                    else
                    {
                        if (userAnswer == Calculator.CheckSubtraction(number1, number2, correctAnswer))
                        {
                            Console.WriteLine("Great Job!");
                            answerCheckerScore++;
                        }
                        else
                        {
                            Console.WriteLine("Your answer is incorrect!");
                            Console.WriteLine("\nThe correct answer is: " + Calculator.CheckSubtraction(number1, number2, correctAnswer));
                        }
                    }
                }
                else if (mathProblem.Contains("*") || mathProblem.Contains("x"))
                {
                    if (userAnswer == Calculator.CheckMultiplication(number1, number2, correctAnswer))
                    {
                        Console.WriteLine("Great Job!");
                        answerCheckerScore++;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is incorrect!");
                        Console.WriteLine("\nThe correct answer is: " + Calculator.CheckMultiplication(number1, number2, correctAnswer));
                    }
                }
                else if (mathProblem.Contains("/"))
                {
                    if (userAnswer == Calculator.CheckDivision(number1, number2, correctAnswer))
                    {
                        Console.WriteLine("Great Job!");
                        answerCheckerScore++;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is incorrect!");
                        Console.WriteLine("\nThe correct answer is: " + Calculator.CheckDivision(number1, number2, correctAnswer));
                    }

                }
                Console.WriteLine("Press Enter...");
                Console.ReadLine();
                #endregion
            }
            catch (IndexOutOfRangeException) 
            {
                Console.WriteLine("Invalid Entry!\n Example 1+2=3\n\nPress Enter...");
                Console.ReadLine();
                Console.Clear();
            }
            
            Console.Clear();
        }
    }
}
