using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanLibrary;
using System.Windows.Forms;
using WinFormUI;
using System.IO;
namespace Dataman
{
    public class UploadDataManScores
    {
        public static void WriteScoresFromDocument(ref int countProblems, ref int answerCheckerScore, ref int electroFlashScore, ref Player player, ref Player player2)
        {
            //get directory
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string scoreFile = dir + @"DatamanScores.csv";
            int[] scoresArray = new int[4];
            scoresArray[0] = answerCheckerScore;
            scoresArray[1] = electroFlashScore;
            scoresArray[2] = player.Score;
            scoresArray[3] = player2.Score;

            try
            {
                using (StreamWriter output = File.CreateText(scoreFile))
                {
                    foreach (var element in scoresArray)
                    {
                        output.WriteLine(element);
                    }

                }

            }catch(Exception e)
            {
                Console.WriteLine(e + "\n\n Press Enter");//Display exception if document saves incorrectly
                Console.ReadLine();
            }          

        }
        public static void GetScoresFromDocument(ref int countProblems, ref int answerCheckerScore, ref int electroFlashScore, ref Player player, ref Player player2)
        {
            //get directory
            string convert;
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string scoreFile = dir + @"DatamanScores.csv";
            int[] scoresArray = new int[4];
            // scoresArray[0] = answerCheckerScore;
            //scoresArray[1] = electroFlashScore;
            //scoresArray[2] = player.Score;
            // scoresArray[3] = player2.Score;

            try
            {
                using (StreamReader output = File.OpenText(scoreFile))
                {
                    while (!output.EndOfStream)
                    {
                        for (int i = 0; i < scoresArray.Length; i++)
                        {

                            scoresArray[i] = int.Parse(output.ReadLine());

                        }

                        answerCheckerScore = scoresArray[0];
                        electroFlashScore = scoresArray[1];
                        player.Score = scoresArray[2];
                        player2.Score = scoresArray[3];

                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e + "\n\n Press Enter");//Display exception if document saves incorrectly
                Console.ReadLine();
            }
            

        }
    }
}
