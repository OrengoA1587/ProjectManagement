/* M1HW
 * Anthony Orengo
 * Program Description: The calculator program allows the user to
 * choose a method of calculating two numbers. The user will have the option to
 * add, subtract, divide, and multiply a set of two numbers. The user will input 
 * two numbers and the program will calculate and display the results to the user.
 * 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize and declare variables
            decimal num1 = 0.0m;
            decimal num2 = 0.0m;
            decimal total = 0.0m;            
            string input;
            //Declare and initialize sentinel
            bool menuLoop = false;           
            
            do
            {
                Console.Clear();
                //Display welcome message
                Console.WriteLine(CalculatorLibrary.StandardMessages.WelcomeMessage());
                //Display calculator menu
                Console.WriteLine(CalculatorLibrary.StandardMessages.MainMenu());
                //Get input from user
                Console.Write(CalculatorLibrary.StandardMessages.MakeASelection());
                input = Console.ReadLine();
                //Flow and direct calculator menu
                switch (input)
                {
                    case "1"://Calculates users input by using addition
                        CalculateUserInput.AddUserInput(num1, num2, total, menuLoop, input);                       
                        break;
                    case "2"://Calculates users input by using subtraction
                        CalculateUserInput.SubtractUserInput(num1, num2, total, menuLoop, input);
                        break;
                    case "3"://Calculates users input by using division
                        CalculateUserInput.DivideUserInput(num1, num2, total, menuLoop, input);
                        break;
                    case "4"://Calculates users input by using multiplication
                        CalculateUserInput.MultiplyUserInput(num1, num2,total, menuLoop, input);
                        break;
                    case "5"://Ends loop and program
                        Console.Clear();
                        Console.WriteLine(CalculatorLibrary.StandardMessages.GoodbyeMessage());
                        Console.WriteLine("\nPress Enter....");
                        Console.ReadLine();                        
                        menuLoop = true;
                        break;
                    default:
                        //Displays invalid option
                        Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                        break;                        
                }
            } while (menuLoop == false);
        }
    }
}
