using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;
namespace Dataman.Wipeout
{
    public class WipeOutGame
    {
        public static void StartWipeOutGame()
        {
            Console.Clear();
            #region Variable, Objects, Classes
            DateTime date1 = new DateTime();// Create date now class
            Random randint = new Random();//Create Random class
            bool timeLoop = false;
            bool playerOneLoop = false;
            bool playerTwoLoop = false;
            string fnum1 = "";
            string fnum2 = "";
            string input = "";
            int num1 = 0;
            int num2 = 0;
            int userAnswer = 0;
            int correctAnswer = 0;
            int trackTime = 0;


            var date = DateTime.Now;
            var minutes = new DateTime(date.Minute);
            #endregion

            Console.WriteLine(date.Minute);
            trackTime = date.Minute + 1;
            Console.WriteLine(trackTime);
            Console.WriteLine("This part of the program is in test mode. Press Enter to continue.");
            Console.ReadLine();           

            do
            {
                date = DateTime.Now; //Tracks time to compare with the trackTime variable
                minutes = new DateTime(date.Minute);
                //Reset loop sentinels
                playerOneLoop = false;
                playerTwoLoop = false;

                //Verify current time
                Wipeout.TimeTrack.PlayerOneLost(ref playerOneLoop, ref playerTwoLoop, ref timeLoop, ref date, ref minutes, ref trackTime);
                if (timeLoop == true)
                {
                    //Blank in statement to prevent loop from starting 
                }
                else
                {
                    do
                    {
                        //Verify current time
                        Wipeout.TimeTrack.PlayerOneLost(ref playerOneLoop, ref playerTwoLoop, ref timeLoop, ref date, ref minutes, ref trackTime);
                        Console.WriteLine("Player One Enter the correct answer.");
                        num1 = randint.Next(1, 25); //Get first random number between 1-25
                        num2 = randint.Next(1, 25);//Get second random number between 1-25
                        correctAnswer = num1 + num2;//Calculate the coorect answer by adding num1 and num2

                        Console.WriteLine(num1 + "+" + num2 + "=");//Display question to user
                        input = Console.ReadLine();//Get input from player one
                        if (int.TryParse(input, out userAnswer))
                        {
                            if (userAnswer == correctAnswer)
                            {
                                //Verify current time
                                Wipeout.TimeTrack.PlayerOneLost(ref playerOneLoop, ref playerTwoLoop, ref timeLoop, ref date, ref minutes, ref trackTime);
                                Console.WriteLine("Correct!");
                                playerOneLoop = true;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect Answer! Try again!");
                                //Verify current time
                                Wipeout.TimeTrack.PlayerOneLost(ref playerOneLoop, ref playerTwoLoop, ref timeLoop, ref date, ref minutes, ref trackTime);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Answer! Try again!");
                            //Verify current time
                            Wipeout.TimeTrack.PlayerOneLost(ref playerOneLoop, ref playerTwoLoop, ref timeLoop, ref date, ref minutes, ref trackTime);
                        }

                    } while (playerOneLoop == false);
                }
                if (timeLoop == true)
                {
                    //Blank in statement to prevent loop from starting 
                }
                {
                    do
                    {
                        //Verify current time
                        Wipeout.TimeTrack.PlayerTwoLost(ref playerOneLoop, ref playerTwoLoop, ref timeLoop, ref date, ref minutes, ref trackTime);
                        Console.WriteLine("Player Two Enter the correct answer.");
                        num1 = randint.Next(1, 25); //Get first random number between 1-25
                        num2 = randint.Next(1, 25);//Get second random number between 1-25
                        correctAnswer = num1 + num2;//Calculate the coorect answer by adding num1 and num2

                        Console.WriteLine(num1 + "+" + num2 + "=");//Display question to user
                        input = Console.ReadLine();//Get input from player one
                        if (int.TryParse(input, out userAnswer))
                        {
                            if (userAnswer == correctAnswer)
                            {
                                //Verify current time
                                Wipeout.TimeTrack.PlayerTwoLost(ref playerOneLoop, ref playerTwoLoop, ref timeLoop, ref date, ref minutes, ref trackTime);
                                Console.WriteLine("Correct!");
                                playerTwoLoop = true;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect Answer! Try again!");
                                //Verify current time
                                Wipeout.TimeTrack.PlayerTwoLost(ref playerOneLoop, ref playerTwoLoop, ref timeLoop, ref date, ref minutes, ref trackTime);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Answer! Try again!");
                            //Verify current time
                            Wipeout.TimeTrack.PlayerTwoLost(ref playerOneLoop, ref playerTwoLoop, ref timeLoop, ref date, ref minutes, ref trackTime);
                        }

                    } while (playerTwoLoop == false);

                }
            } while (timeLoop == false);
        }
    }
}
