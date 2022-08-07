using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DatamanLibrary;

namespace Dataman.Data_Bank
{
    public class ReadFromDocument
    {
        public static void StartDataBankTest(ref string file, string input,ConsoleKeyInfo keyboard,bool problemLoop, ref int setNum, ref string dataSetName)
        {
            Console.Clear();//Clears current screen
            #region Variables
            //Declare and initialize variables
            string convert;           
            int numOne = 0, numTwo = 0, userAnswer = 0, correctAnswer = 0, score = 0, question = 1;
            bool loop = false;
            string[] setOne;
            //------------------------------------------------------------
            #endregion

            #region Read File Test 
            //Check file existence
            if (!File.Exists(file))
            {
                Console.WriteLine("Tell your Mom or Dad to input problems for you!\nPress Enter!");
                Console.ReadLine();
            }
            else
            {
                #region Read File
                using (StreamReader path = new StreamReader(file))
                {

                    try
                    {
                        Console.WriteLine(StandardMessages.DisplayDataQuestions(ref setNum, ref dataSetName));
                        while (!path.EndOfStream)
                        {
                            convert = path.ReadLine();//Convert path into string 
                            setOne = convert.Split(','); //Split CSV file cells by delimitter
                            numOne = int.Parse(setOne[0]); //Set numOne to subscript 0
                            numTwo = int.Parse(setOne[2]); //Set numTwo to subscript 2
                            correctAnswer = int.Parse(setOne[4]); //Set correct answer to subscript 4

                            if (convert.Contains("+"))//Addition
                            {
                                correctAnswer = numOne + numTwo;
                                Console.WriteLine($"Question {question}: {numOne} + {numTwo} = ?");
                                Console.Write("Enter Answer: ");
                                input = Console.ReadLine();

                                if (int.TryParse(input, out userAnswer))
                                {
                                    if (userAnswer == correctAnswer)
                                    {
                                        score++;
                                    }
                                    else
                                    {

                                    }
                                }
                                else
                                {
                                    //Console.WriteLine(StandardMessages.DisplayInvalidOption());
                                }
                            }
                            else if (convert.Contains("-"))//Subtraction
                            {
                                correctAnswer = numOne - numTwo;
                                Console.WriteLine($"Question {question}: {numOne} - {numTwo} = ?");
                                Console.Write("Enter Answer: ");
                                input = Console.ReadLine();

                                if (int.TryParse(input, out userAnswer))
                                {
                                    if (userAnswer == correctAnswer)
                                    {
                                        score++;
                                    }
                                    else
                                    {

                                    }
                                }
                                else
                                {
                                    //Console.WriteLine(StandardMessages.DisplayInvalidOption());
                                }
                            }
                            else if (convert.Contains("x") || file.Contains("X"))//Multiplication
                            {
                                correctAnswer = numOne * numTwo;
                                Console.WriteLine($"Question {question}: {numOne} X {numTwo} = ?");
                                Console.Write("Enter Answer: ");
                                input = Console.ReadLine();

                                if (int.TryParse(input, out userAnswer))
                                {
                                    if (userAnswer == correctAnswer)
                                    {
                                        score++;
                                    }
                                    else
                                    {

                                    }
                                }
                                else
                                {
                                    //Console.WriteLine(StandardMessages.DisplayInvalidOption());
                                }
                            }
                            else if (convert.Contains("/"))//Divide
                            {
                                correctAnswer = numOne / numTwo;
                                Console.WriteLine($"Question {question}: {numOne} / {numTwo} = ?");
                                Console.Write("Enter Answer: ");
                                input = Console.ReadLine();

                                if (int.TryParse(input, out userAnswer))
                                {
                                    if (userAnswer == correctAnswer)
                                    {
                                        score++;
                                    }
                                    else
                                    {

                                    }
                                }
                                else
                                {
                                    //Console.WriteLine(StandardMessages.DisplayInvalidOption());
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        //Display exception for file read errors
                        Console.WriteLine(e);
                    }
                    //Display total score to user
                    Console.WriteLine($"Total Score: {score}\n\nPress Enter....");
                    Console.ReadLine();
                    Console.Clear();
                    #endregion
                }

            }
            #endregion
        }       
    }
}
