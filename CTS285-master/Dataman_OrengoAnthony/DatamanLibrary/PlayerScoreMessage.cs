using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using DatamanLibrary;

namespace DatamanLibrary
{
    public class PlayerScoreMessage
    {
       public static void DisplayPlayersScore(ref Player player)
        {
            //Display Player Score messages to the user
            if (player.Score <= 5)
            {
                Console.WriteLine("Good Job, but you need some work. \nKeep playing to get better!");
            }
            Console.WriteLine($"Players Score: {player.Score}");
            if (player.Score >= 5 && player.Score < 8)
            {
                Console.WriteLine("Good Job, but you need some work. \nKeep playing to get better!");
            }
            if (player.Score >= 8 && player.Score <= 9)
            {
                Console.WriteLine("Great Job, Keep up the good work!");
            }
            if (player.Score >= 10)
            {
                Console.WriteLine("Great Job, Flawless Score!");
            }
            Console.WriteLine("\nPress Enter...");
            Console.ReadLine();
            
        }
    }
}
