using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanLibrary;

namespace Dataman.ForceOut
{
    public class ForceOutGame
    {
        public static void PlayForceOut(ref Player player1, ref Player player2)
        {
            Console.Clear();//Clear current screen
            
            Random randInt = new Random();//Create random class
            int forceOutNumber = 0;//Declare and initialize start number
            int numSelection = 0;
            bool checkInput1 = false;
            bool checkInput2 = false;
            bool endForceOut = false;
            string input;


            forceOutNumber = randInt.Next(24, 100);//Random integer between 24-100

            do
            {
                if (forceOutNumber <= 0)
                {
                    checkInput1 = true;
                    endForceOut = true;
                    player1.Score += 1;
                    Console.WriteLine("Player2 Lost\n\nPress Enter....");
                    Console.ReadLine();
                }
                else
                {
                    do
                    {
                         
                                            //Get input from player 1
                        Console.WriteLine("ForceOut Out Number: " + forceOutNumber +
                       "\nPlayer1 select a number from 1-9");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out numSelection))
                        {
                            if(numSelection > 9)
                            {
                                Console.WriteLine("Invalid Number! Number must be between 1-9");
                            }
                            else
                            {
                                forceOutNumber -= numSelection;//Subtract player1's input
                                checkInput1 = true;
                            }
                          
                        }
                        else
                        {
                            //Display invalid option to user
                            Console.WriteLine(StandardMessages.DisplayInvalidOption());
                        }

                    } while (checkInput1 == false);

                }
                //Get input from player 2
                if (forceOutNumber <= 0)
                {
                    if(endForceOut == true)
                    {

                    }
                    else
                    {
                        checkInput2 = true;
                        endForceOut = true;
                        player2.Score += 1;
                        Console.WriteLine("Player1 Lost\n\nPress Enter....");
                        Console.ReadLine();
                    }
                    
                }
                else
                {
                    do
                    {

                        Console.WriteLine("ForceOut Out Number: " + forceOutNumber +
                        "\nPlayer2 select a number from 1-9");
                        input = Console.ReadLine();
                        if (int.TryParse(input, out numSelection))
                        {
                            if (numSelection > 9)
                            {
                                Console.WriteLine("Invalid Number! Number must be between 1-9");
                            }
                            else
                            {
                                forceOutNumber -= numSelection;//Subtract player2's input
                                checkInput2 = true;
                            }

                        }
                        else
                        {
                            //Display invalid option to user
                            Console.WriteLine(StandardMessages.DisplayInvalidOption());

                        }
                    } while (checkInput2 == false);
                }
            } while (endForceOut == false);
        }
    }
}
