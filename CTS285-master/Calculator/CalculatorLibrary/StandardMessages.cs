using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class StandardMessages
    {
        //Returns welcome message for calculator program
        public static string WelcomeMessage()
        {
            return "**********************************\n" +
                "Welcome to the calculator program.\n" +
                "**********************************";
        }
        //Returns a display of the main menu
        public static string MainMenu()
        {
            return "1. Add\n" +
                "2. Subtract\n" +
                "3. Divide\n" +
                "4. Multiply\n" +
                "5. Exit";
        }
        //Returns a display of the repeat/return menu
        public static string RepeatReturnMenu()
        {
            return "1. Repeat\n" +
                "2. Main Menu";
               
        }
        //Returns display "enter number" message to the user
        public static string GetUserNumber()
        {
            return "Enter a number: ";
        }
        //Returns display "Invalid option" to the user
        public static string InvalidOption()
        {
            return "Invalid option! ";
        }
        //Returns display "goodbye" to the user
        public static string GoodbyeMessage()
        {
            return "Goodbye.";
        }
    }
}
