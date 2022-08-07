using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DatamanLibrary;
namespace Dataman.Data_Bank
{
    public class WriteToDocument
    {
        public static void WriteToDataSetOneDoc(ref string file, string input, ConsoleKeyInfo keyboard, bool problemLoop)
        {
            #region Write to DataSet One
            //Write problems to csv document
            using (StreamWriter output = File.AppendText(file))
            {
                try
                {
                    do
                    {
                        input = "One";
                        Console.WriteLine(StandardMessages.DisplayDataBankEntryMenu(ref input));
                        keyboard = Console.ReadKey();

                        switch (keyboard.Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                #region Enter Math Problem
                                Console.Clear();
                                Console.WriteLine(StandardMessages.DisplayDataBankTitle(ref input));
                                Console.Write("Enter Math Problem --> ");
                                input = Console.ReadLine();//Enter math problem of choice
                                string[] tokens = input.Split('+', '='); //Splits numbers into an array
                                                                         //TESTING-------------------------------------------------------------------
                                Console.WriteLine("List numbers for testing only. Will be removed\n" +
                                    "upon completion of program. Press Enter...");
                                foreach (var element in tokens)
                                {
                                    Console.WriteLine(element);
                                }
                                //----------------------------------------------------------------------------
                                #endregion

                                #region Output Problems to CSV
                                //Output tokens into to csv document by operator

                                if (input.Contains("+"))
                                {
                                    output.WriteLine($"{tokens[0]},{"+"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("-"))
                                {
                                    output.WriteLine($"{tokens[0]},{"-"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("X") || input.Contains("x") || input.Contains("*"))
                                {
                                    output.WriteLine($"{tokens[0]},{"*"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("/"))
                                {
                                    output.WriteLine($"{tokens[0]},{"/"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                Console.ReadLine();
                                Console.Clear();
                                #endregion
                                break;
                            case ConsoleKey.Escape:
                                problemLoop = true;
                                break;
                            default:
                                Console.WriteLine(StandardMessages.DisplayInvalidOption());
                                break;
                        }
                    } while (problemLoop == false);
                    Console.WriteLine("Successfully wrote to document.\n\nPress Enter to continue.");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            #endregion
        }
        public static void WriteToDataSetTwoDoc(ref string file, string input, ConsoleKeyInfo keyboard, bool problemLoop)
        {
            #region Write to DataSet Two
            input = "Two";
            //Write problems to csv document
            using (StreamWriter output = File.AppendText(file))
            {
                try
                {
                    do
                    {
                        Console.WriteLine(StandardMessages.DisplayDataBankEntryMenu(ref input));
                        keyboard = Console.ReadKey();

                        switch (keyboard.Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                #region Enter Math Problem
                                Console.Clear();
                                Console.WriteLine(StandardMessages.DisplayDataBankTitle(ref input));
                                Console.Write("Enter Math Problem --> ");
                                input = Console.ReadLine();//Enter math problem of choice
                                string[] tokens = input.Split('+', '='); //Splits numbers into an array
                                                                         //TESTING-------------------------------------------------------------------
                                Console.WriteLine("List numbers for testing only. Will be removed\n" +
                                    "upon completion of program. Press Enter...");
                                foreach (var element in tokens)
                                {
                                    Console.WriteLine(element);
                                }
                                //----------------------------------------------------------------------------
                                #endregion

                                #region Output Problems to CSV
                                //Output tokens into to csv document by operator

                                if (input.Contains("+"))
                                {
                                    output.WriteLine($"{tokens[0]},{"+"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("-"))
                                {
                                    output.WriteLine($"{tokens[0]},{"-"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("X") || input.Contains("x") || input.Contains("*"))
                                {
                                    output.WriteLine($"{tokens[0]},{"*"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("/"))
                                {
                                    output.WriteLine($"{tokens[0]},{"/"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                Console.ReadLine();
                                Console.Clear();
                                #endregion
                                break;
                            case ConsoleKey.Escape:
                                problemLoop = true;
                                break;
                            default:
                                Console.WriteLine(StandardMessages.DisplayInvalidOption());
                                break;
                        }
                    } while (problemLoop == false);
                    Console.WriteLine("Successfully wrote to document.\n\nPress Enter to continue.");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            #endregion
        }
        public static void WriteToDataSetThreeDoc(ref string file, string input, ConsoleKeyInfo keyboard, bool problemLoop)
        {
            #region Write to DataSet Three
            input = "Three";
            //Write problems to csv document
            using (StreamWriter output = File.AppendText(file))
            {
                try
                {
                    do
                    {
                        Console.WriteLine(StandardMessages.DisplayDataBankEntryMenu(ref input));
                        keyboard = Console.ReadKey();

                        switch (keyboard.Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                #region Enter Math Problem
                                Console.Clear();
                                Console.WriteLine(StandardMessages.DisplayDataBankTitle(ref input));
                                Console.Write("Enter Math Problem --> ");
                                input = Console.ReadLine();//Enter math problem of choice
                                string[] tokens = input.Split('+', '='); //Splits numbers into an array
                                                                         //TESTING-------------------------------------------------------------------
                                Console.WriteLine("List numbers for testing only. Will be removed\n" +
                                    "upon completion of program. Press Enter...");
                                foreach (var element in tokens)
                                {
                                    Console.WriteLine(element);
                                }
                                //----------------------------------------------------------------------------
                                #endregion

                                #region Output Problems to CSV
                                //Output tokens into to csv document by operator

                                if (input.Contains("+"))
                                {
                                    output.WriteLine($"{tokens[0]},{"+"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("-"))
                                {
                                    output.WriteLine($"{tokens[0]},{"-"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("X") || input.Contains("x") || input.Contains("*"))
                                {
                                    output.WriteLine($"{tokens[0]},{"*"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("/"))
                                {
                                    output.WriteLine($"{tokens[0]},{"/"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                Console.ReadLine();
                                Console.Clear();
                                #endregion
                                break;
                            case ConsoleKey.Escape:
                                problemLoop = true;
                                break;
                            default:
                                Console.WriteLine(StandardMessages.DisplayInvalidOption());
                                break;
                        }
                    } while (problemLoop == false);
                    Console.WriteLine("Successfully wrote to document.\n\nPress Enter to continue.");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            #endregion
        }
        public static void WriteToDataSetFourDoc(ref string file, string input, ConsoleKeyInfo keyboard, bool problemLoop)
        {
            #region Write to DataSet Four
            input = "Four";
            //Write problems to csv document
            using (StreamWriter output = File.AppendText(file))
            {
                try
                {
                    do
                    {
                        Console.WriteLine(StandardMessages.DisplayDataBankEntryMenu(ref input));
                        keyboard = Console.ReadKey();

                        switch (keyboard.Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                #region Enter Math Problem
                                Console.Clear();
                                Console.WriteLine(StandardMessages.DisplayDataBankTitle(ref input));
                                Console.Write("Enter Math Problem --> ");
                                input = Console.ReadLine();//Enter math problem of choice
                                string[] tokens = input.Split('+', '='); //Splits numbers into an array
                                                                         //TESTING-------------------------------------------------------------------
                                Console.WriteLine("List numbers for testing only. Will be removed\n" +
                                    "upon completion of program. Press Enter...");
                                foreach (var element in tokens)
                                {
                                    Console.WriteLine(element);
                                }
                                //----------------------------------------------------------------------------
                                #endregion

                                #region Output Problems to CSV
                                //Output tokens into to csv document by operator

                                if (input.Contains("+"))
                                {
                                    output.WriteLine($"{tokens[0]},{"+"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("-"))
                                {
                                    output.WriteLine($"{tokens[0]},{"-"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("X") || input.Contains("x") || input.Contains("*"))
                                {
                                    output.WriteLine($"{tokens[0]},{"*"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("/"))
                                {
                                    output.WriteLine($"{tokens[0]},{"/"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                Console.ReadLine();
                                Console.Clear();
                                #endregion
                                break;
                            case ConsoleKey.Escape:
                                problemLoop = true;
                                break;
                            default:
                                Console.WriteLine(StandardMessages.DisplayInvalidOption());
                                break;
                        }
                    } while (problemLoop == false);
                    Console.WriteLine("Successfully wrote to document.\n\nPress Enter to continue.");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            #endregion
        }
        public static void WriteToDataSetFiveDoc(ref string file, string input, ConsoleKeyInfo keyboard, bool problemLoop)
        {

            #region Write to DataSet Five
            input = "Five";
            //Write problems to csv document
            using (StreamWriter output = File.AppendText(file))
            {
                try
                {
                    do
                    {
                        Console.WriteLine(StandardMessages.DisplayDataBankEntryMenu(ref input));
                        keyboard = Console.ReadKey();

                        switch (keyboard.Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                #region Enter Math Problem
                                Console.Clear();
                                Console.WriteLine(StandardMessages.DisplayDataBankTitle(ref input));
                                Console.Write("Enter Math Problem --> ");
                                input = Console.ReadLine();//Enter math problem of choice
                                string[] tokens = input.Split('+', '='); //Splits numbers into an array
                                                                         //TESTING-------------------------------------------------------------------
                                Console.WriteLine("List numbers for testing only. Will be removed\n" +
                                    "upon completion of program. Press Enter...");
                                foreach (var element in tokens)
                                {
                                    Console.WriteLine(element);
                                }
                                //----------------------------------------------------------------------------
                                #endregion

                                #region Output Problems to CSV
                                //Output tokens into to csv document by operator

                                if (input.Contains("+"))
                                {
                                    output.WriteLine($"{tokens[0]},{"+"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("-"))
                                {
                                    output.WriteLine($"{tokens[0]},{"-"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("X") || input.Contains("x") || input.Contains("*"))
                                {
                                    output.WriteLine($"{tokens[0]},{"*"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("/"))
                                {
                                    output.WriteLine($"{tokens[0]},{"/"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                Console.ReadLine();
                                Console.Clear();
                                #endregion
                                break;
                            case ConsoleKey.Escape:
                                problemLoop = true;
                                break;
                            default:
                                Console.WriteLine(StandardMessages.DisplayInvalidOption());
                                break;
                        }
                    } while (problemLoop == false);
                    Console.WriteLine("Successfully wrote to document.\n\nPress Enter to continue.");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            #endregion
        }
        public static void CreateDataSet(ref string file, string input, ConsoleKeyInfo keyboard, bool problemLoop)
        {
            #region Write to DataSet Custom
            input = "Custom";
            //Write problems to csv document
            using (StreamWriter output = File.AppendText(file))
            {
                try
                {
                    do
                    {
                        Console.WriteLine(StandardMessages.DisplayDataBankEntryMenu(ref input));
                        keyboard = Console.ReadKey();

                        switch (keyboard.Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                #region Enter Math Problem
                                Console.Clear();
                                Console.WriteLine(StandardMessages.DisplayDataBankTitle(ref input));
                                Console.Write("Enter Math Problem --> ");
                                input = Console.ReadLine();//Enter math problem of choice
                                string[] tokens = input.Split('+', '='); //Splits numbers into an array
                                                                         //TESTING-------------------------------------------------------------------
                                Console.WriteLine("List numbers for testing only. Will be removed\n" +
                                    "upon completion of program. Press Enter...");
                                foreach (var element in tokens)
                                {
                                    Console.WriteLine(element);
                                }
                                //----------------------------------------------------------------------------
                                #endregion

                                #region Output Problems to CSV
                                //Output tokens into to csv document by operator

                                if (input.Contains("+"))
                                {
                                    output.WriteLine($"{tokens[0]},{"+"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("-"))
                                {
                                    output.WriteLine($"{tokens[0]},{"-"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("X") || input.Contains("x") || input.Contains("*"))
                                {
                                    output.WriteLine($"{tokens[0]},{"*"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                else if (input.Contains("/"))
                                {
                                    output.WriteLine($"{tokens[0]},{"/"},{tokens[1]},{"="},{tokens[2]}");
                                }
                                Console.ReadLine();
                                Console.Clear();
                                #endregion
                                break;
                            case ConsoleKey.Escape:
                                problemLoop = true;
                                break;
                            default:
                                Console.WriteLine(StandardMessages.DisplayInvalidOption());
                                break;
                        }
                    } while (problemLoop == false);
                    Console.WriteLine("Successfully wrote to document.\n\nPress Enter to continue.");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                Console.Clear();
            }
            #endregion
        }
    }
}
