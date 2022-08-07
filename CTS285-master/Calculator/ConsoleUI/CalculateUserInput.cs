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
        public static void AddUserInput(decimal numberOne, decimal numberTwo, decimal total, bool loop, string input)
        {
            bool loop2 = false;
            bool loop3 = false;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Add");

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
                    Console.Write(CalculatorLibrary.StandardMessages.GetUserNumber());
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
                        loop = true;
                    }
                    else
                    {
                        Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                    }

                } while (loop3 == false);
                

            } while (loop == false);
            //Clears current screen
            //Console.Clear();
        }

        public static void SubtractUserInput(decimal numberOne, decimal numberTwo, decimal total, bool loop, string input)
        {
            bool loop2 = false;
            bool loop3 = false;
            do
            {
                Console.WriteLine("Subtract");

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
                    Console.Write(CalculatorLibrary.StandardMessages.GetUserNumber());
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
                        loop = true;
                    }
                    else
                    {
                        Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                    }

                } while (loop3 == false);


            } while (loop == false);
            //Clears current screen
            //Console.Clear();
        }
        public static void DivideUserInput(decimal numberOne, decimal numberTwo, decimal total, bool loop, string input)
        {
            bool loop2 = false;
            bool loop3 = false;
            do
            {
                Console.WriteLine("Divide");

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
                    Console.Write(CalculatorLibrary.StandardMessages.GetUserNumber());
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
                        loop = true;
                    }
                    else
                    {
                        Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                    }

                } while (loop3 == false);


            } while (loop == false);
            //Clears current screen
            //Console.Clear();
        }
        public static void MultiplyUserInput(decimal numberOne, decimal numberTwo, decimal total, bool loop, string input)
        {
            bool loop2 = false;
            bool loop3 = false;
            do
            {
                Console.WriteLine("Multiply");

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
                    Console.Write(CalculatorLibrary.StandardMessages.GetUserNumber());
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
                        loop = true;
                    }
                    else
                    {
                        Console.WriteLine(CalculatorLibrary.StandardMessages.InvalidOption());
                    }

                } while (loop3 == false);


            } while (loop == false);
            //Clears current screen
            //Console.Clear();
        }
    }
}
