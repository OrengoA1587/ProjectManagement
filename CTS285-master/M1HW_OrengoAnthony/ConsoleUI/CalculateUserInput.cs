using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;
namespace ConsoleUI
{
    public class CalculateUserInput
    {
        //Method for adding users numbers
        public static void AddUserInput(decimal numberOne, decimal numberTwo, decimal total, bool mainLoop, string input)
        {
            //Declare and initialize sentinels
            bool loop2 = false;
            bool loop3 = false;
            do
            {
                //Reset loop sentinel
                loop2 = false;
                loop3 = false;
                Console.Clear();
                //Displays add title
                Console.WriteLine(CalculatorLibrary.StandardMessages.DisplayAddTitle()); 
                do
                {                    
                    //Get users first number
                    Console.Write(StandardMessages.GetUserNumber());
                    input = Console.ReadLine();
                    //Convert string to decimal
                    if (decimal.TryParse(input, out numberOne))
                    {
                        //Get users second number
                        Console.Write(StandardMessages.GetUserNumber());
                        input = Console.ReadLine();
                        if (decimal.TryParse(input, out numberTwo))
                        {
                            total = numberOne + numberTwo;
                            Console.WriteLine($"{numberOne} + {numberTwo} = {total}");
                            Console.WriteLine(CalculatorLibrary.StandardMessages.DisplayPressEnter());
                            Console.ReadLine();
                            Console.Clear();
                            loop2 = true;
                        }
                        else
                        {
                            Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                        }
                    }
                    //Display invalid option
                    else
                    {
                        Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                    }
                } while (loop2 == false);
                do
                {
                    //Allows user to return to the main menu or add another set of numbers.
                    Console.WriteLine(StandardMessages.RepeatReturnMenu());
                    Console.Write(CalculatorLibrary.StandardMessages.MakeASelection());
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        //Clears current screen
                        loop3 = true;
                        //Console.Clear();
                    }
                    else if (input == "2")
                    {
                        loop3 = true;
                        mainLoop = true;
                    }
                    else
                    {
                        Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                    }
                } while (loop3 == false);   

            } while (mainLoop == false);            
        }

