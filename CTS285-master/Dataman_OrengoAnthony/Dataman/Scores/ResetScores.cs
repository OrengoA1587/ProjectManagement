using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanLibrary;
namespace Dataman.Scores
{
    public class ResetScores
    {
        public static void ResetDatamanScores(ref int countProblems, ref int answerCheckerScore, ref int electroFlashScore, ref Player player, ref Player player2, ConsoleKeyInfo keyboard)
        {
            Console.WriteLine(StandardMessages.DisplayResetScoresOption());
            keyboard = Console.ReadKey();

            if (keyboard.Key == ConsoleKey.Y)
            {
                //Set scores to 0
                countProblems = 0;
                answerCheckerScore = 0;
                electroFlashScore = 0;
                player.Score = 0;
                player2.Score = 0;

               
               //Upload reset scores to document
               UploadDataManScores.WriteScoresFromDocument(ref countProblems, ref answerCheckerScore, ref electroFlashScore, ref player, ref player2);//Upload scores from document
               
            }
            else if (keyboard.Key == ConsoleKey.N)
            {
               
            }          
            Console.Clear();
        }
    }
}
