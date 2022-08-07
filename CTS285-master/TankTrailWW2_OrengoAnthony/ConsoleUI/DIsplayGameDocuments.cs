using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleUI
{
    public class DisplayGameDocuments
    {
        public static void DisplayMainMenu(string directory)
        {
            //Displays main menu from text document
            string file;
            file = directory + (@"\GameDocuments\MainMenu.txt");
            try
            {
                using (StreamReader read = File.OpenText(file))
                {
                    file = read.ReadToEnd();
                    Console.WriteLine(file);

                }
            }
            //Catches exception if file is invalid
            catch (FileLoadException e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Make a Selection from the Menu...");
            //Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void DisplayPlayerAndTankeSelectionMenu(string directory)
        {
            //Displays start game menu to user
            string file;
            file = directory + (@"\GameDocuments\StartGameMenu.txt");
            try
            {
                using (StreamReader read = File.OpenText(file))
                {
                    file = read.ReadToEnd();
                    Console.WriteLine(file);

                }
            }
            //Catches exception if file is invalid
            catch (FileLoadException e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Make a Selection from the Menu...");
            //Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Displays select player menu to user
        public static void SelectTotalPlayers(string directory)
        {

            string file;
            file = directory + (@"\GameDocuments\SelectNumberOfPlayers.txt");
            try
            {
                using (StreamReader read = File.OpenText(file))
                {
                    file = read.ReadToEnd();
                    Console.WriteLine(file);

                }
            }
            //Catches exception if file is invalid
            catch (FileLoadException e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Make a Selection from the Menu...");
            //Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

        }
        public static void DisplayBattleCountryInstructions(string directory)
        {

            string file;
            file = directory + (@"\GameDocuments\BattleCountryInstructions.txt");
            try
            {
                using (StreamReader read = File.OpenText(file))
                {
                    file = read.ReadToEnd();
                    Console.WriteLine(file);

                }
            }
            catch (FileLoadException e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Press Enter to Continue...");
            //Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void DisplayBattleRollPage(string directory)
        {

            string file;
            file = directory + (@"\GameDocuments\BattleCountryRollPage.txt");
            try
            {
                using (StreamReader read = File.OpenText(file))
                {
                    file = read.ReadToEnd();
                    Console.WriteLine(file);

                }
            }
            catch (FileLoadException e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
            // Console.ForegroundColor = ConsoleColor.Green;
            
        }
        public static void DisplayCountriesList(string directory)
        {

            string file;
            file = directory + (@"\GameDocuments\BattleCountriesList.txt");
            try
            {
                using (StreamReader read = File.OpenText(file))
                {
                    file = read.ReadToEnd();
                    Console.WriteLine(file);

                }
            }
            catch (FileLoadException e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
            // Console.ForegroundColor = ConsoleColor.Green;

        }
        public static void DisplayCommanderRankInstructions(string directory)
        {

            string file;
            file = directory + (@"\GameDocuments\CommanderRankeLevelInstructions.txt");
            try
            {
                using (StreamReader read = File.OpenText(file))
                {
                    file = read.ReadToEnd();
                    Console.WriteLine(file);

                }
            }
            catch (FileLoadException e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
            // Console.ForegroundColor = ConsoleColor.Green;

        }
    }
}
