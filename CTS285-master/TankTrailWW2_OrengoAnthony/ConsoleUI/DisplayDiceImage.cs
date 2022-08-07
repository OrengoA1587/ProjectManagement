using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;
namespace ConsoleUI
{
    public class DisplayDiceImage
    {
        public static void ShowDiceImageOne(ref GameDice dice, ref string diceImageOne)
        {
            //DICE Images for die one---------------------------------------------------------------------------//
            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;
            
            if (dice.DiceOne == 1)
            {
                diceImageOne = " _____\n" +
                              "|     |\n" +
                              "|  O  |\n" +
                              "|_____|";

                Console.WriteLine(diceImageOne);
            }
            else if (dice.DiceOne == 2)
            {
                diceImageOne = " _____\n" +
                              "|    O|\n" +
                              "|     |\n" +
                              "|O____|";
                Console.WriteLine(diceImageOne);
            }


            if (dice.DiceOne == 3)
            {
                diceImageOne = " _____\n" +
                              "|    O|\n" +
                              "|  O  |\n" +
                              "|O____|";

                Console.WriteLine(diceImageOne);
            }
            if (dice.DiceOne == 4)
            {
                diceImageOne = " _____\n" +
                              "|O   O|\n" +
                              "|     |\n" +
                              "|O___O|";

                Console.WriteLine(diceImageOne);
            }
            if (dice.DiceOne == 5)
            {
                diceImageOne = " _____\n" +
                              "|O   O|\n" +
                              "|  O  |\n" +
                              "|O___O|";

                Console.WriteLine(diceImageOne);
            }
            if (dice.DiceOne == 6)
            {
                diceImageOne = " _____\n" +
                              "|O   O|\n" +
                              "|O   O|\n" +
                              "|O___O|";

                Console.WriteLine(diceImageOne);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void ShowDiceImageTwo(GameDice dice, ref string diceImageTwo)
        {
            //DICE Images for die two-------------------------------------------------------------------------//
            if (dice.DiceTwo == 1)
            {
                diceImageTwo = " _____\n" +
                              "|     |\n" +
                              "|  O  |\n" +
                              "|_____|";

                Console.WriteLine(diceImageTwo);
            }
            else if (dice.DiceTwo == 2)
            {
                diceImageTwo = " _____\n" +
                              "|    O|\n" +
                              "|     |\n" +
                              "|O____|";
                Console.WriteLine(diceImageTwo);
            }


            if (dice.DiceTwo == 3)
            {
                diceImageTwo = " _____\n" +
                              "|    O|\n" +
                              "|  O  |\n" +
                              "|O____|";

                Console.WriteLine(diceImageTwo);
            }
            if (dice.DiceTwo == 4)
            {
                diceImageTwo = " _____\n" +
                              "|O   O|\n" +
                              "|     |\n" +
                              "|O___O|";

                Console.WriteLine(diceImageTwo);
            }
            if (dice.DiceTwo == 5)
            {
                diceImageTwo = " _____\n" +
                              "|O   O|\n" +
                              "|  O  |\n" +
                              "|O___O|";

                Console.WriteLine(diceImageTwo);
            }
            if (dice.DiceTwo == 6)
            {
                diceImageTwo = " _____\n" +
                              "|O   O|\n" +
                              "|O   O|\n" +
                              "|O___O|";

                Console.WriteLine(diceImageTwo);
                // }
            }
        }
    }
}
