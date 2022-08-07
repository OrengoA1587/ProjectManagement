using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatamanLibrary
{
    public static class StandardMessages
    {
        #region Standard Game Messages

        //Display main menu 
        public static string DataMainMenu()
        {
            return "*************************\n" +
                   "*        DATAMAN        *\n" +
                   "*************************\n" +
                   "* 1. Answer Checker     *\n" +
                   "* 2. Electro Flash      *\n" +
                   "* 3. Number Guesser     *\n" +
                   "* 4. Force Out          *\n" +
                   "* 5. WipeOut            *\n" +
                   "* 6. Missing Number     *\n" +
                   "* 7. Memory Bank        *\n" +
                   "* 8. Scores             *\n" +
                   "* Esc.                  *\n" +
                   "*************************\n\n" +
                   "Make a Selection";
        }
        #region Game Titles
        public static string DataManTitle()
        {
            return "*************************\n" +
                   "*       DATAMAN         *\n" +
                   "*************************";
        }
        //Display Answer Checker title to user
        public static string AnswerCheckerTitle()
        {
            return "*************************\n" +
                   "*     Answer Checker    *\n" +
                   "*************************";
        }
        //Display number guesser title
        public static string NumberCheckerTitle()
        {
            return "*************************\n" +
                   "*     Number Guesser    *\n" +
                   "*************************";
        }
        //Display Electro Flash title to user
        public static string ElectroFlashTitle()
        {
            return "*************************\n" +
                   "*     Electro Flash     *\n" +
                   "*************************\n";
        }
        //Display data bank title to user
        public static string DisplayDataBankTitle(ref string input)
        {
            return "*************************\n" +
                   $"   Data Bank {input}  \n" +
                   "*************************\n";

        }
        #endregion End of Game Titles
        //Display electro flash menu
        public static string ArithmeticMenu()
        {
            return "*************************\n" +
                   "*     Arithmetic Menu   *\n" +
                   "*************************\n" +
                   "* +  Addition           *\n" +
                   "* -  Subtraction        *\n" +
                   "* *  Multiplication     *\n" +
                   "* /  Division           *\n" +
                   "*                       *\n" +
                   "* Esc. Exit             *\n" +
                   "*************************\n\n" +
                   "Choose a Math Symbol --> ";
        }
        //Display electro flash card option menu
        public static string ElectroFlashCardOption()
        {
            return "*************************\n" +
                   "*     Electro Flash     *\n" +
                   "*************************\n" +
                   "* 1. 1-9                *\n" +
                   "* 2. 1-49               *\n" +
                   "* 3. 1-99               *\n" +
                   "* 4. 1-499              *\n" +
                   "*                       *\n" +
                   "* Esc. Exit             *\n" +
                   "*************************\n\n" +
                   "Choose Flash Card Size --> ";
        }
         //Display data set to user
        public static string DisplayDataQuestions(ref int num, ref string dataSetName)
        {
            return "*************************\n" +
                   $"   Data Bank set {num} {dataSetName}  \n" +
                   $"      Questions\n" +
                   "*************************\n";
        }
        //Display data bank main menu to user
        public static string DisplayAdminDataBankMainMenu()
        {
            return "*************************\n" +
                   "*       Data Bank       *\n" +
                   "*************************\n" +
                   "1. Create Data Bank\n\n" +
                   
                   "Esc. Return to main menu\n" +
                   "\nSelect DataSet";
        }
        //Display child data bank main menu to user
        public static string DisplayChildDataBankMainMenu()
        {
            return "*************************\n" +
                   "*       Data Bank       *\n" +
                   "*************************\n" +
                   "1.  Start Data Bank\n\n" +
                  
                   "Esc. Return to main menu\n" +
                   "\nSelect DataSet";
        }
        public static string DisplayCreateDataSetMenu()
        {
            return "*************************\n" +
                   "*  Create/Add Data Bank *\n" +
                   "*************************\n" +
                   "1. DataSet1\n" +
                   "2. DataSet2\n" +
                   "3. DataSet3\n" +
                   "4. DataSet4\n" +
                   "5. DataSet5\n" +
                   "6. Create Data Set File\n\n" +
                   "Esc. Return to main menu\n" +
                   "\nSelect DataSet";
        }
        public static string DisplaySelectDataSetMenu()
        {
            return "*************************\n" +
                   "*   Select Data Bank     *\n" +
                   "*************************\n" +
                   "1. DataSet1\n" +
                   "2. DataSet2\n" +
                   "3. DataSet3\n" +
                   "4. DataSet4\n" +
                   "5. DataSet5\n" +
                   "6. Enter DataSet Name\n\n" +
                   "Esc. Return to main menu\n" +
                   "\nSelect DataSet";
        }
        //Display title to user
        public static string DisplayDocumentCreationTitle()
        {
            return "*************************\n" +
                   "*    Document Creation   *\n" +
                   "*************************";
        }
        //Display instructions to user
        public static string DisplayDocumentInstructions()
        {
            return "*************************\n" +
                   "*    Create Document    *\n" +
                   "*************************" +
                   "\n" +
                   "1. Name your document in relation to your project.\n" +
                   "2. Capitalize each word you use.\n" +
                   "3. Do not leave spaces between each word." +
                   " Use an underscore to separate words.\n" +
                   "\n* Although the above will not inhibit you from creating a document, it is strongly\n" +
                   "encouraged you use proper document naming techniques.\n" +
                   "\n\n" +
                   "* You will not be able to create a document if your file name includes the following:\n\n" +
                   "*****************************\n" +
                   ".txt\n" +
                   "< (less than)\n" +
                   "> (greater than)\n" +
                   ": (colon)\n" +
                  @""" (double quote)" +
                   "\n/ (forward slash)\n" +
                  @"\ (backslash)" +
                   "\n| (vertical bar or pipe)\n" +
                   "? (question mark)\n" +
                   "*(asterisk)\n" +
                   "*****************************\n" +
                   "Press Enter...";
        }
        public static string DisplayDataBankMainMenu()
        {
            return "*************************\n" +
                   $"   Data Bank \n" +
                   "*************************\n" +
                   "1. Admin Mode\n" +
                   "2. Child Mode\n" +
                   "3. Random Data Bank\n" +
                   "4. Delete Memory Bank\n\n" +
                   "Esc. Return to main menu";
        }
        public static string DisplayDataBankEntryMenu(ref string input)
        {
            return "*************************\n" +
                   $"   Data Bank {input}  \n" +
                   "*************************\n" +
                   "1. Enter Problem\n" +
                   "2. Reset Questions\n" +
                   "3. Change Admin Password\n\n" +                   
                   "Esc. Return to main menu";
        }
        public static string DisplayInstructionsForCustomDoc()
        {
           return "*************************\n" +
                  "*    Document Creation  *\n" +
                  "*************************\n\n" +
                  "***READ!***\n" +
                  "Custom documents will not be available until\n" +
                  "close out Visual Studio.\n\n" +
                  "Press Enter...";
        }
        
         
        public static string TotalScores(ref int countProblems,ref int answerCheckerScore, ref int electroFlashScore, ref Player player, ref Player player2)
        {
            return "*************************\n" +
                   "*    DATAMAN  Scores    *\n" +
                   "*************************\n" +
                   $"Answer Checker: {answerCheckerScore}\n" +
                   $"ElectroFlash: {electroFlashScore}\n" +
                   $"Force Out: Player1 Score: {player.Score} Player2 Score: {player2.Score}" +
                   $"\nTotal Problems: {countProblems}" +
                   $"\nTotal Right: {answerCheckerScore + electroFlashScore}";
                    
        }
        //Display reset scores
        public static string DisplayResetScoresOption()
        {
            return "\n'Reset Scores Y or N";
        }
        public static string DisplayInvalidOption()
        {
            return "Invalid option! Try again!\n\nPress enter....";
        }
        #endregion
    }
}
