using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
namespace ConsoleUI
{
    public class GenerateGameList
    {
        public static void GenerateGameCharacters(ref List<Commander> players, ref int num, ref Commander player)
        {
            //Clear list if players decide to change number of players
            players.Clear();
            #region Generate Lists of Players
            for (int i = 0; i < num; i++)
            {
                players.Add(new Commander (player.CommanderName,player.CommanderRankLevel,player.CommanderDescription,player.CommanderCountry,player.DiceNumber));
            }
            #endregion
        }
        public static void GenerateGameCountries(ref List<Country> countries, ref Country battleCountry)
        {
            #region Generate Lists of Countries
            //Subscript 0 - 5
            countries.Add(new Country("UNITED STATES"));
            countries.Add(new Country("SOVIET UNION"));
            countries.Add(new Country("UNITED KINGDOM"));
            countries.Add(new Country("GERMANY"));
            countries.Add(new Country("ITALY"));
            countries.Add(new Country("JAPAN"));
            #endregion
        }

        public static void GenerateCommanderLevelList(ref List<string> usCORankLevel, 
            ref List<string>  sovietCORankLevel, ref List<string> ukCORankLevel, ref List<string> germCORankLevel,
            ref List<string> italyCORankLevel, ref List<string> japnCORankLevel)
        {
            #region Generate Lists of Ranks            
            //Add United States ranks to list --------------------------------------------//
            usCORankLevel.Add("LT.");
            usCORankLevel.Add("CAPT.");
            usCORankLevel.Add("MAJ.");
            usCORankLevel.Add("LTCOL");
            usCORankLevel.Add("COL");
            usCORankLevel.Add("GEN");
            //Add Soviet Union ranks to list ---------------------------------------------//
            sovietCORankLevel.Add("");
            sovietCORankLevel.Add("");
            sovietCORankLevel.Add("");
            sovietCORankLevel.Add("");
            sovietCORankLevel.Add("");
            sovietCORankLevel.Add("");
            //Add United Kingdom ranks to list -------------------------------------------//
            ukCORankLevel.Add("");
            ukCORankLevel.Add("");
            ukCORankLevel.Add("");
            ukCORankLevel.Add("");
            ukCORankLevel.Add("");
            ukCORankLevel.Add("");
            //Add Germany ranks to list -------------------------------------------------//
            germCORankLevel.Add("");
            germCORankLevel.Add("");
            germCORankLevel.Add("");
            germCORankLevel.Add("");
            germCORankLevel.Add("");
            germCORankLevel.Add("");
            //Add Italy ranks to list --------------------------------------------------//
            italyCORankLevel.Add("");
            italyCORankLevel.Add("");
            italyCORankLevel.Add("");
            italyCORankLevel.Add("");
            italyCORankLevel.Add("");
            italyCORankLevel.Add("");
            //Add Japan ranks to list --------------------------------------------------//
            japnCORankLevel.Add("");
            japnCORankLevel.Add("");
            japnCORankLevel.Add("");
            japnCORankLevel.Add("");
            japnCORankLevel.Add("");
            japnCORankLevel.Add("");
            #endregion List & Ranks             
        }

    }
}
