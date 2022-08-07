using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanLibrary;
using System.IO;
using System.Windows.Forms;
using WinFormUI;
namespace Dataman.MemoryBank
{
    public class BasicMemoryBank
    {
        public static void CreateBasicMemoryBank(ref Player player, ref Administrator admin, ConsoleKeyInfo keyboard)
        {
            #region Variables,Classes, and Objects
            Console.Clear();
            bool loop = false, adminMenuLoop = false, checkPass = false;
             
            string input = "";
            string file = "";
            int count = 0;
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            #endregion


            #region Basic Memory Bank Menu
            file = dir + @"\MemoryBankDocuments_Dataman\MemoryBankTenQuestions.csv"; //Set file with directory information
            do
            {
                Console.WriteLine(StandardMessages.DisplayDataBankMainMenu());//Display memory bank menu to user
                keyboard = Console.ReadKey();//Get keyboard input from user
                switch (keyboard.Key)
                {
                    //Admin mode
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        Dataman.Data_Bank.VerifyAdminPassword.PasswordVerification(ref admin,ref dir, ref checkPass, ref count);//Verify admin with password
                        adminMenuLoop = false;//reset admin loop 
                        if (adminMenuLoop == true || checkPass == true)
                        {
                            Console.WriteLine("Press Enter.....");
                            Console.ReadLine();
                            Console.Clear();
                        }                        
                        else
                        {                            
                            do
                            {
                                CreateMemoryBank(ref player,ref admin,ref dir,ref file,input,keyboard,ref adminMenuLoop);
                            } while (adminMenuLoop == false);                           
                        }
                        break;
                    //Child mode option
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        ReadMemoryBank(ref file, input, keyboard);
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        CreateRandomSets(ref player, ref file, input, keyboard);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        
                        DeleteMemoryBankQuestion(ref file, input, keyboard);
                        break;
                    case ConsoleKey.Escape://Ends program
                        loop = true;
                        break;
                    default:
                        Console.WriteLine(StandardMessages.DisplayInvalidOption());//Displays invalid option to user
                        break;
                }
                Console.Clear();
            } while (loop == false);
            #endregion
        }

        public static void CreateMemoryBank(ref Player player,ref Administrator admin,ref string dir, ref string file, string input,ConsoleKeyInfo keyboard, ref bool adminMenuLoop)
        {
            bool problemLoop = false; //Set sentinel for menu loop
            int count = 0; //Set count to control number of questions
            #region Write to Memory Bank
            //Write problems to csv document
            do
            {
                input = "Memory Bank";
                Console.WriteLine(StandardMessages.DisplayDataBankEntryMenu(ref input));
                keyboard = Console.ReadKey();

                switch (keyboard.Key)
                {

                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        // VerifyMemoryBankSize.GetMemoryBankCurrentSize(ref dir, ref file,ref count, input, keyboard, ref adminMenuLoop);

                        if (count >= 10)
                        {
                            MessageBox.Show("Memory Bank Full");
                        }
                        else
                        {
                            using (StreamWriter output = File.AppendText(file))
                            {
                                try
                                {
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
                                    count++;
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex);
                                    Console.WriteLine("If there is an issue with copying data to the memory bank," +
                                        "\ndelete the memory bank file by chossing (4. Delete Memory Bank) from the menu.");
                                }
                                Console.Clear();//Clear screen
                            }
                           
                            #endregion

                        }
                        break;
                    //TODO Reset memory bank  
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        break;
                    //TODO change admin password
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Password.ChangeAdminPassword(ref admin, ref dir, input);
                        break;

                    case ConsoleKey.Escape:
                        player.Counter = count;
                        problemLoop = true;
                        adminMenuLoop = true;
                        if (count > 0)
                        {
                            //Start WriteToDocumentLoadingBarForm
                            Application.EnableVisualStyles();
                            Application.Run(new WriteToDocumentLoadingBarForm(ref player));
                        }
                        else
                        {
                            //
                        }
                        break;
                    default:
                        Console.WriteLine(StandardMessages.DisplayInvalidOption());
                        break;
                }
                Console.Clear();//Clear screen
            } while (problemLoop == false);
            Console.WriteLine("Successfully wrote to document.\n\nPress Enter to continue.");
            Console.ReadLine();
            
            #endregion
        }

        public static void ReadMemoryBank(ref string file, string input, ConsoleKeyInfo keyboard)
        {
            
            #region Variables,Classes, and Objects
            //Declare Variables,Classes, and Objects               
            string dataSetName = "";              
            int setNum = 0;
            int amount = 0;
            bool problemLoop = false;
            #endregion

            Data_Bank.ReadFromDocument.StartDataBankTest(ref file, input, keyboard, problemLoop, ref setNum, ref dataSetName);
            
        }
        public static void CreateRandomSets(ref Player player,ref string file, string input, ConsoleKeyInfo keyboard)
        {
            Console.Clear();
            #region Variable, Sentinels, and Objects
            string fnum1 = "";
            string fnum2 = "";
            int number1 = 0;
            int number2 = 0;
            bool numberMenu = false;
            Random randNum = new Random();
            string [] arithArray = new string[10];
            //string[] subArray = new string[10];
            //string[] mulArray = new string[10];
            //string[] divArray = new string[10];

            #endregion
            #region Create Random Flash Cards
            do
            {
                Console.WriteLine(StandardMessages.ArithmeticMenu());
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        for (int i = 0; i < arithArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 100);
                            number2 = randNum.Next(0, 100);
                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();
                            arithArray[i] = fnum1 + "+" + fnum2 + "=";
                        }
                        BasicDataBankTest.TakeDataBankTest(ref player, ref arithArray);

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        for (int i = 0; i < arithArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 100);
                            number2 = randNum.Next(0, 100);

                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();

                            arithArray[i] = fnum1 + " - " + fnum2 + " = ";

                        }
                        BasicDataBankTest.TakeDataBankTest(ref player, ref arithArray);

                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        for (int i = 0; i < arithArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 100);
                            number2 = randNum.Next(0, 100);

                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();

                            arithArray[i] = fnum1 + " X " + fnum2 + " = ";

                        }
                        BasicDataBankTest.TakeDataBankTest(ref player, ref arithArray);

                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        for (int i = 0; i < arithArray.Length; i++)
                        {
                            number1 = randNum.Next(0, 100);
                            number2 = randNum.Next(0, 100);

                            fnum1 = number1.ToString();
                            fnum2 = number2.ToString();

                            arithArray[i] = fnum1 + " / " + fnum2 + " = ";

                        }
                        BasicDataBankTest.TakeDataBankTest(ref player, ref arithArray);
                        break;

                    case ConsoleKey.Escape:

                        numberMenu = true;
                        break;
                    default:
                        //Display invalid option to user
                        Console.WriteLine(StandardMessages.DisplayInvalidOption());
                        break;
                }
                Console.Clear();

            } while (numberMenu == false);
            Console.Clear();
        }
        #endregion
    
         public static void DeleteMemoryBankQuestion(ref string file, string input, ConsoleKeyInfo keyboard)
        {
            try
            {
                System.IO.File.Delete(file);//Deletes Memory Bank File  
                Console.WriteLine(@"File Successfully Deleted from: \Dataman_OrengoAnthony\Dataman\bin\Debug\MemoryBankDocuments_Dataman ");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e);
            }
                     
        }
    }
}
