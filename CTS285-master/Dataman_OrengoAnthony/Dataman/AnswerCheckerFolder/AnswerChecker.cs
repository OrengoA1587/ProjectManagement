using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanLibrary;
using System.Text.RegularExpressions;
namespace Dataman
{
    public class AnswerChecker
    {
        public static void CheckUsersAnswer(ref Player player, ref int answerCheckerScore, ref int countProblems)
        {
            #region Answer Checker
            Console.Clear();//Clear current screen
            #region Variables
            int number1 = 0, number2 = 0, userAnswer = 0, correctAnswer = 0, tryCounter = 0;
            string arithOperator = "", mathProblem, input;                    
            bool answerCheckLoop = false, inputLoop = false;
            #endregion

            #region Input Problem
            try
            {
                do
                {
                    Console.WriteLine(StandardMessages.AnswerCheckerTitle());//Display title to user                   
                    Console.Write("Enter math problem: ");
                    mathProblem = Console.ReadLine(); //Get input from user                     
                    mathProblem = mathProblem.Replace(" ", String.Empty); //Removes all the whitespace in string                      
                    string[] tokens = mathProblem.Split('+', '-', 'x', 'X', '*', '/', '=');//Tokenize users string  
                    
                    //Check input to ensure numbers are valid and do not exceed 100
                    if (int.TryParse(tokens[0], out number1) && (int.TryParse(tokens[1], out number2) && (int.TryParse(tokens[2], out userAnswer)) && (number1 < 100 || number2 < 100))) //Parse string of tokens to integers 
                    {
                        inputLoop = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry!\nExample 1+2=3\n\nPress Enter...");//Display invalid entry to the user
                        Console.ReadLine();
                        Console.Clear();//Clears current screen
                    }
                } while (inputLoop == false);
                #endregion End Input Problem

                #region Math Problem Checker

                #region Addition Checker
                if (mathProblem.Contains("+"))
                {
                    tryCounter = 0;//Reset try counter    
                    countProblems++;//Count problems inputted
                    do
                    {
                        tryCounter++;//Count number of tries
                        if (userAnswer == Calculator.CheckAddition(number1, number2, correctAnswer))//Determine if user answer is correct
                        {
                            Console.WriteLine("Great Job!\n\nPress Enter...");
                            answerCheckLoop = true;//End loop if answer is correct
                            answerCheckerScore++;//Add 1 point to answer checker score
                        }
                        else
                        {
                            if (tryCounter == 2)
                            {
                                Console.WriteLine("You exceeded number of tries!\n" +//If user exceeds the number of tries display the answer to the user
                                "The correct answer is " + Calculator.CheckAddition(number1, number2, correctAnswer) + "\n\nPress Enter...");
                                answerCheckLoop = true;
                            }
                            else if (tryCounter < 2)
                            {
                                Console.WriteLine($"EEE\n\n\nYour answer is incorrect!\n\n" + $"Try again!\nProblem: {number1} + {number2} = ");

                                input = Console.ReadLine();
                                if (int.TryParse(input, out userAnswer))
                                {
                                    if (userAnswer != correctAnswer)
                                    {
                                        Console.WriteLine("EEE");//Display triple E to user for incorrect or invalid input
                                    }
                                    else
                                    {
                                        Console.WriteLine("Great Job!\n\nPress Enter...");
                                        tryCounter = 0;//Reset try counter
                                        answerCheckLoop = true;//End loop
                                        answerCheckerScore++;//Add to score
                                    }
                                }
                            }
                        }
                    } while (answerCheckLoop == false);
                }
                #endregion

                #region Subtraction Checker
                else if (mathProblem.Contains("-"))
                {
                    tryCounter = 0;//Reset counter                    
                    if (number1 < number2)
                    {
                        Console.WriteLine("Invalid entry! Negative number!");
                    }
                    else
                    {
                        do
                        {
                            countProblems++;
                            tryCounter++;
                            if (userAnswer == Calculator.CheckSubtraction(number1, number2, correctAnswer))
                            {
                                Console.WriteLine("Great Job!");
                                tryCounter = 0;
                                answerCheckerScore++;
                                answerCheckLoop = true;
                            }
                            else
                            {
                                if (tryCounter == 2)
                                {
                                    Console.WriteLine("You exceeded number of tries!\n" +
                                        "The correct answer is " + Calculator.CheckSubtraction(number1, number2, correctAnswer) + "\n\nPress Enter...");
                                    tryCounter = 0;
                                    answerCheckLoop = true;
                                }
                                else if (tryCounter < 2)
                                {
                                    Console.WriteLine("EEE\n\nYour answer is incorrect!\n" + $"Try again!\nProblem: {number1} - {number2} = ");
                                    input = Console.ReadLine();
                                    if (int.TryParse(input, out userAnswer))
                                    {
                                        if (userAnswer != correctAnswer)
                                        {
                                            Console.WriteLine("EEE");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Great Job!\n\nPress Enter...");
                                            tryCounter = 0;
                                            answerCheckLoop = true;
                                            answerCheckerScore++;
                                        }
                                    }
                                }
                            }


                        } while (answerCheckLoop == false);

                    }
                }
                #endregion

                #region Multiplication Checker
                else if (mathProblem.Contains("*") || mathProblem.Contains("x") || mathProblem.Contains("X"))
                {
                    tryCounter = 0;
                    countProblems++;
                    do
                    {

                        tryCounter++;
                        if (userAnswer == Calculator.CheckMultiplication(number1, number2, correctAnswer))
                        {
                            Console.WriteLine("Great Job!");
                            answerCheckerScore++;
                            answerCheckLoop = true;
                        }
                        else
                        {
                            if (tryCounter == 2)
                            {
                                Console.WriteLine("You exceeded number of tries!\n" +
                                    "The correct answer is " + Calculator.CheckMultiplication(number1, number2, correctAnswer) + "\n\nPress Enter...");

                                answerCheckLoop = true;
                            }
                            else if (tryCounter < 2)
                            {
                                Console.WriteLine("EEE\n\nYour answer is incorrect!\n" + $"Try again!\nProblem: {number1} * {number2} = ");
                                input = Console.ReadLine();
                                if (int.TryParse(input, out userAnswer))
                                {
                                    if (userAnswer != correctAnswer)
                                    {
                                        Console.WriteLine("EEE");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Great Job!\n\nPress Enter...");
                                        tryCounter = 0;
                                        answerCheckLoop = true;
                                        answerCheckerScore++;
                                    }
                                }
                            }
                        }
                    } while (answerCheckLoop == false);
                }
                #endregion

                #region Division Checker
                else if (mathProblem.Contains("/"))
                {
                    tryCounter = 0;
                    countProblems++;
                    do
                    {

                        tryCounter++;
                        if (userAnswer == Calculator.CheckDivision(number1, number2, correctAnswer))
                        {
                            Console.WriteLine("Great Job!");
                            answerCheckerScore++;
                            answerCheckLoop = true;
                        }
                        else
                        {
                            if (tryCounter == 2)
                            {
                                Console.WriteLine("You exceeded number of tries!\n" +
                                    "The correct answer is " + Calculator.CheckDivision(number1, number2, correctAnswer) + "\n\nPress Enter...");

                                answerCheckLoop = true;
                            }
                            else if (tryCounter < 2)
                            {
                                Console.WriteLine("EEE\n\nYour answer is incorrect!\n" + $"Try again!\nProblem: {number1} / {number2} = ");

                                input = Console.ReadLine();
                                if (int.TryParse(input, out userAnswer))
                                {
                                    if (userAnswer != correctAnswer)
                                    {
                                        Console.WriteLine("EEE");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Great Job!\n\nPress Enter...");
                                        tryCounter = 0;
                                        answerCheckLoop = true;
                                        answerCheckerScore++;
                                    }
                                }
                            }
                        }
                    } while (answerCheckLoop == false);
                }
                #endregion
            }
            //Display message if index is out of range 
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid Entry!\nExample 1+2=3\n\nPress Enter...");
                Console.ReadLine();
                Console.Clear();
            }
            Console.ReadLine();
            Console.Clear();
            #endregion

        }
        #endregion Answer Checker
    }
}
