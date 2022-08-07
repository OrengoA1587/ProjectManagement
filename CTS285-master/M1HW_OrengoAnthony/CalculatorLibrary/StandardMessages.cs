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
                "Welcome to the Calculator Program\n" +
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
        //Returns display "Make a Selection" message to the user
        public static string MakeASelection()
        {
            return "\nMake a selection: ";
        }
        //Returns a display of add title
        public static string DisplayAddTitle()
        {
            return "\n*********************\n" +
                    "       Add\n*********************";
        }
        //Returns a display of subtract title
        public static string DisplaySubtractTitle()
        {
            return "\n*********************\n" +
                    "       Subtract\n*********************";
        }
        //Returns a display of divide title
        public static string DisplayDivideTitle()
        {
            return "\n*********************\n" +
                    "       Divide\n*********************";
        }
        //Returns a display of multiply title
        public static string DisplayMultiplyTitle()
        {
            return "\n*********************\n" +
                    "       Multiply\n*********************";
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
            return "\nEnter a number: ";
        }
        //Returns display "press enter" message to the user
        public static string DisplayPressEnter()
        {
            return "\nPress Enter....";
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