        public static void SubtractUserInput(decimal numberOne, decimal numberTwo, decimal total, bool mainLoop, string input)
        {
            //Declare and initialize sentinels
            bool loop2 = false;
            bool loop3 = false;
            do
            {
                //Reset loop sentinel
                loop2 = false;
                loop3 = false;
                Console.Clear();
                //Displays subtract title
                Console.WriteLine(CalculatorLibrary.StandardMessages.DisplaySubtractTitle());
                do
                {
                    //Get users first number
                    Console.Write(StandardMessages.GetUserNumber());
                    input = Console.ReadLine();
                    //Convert string to decimal
                    if (decimal.TryParse(input, out numberOne))
                    {
                        //Get users second number
                        Console.Write(StandardMessages.GetUserNumber());
                        input = Console.ReadLine();
                        if (decimal.TryParse(input, out numberTwo))
                        {
                            total = numberOne - numberTwo;
                            Console.WriteLine($"{numberOne} - {numberTwo} = {total}");
                            Console.WriteLine(CalculatorLibrary.StandardMessages.DisplayPressEnter());
                            Console.ReadLine();
                            Console.Clear();
                            loop2 = true;
                        }
                        else
                        {
                            Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                        }
                    }
                    //Display invalid option
                    else
                    {
                        Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                    }
                } while (loop2 == false);
                do
                {
                    //Allows user to return to the main menu or subtract another set of numbers.
                    Console.WriteLine(StandardMessages.RepeatReturnMenu());
                    Console.Write(CalculatorLibrary.StandardMessages.MakeASelection());
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        //Clears current screen
                        loop3 = true;
                        //Console.Clear();
                    }
                    else if (input == "2")
                    {
                        loop3 = true;
                        mainLoop = true;
                    }
                    else
                    {
                        Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                    }
                } while (loop3 == false);

            } while (mainLoop == false);            
        }
        public static void DivideUserInput(decimal numberOne, decimal numberTwo, decimal total, bool mainLoop, string input)
        {
            //Declare and initialize sentinels
            bool loop2 = false;
            bool loop3 = false;
            do
            {
                //Reset loop sentinel
                loop2 = false;
                loop3 = false;
                Console.Clear();
                //Displays divide title
                Console.WriteLine(CalculatorLibrary.StandardMessages.DisplayDivideTitle());
                do
                {
                    //Get users first number
                    Console.Write(StandardMessages.GetUserNumber());
                    input = Console.ReadLine();
                    //Convert string to decimal
                    if (decimal.TryParse(input, out numberOne))
                    {
                        //Get users second number
                        Console.Write(StandardMessages.GetUserNumber());
                        input = Console.ReadLine();
                        if (decimal.TryParse(input, out numberTwo))
                        {
                            total = numberOne / numberTwo;
                            Console.WriteLine($"{numberOne} / {numberTwo} = {total}");
                            Console.WriteLine(CalculatorLibrary.StandardMessages.DisplayPressEnter());
                            Console.ReadLine();
                            Console.Clear();
                            loop2 = true;
                        }
                        else
                        {
                            Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                        }
                    }
                    //Display invalid option
                    else
                    {
                        Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                    }

                } while (loop2 == false);
                do
                {
                    //Allows user to return to the main menu or divide another set of numbers.
                    Console.WriteLine(StandardMessages.RepeatReturnMenu());
                    Console.Write(CalculatorLibrary.StandardMessages.MakeASelection());
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        //Clears current screen
                        loop3 = true;
                        //Console.Clear();
                    }
                    else if (input == "2")
                    {
                        loop3 = true;
                        mainLoop = true;
                    }
                    else
                    {
                        Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                    }
                } while (loop3 == false);               

            } while (mainLoop == false);           
        }
        public static void MultiplyUserInput(decimal numberOne, decimal numberTwo, decimal total, bool mainLoop, string input)
        {
            //Declare and initialize sentinels
            bool loop2 = false;
            bool loop3 = false;
            do
            {
                //Reset loop sentinel
                loop2 = false;
                loop3 = false;
                Console.Clear();
                //Displays multiply title
                Console.WriteLine(CalculatorLibrary.StandardMessages.DisplayMultiplyTitle());
                do
                {
                    //Get users first number
                    Console.Write(StandardMessages.GetUserNumber());
                    input = Console.ReadLine();
                    //Convert string to decimal
                    if (decimal.TryParse(input, out numberOne))
                    {
                        //Get users second number
                        Console.Write(StandardMessages.GetUserNumber());
                        input = Console.ReadLine();
                        if (decimal.TryParse(input, out numberTwo))
                        {
                            total = numberOne * numberTwo;
                            Console.WriteLine($"{numberOne} x {numberTwo} = {total}");
                            Console.WriteLine(CalculatorLibrary.StandardMessages.DisplayPressEnter());
                            Console.ReadLine();
                            Console.Clear();
                            loop2 = true;
                        }
                        else
                        {
                            Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                        }
                    }
                    //Display invalid option
                    else
                    {
                        Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                    }
                } while (loop2 == false);
                do
                {
                    //Allows user to return to the main menu or multiply another set of numbers.
                    Console.WriteLine(StandardMessages.RepeatReturnMenu());
                    Console.Write(CalculatorLibrary.StandardMessages.MakeASelection());
                    input = Console.ReadLine();
                    if (input == "1")
                    {
                        //Clears current screen
                        loop3 = true;
                        //Console.Clear();
                    }
                    else if (input == "2")
                    {
                        loop3 = true;
                        mainLoop = true;
                    }
                    else
                    {
                        Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                    }
                } while (loop3 == false);

            } while (mainLoop == false);           
        }
    }
}
