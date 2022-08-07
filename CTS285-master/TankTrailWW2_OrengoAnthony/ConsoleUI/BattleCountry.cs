using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
namespace ConsoleUI
{
    public class BattleCountry
    {
        public static void GetPlayerBattleCountry(ref List<Commander> players, string directory, GameDice dice, ref List<Country> countries)
        {            
            Console.Clear();
            string diceImageOne = "";
            bool loop = false;
            int diceWinner = 0;
            //Battle Country Instructions----------------------------------------------------------------------
            DisplayGameDocuments.DisplayBattleCountryInstructions(directory);
            Console.ReadLine();
            Console.Clear();
            DisplayGameDocuments.DisplayBattleRollPage(directory);
            
                
            //RollDice.DetermineWhoRollsFirst(ref dice);
            //Roll to Choose Battle Country---------------------------------------------------------------------

            
            
            do
            {
                if(players.Count == 2)
                {
                    TwoPlayerBattleCountry(ref players, directory, dice, ref diceImageOne, ref countries, ref loop, ref diceWinner);
                }
                //if(players.Count == 4)
                //{
                //    FourPlayerBattleCountry(ref players, directory, dice, ref diceImageOne, ref countries, ref loop, ref diceWinner);
                //}
                //if (players.Count == 6)
                //{
                //    SixPlayerBattleCountry(ref players, directory, dice, ref diceImageOne, ref countries, ref loop, ref diceWinner);
                //}
            } while (loop == false);
            
            //=======================================================================================
            
        }
        //Two player game -----------------------------------------------------------------------------------------
        public static void TwoPlayerBattleCountry(ref List<Commander> players, string directory, GameDice dice,
            ref string diceImageOne , ref List<Country> countries, ref bool loop, ref int winner)
        {
            do
            {
                //Determine who won the roll-----------------------------------------------------------------------------
                int num = 0;
                //string win = "Win"
                int playerNumIdentifier = 1;
                for (int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine($"Player{playerNumIdentifier}: Press enter to roll your dice.");
                    Console.ReadLine();
                    RollDice.RollOneGameDice(ref dice);
                    players[i].DiceNumber = dice.DiceOne;
                    Console.WriteLine("Player" + playerNumIdentifier + "'s roll:");
                    DisplayDiceImage.ShowDiceImageOne(ref dice, ref diceImageOne);
                    Console.WriteLine();
                    playerNumIdentifier++;
                }
                
                if (players[0].DiceNumber > players[1].DiceNumber)
                {
                    Console.WriteLine("Player one wins first pick! ");
                    Console.ReadLine();
                    winner = 0;
                    PickBattleCountry(ref players, directory, dice, ref diceImageOne, ref countries, ref loop, ref winner);
                    winner = 1;
                    PickBattleCountry(ref players, directory, dice, ref diceImageOne, ref countries, ref loop, ref winner);
                    loop = true;
                    
                }
                else if (players[1].DiceNumber > players[0].DiceNumber)
                {
                    Console.WriteLine("Player two wins first pick!");
                    Console.ReadLine();
                    winner = 1;
                    PickBattleCountry(ref players, directory, dice, ref diceImageOne, ref countries, ref loop, ref winner);
                    winner = 0;
                    PickBattleCountry(ref players, directory, dice, ref diceImageOne, ref countries, ref loop, ref winner);
                    loop = true;
                }
                else if (players[1].DiceNumber == players[0].DiceNumber || players[0].DiceNumber == players[1].DiceNumber)
                {

                }
                else
                {
                    Console.WriteLine("Invalid! Error!");
                }
                Console.ReadLine();

            } while (loop == false);

            //PickBattleCountry(ref players, directory, dice, ref diceImageOne, ref countries, ref loop, ref winner);

            Console.WriteLine($"{players[0].CommanderCountry}\n{players[1].CommanderCountry}");
            Console.ReadLine();
        }
        //TODO four player/ six player game
        //---------------------------------------------------------
        //public static void FourPlayerBattleCountry(ref List<Commander> players, string directory, GameDice dice,
        //    ref string diceImageOne, ref List<Country> countries, ref bool loop, ref int winner)
        //{

        //}
        //public static void SixPlayerBattleCountry(ref List<Commander> players, string directory, GameDice dice,
        //    ref string diceImageOne, ref List<Country> countries, ref bool loop, ref int winner)
        //{

        //}
        //==============================================================================

        public static void PickBattleCountry(ref List<Commander> players, string directory, GameDice dice,
            ref string diceImageOne, ref List<Country> countries, ref bool loop, ref int winner)
        {
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            DisplayGameDocuments.DisplayCountriesList(directory);
            Console.ReadLine();

            //Console.WriteLine(StandardMessages.DisplayAvailableCountries(ref countries));
            do
            {
                
                for(int i = 0; i < countries.Count; i++)
                {
                    
                    Console.WriteLine($"{i + 1}. {countries[i].CountryName}");
                   
                }
                if(winner == 0)
                {
                    Console.WriteLine("\nMake a selection player one -->");
                }
                else if(winner == 1)
                {
                    Console.WriteLine("\nMake a selection player two -->");
                }
                
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        players[winner].CommanderCountry = countries[0].CountryName;
                        countries.RemoveAt(0);
                        loop = true;

                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        players[winner].CommanderCountry = countries[1].CountryName;
                        countries.RemoveAt(1);
                        loop = true;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        players[winner].CommanderCountry = countries[2].CountryName;
                        countries.RemoveAt(2);
                        loop = true;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        players[winner].CommanderCountry = countries[3].CountryName;
                        countries.RemoveAt(3);
                        loop = true;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        players[winner].CommanderCountry = countries[4].CountryName;
                        countries.RemoveAt(4);
                        loop = true;
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        players[winner].CommanderCountry = countries[5].CountryName;
                        countries.RemoveAt(5);
                        loop = true;
                        break;
                    case ConsoleKey.Escape:
                    

                        break;
                    default:

                        break;


                }
               
            } while (loop == false);
            
            //TODO Create Battle Country Selection menu 
            //TODO remove country from selection menu when a player chooses it
            //TODO Add battle country to players stats
            //

        }
    }
}
