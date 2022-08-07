using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanLibrary;
using System.Windows.Forms;
using WinFormUI;
namespace Dataman
{
    
    class Program
    {
       
        static void Main(string[] args)
        {

            #region Variables and objects          
            TimerWatch countDown = new TimerWatch();
            Administrator admin = new Administrator();//Create admin object
            Player player = new Player("", 0, 0);//Create player object 
            Player player2 = new Player();//Create player2 object
            bool menuLoop = false;//Declare and initialize menu sentinel
            int countProblems = 0; //Track number of problems completed             
            int answerCheckerScore = 0, electroFlashScore = 0, numberGuesserScore = 0, dataBankScore = 0; //Declare and initialize game scores            
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo();//Create console keyboard class for user input
            #endregion
            UploadDataManScores.GetScoresFromDocument(ref countProblems, ref answerCheckerScore, ref electroFlashScore, ref player, ref player2);//Upload scores from document

            //Display WinForm "StartupForm", opens in windows forms .
            Application.EnableVisualStyles();
            Application.Run(new StartupForm());
            //------------------------------------------------------
            #region Main Menu Dataman
            do
            {
                Console.Clear();//Clears console screen

                Console.WriteLine(StandardMessages.DataMainMenu()); //Display main menu to the user

                keyboard = Console.ReadKey(); //Get keyboard input from user

                switch (keyboard.Key)//Control flow of the main menu
                {
                    //Answer Checker Option
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        AnswerChecker.CheckUsersAnswer(ref player, ref answerCheckerScore,ref countProblems);                          
                        break;
                    //Electro Flash option
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        ElectroFlashMain.ElectroFlashMenu(ref player, ref electroFlashScore);
                        break;
                    //Number Guesser option
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        NumberGuesser.NumberGuesser.GuessDatamansNumber(ref player, ref numberGuesserScore);
                        break;
                        //Force Out Game
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        ForceOut.ForceOutGame.PlayForceOut(ref player, ref player2);
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                       Wipeout.WipeOutGame.StartWipeOutGame();
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        //TODO 
                        Console.WriteLine("Not available yet.\n\nPress Enter....");
                        Console.ReadLine();
                        break;
                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        //Advanced memory bank
                        //Data_Bank.DataBankDocument.DataBankMenu();
                        //Basic memory bank
                        Dataman.MemoryBank.BasicMemoryBank.CreateBasicMemoryBank(ref player,ref admin, keyboard);
                        break;
                    //Display total scores for all games
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        Console.Clear();
                        UploadDataManScores.WriteScoresFromDocument(ref countProblems, ref answerCheckerScore, ref electroFlashScore, ref player, ref player2);//Upload scores from document
                        //Display current scores to user
                        Console.WriteLine(StandardMessages.TotalScores(ref countProblems, ref answerCheckerScore, ref electroFlashScore, ref player, ref player2));
                        Scores.ResetScores.ResetDatamanScores(ref countProblems, ref answerCheckerScore, ref electroFlashScore, ref player, ref player2, keyboard);//Reset Dataman Scores
                         
                        Console.Clear();//Clear current screen
                        break;
                    //Ends program
                    case ConsoleKey.Escape:                    
                        menuLoop = true;
                        break;
                    default:
                        //Display invalid option to user
                        Console.WriteLine(StandardMessages.DisplayInvalidOption());
                        break;
                }
            } while (menuLoop == false);
            #endregion
        }
    }
}
