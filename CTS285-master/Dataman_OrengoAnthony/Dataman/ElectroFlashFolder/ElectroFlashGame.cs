using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using DatamanLibrary;
using System.Windows.Forms;
namespace Dataman.ElectroFlashClasses
{
    public class ElectroFlashGame
    {
        TimerWatch countDown = new TimerWatch();
        #region Flash Cards 0-9
        public static void AddZeroToNine(ref Player player, ref string[] arithmeticArray)
        {            
            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Add 0-9 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer
              
                 
                tokens = arithmeticArray[index];
                    Console.WriteLine(tokens);
                    tokenize = tokens.Split('+', '=');
                
                    num1 = double.Parse(tokenize[0]);
                    num2 = double.Parse(tokenize[1]);

                    answer = num1 + num2;
                
                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if(double.TryParse(input, out userAnswer))
                {
                    if(answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer!");                        
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Answer!");
                }
                index++;
            }

            #endregion Add 0-9 Flash Cards

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
            Console.Clear();
        }
        public static void SubtractZeroToNine(ref Player player, ref string[] arithmeticArray)
        {
            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Add 0-9 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer
                
                tokens = arithmeticArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('-', '=');

                num1 = double.Parse(tokenize[0]);
                num2 = double.Parse(tokenize[1]);

                answer = num1 - num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer! Try Again!");
                        player.Score--;
                    }
                }
                index++;
            }
             
            #endregion

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
            Console.Clear();
        }
        public static void MultiplyZeroToNine(ref Player player, ref string[] arithmeticArray)
        {
            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Add 0-9 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer

                tokens = arithmeticArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('*', '=');

                num1 = double.Parse(tokenize[0]);
                num2 = double.Parse(tokenize[1]);

                answer = num1 * num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer! Try Again!");
                        player.Score--;
                    }
                }
                index++;
            }
            
            #endregion

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
            Console.Clear();
        }
        public static void DivideZeroToNine(ref Player player, ref string[] arithmeticArray)
        {
            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Add 0-9 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer

                tokens = arithmeticArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('/', '=');

                num1 = double.Parse(tokenize[0]);
                num2 = double.Parse(tokenize[1]);

                answer = num1 / num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer! Try Again!");
                        player.Score--;
                    }
                }
                index++;
            }
            
            #endregion

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
            Console.Clear();
        }
        #endregion
        //========================================================================================================

        #region Flash Cards 0-49
        public static void AddZeroToFourNine(ref Player player, ref string[] arithmeticArray)
        {

            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Add 0-49 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer

                tokens = arithmeticArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('+', '=');

                num1 = double.Parse(tokenize[0]);
                num2 = double.Parse(tokenize[1]);

                answer = num1 + num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer! Try Again!");
                        player.Score--;
                    }
                }
                index++;
            }
             
            #endregion

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
        }
        public static void SubtractZeroToFourNine(ref Player player, ref string[] arithmeticArray)
        {
            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Subtract 0-49 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer

                tokens = arithmeticArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('-', '=');

                num1 = double.Parse(tokenize[0]);
                num2 = double.Parse(tokenize[1]);

                answer = num1 - num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer! Try Again!");
                        player.Score--;
                    }
                }
                index++;
            }
            
            #endregion

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
        }
        public static void MultiplyZeroToFourNine(ref Player player, ref string[] arithmeticArray)
        {
            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Multiply 0-49 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer

                tokens = arithmeticArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('*', '=');

                num1 = double.Parse(tokenize[0]);
                num2 = double.Parse(tokenize[1]);

                answer = num1 * num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer! Try Again!");
                        player.Score--;
                    }
                }
                index++;
            }
             
            #endregion

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
        }
        public static void DivideZeroToFourNine(ref Player player, ref string[] arithmeticArray)
        {
            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Divide 0-49 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer

                tokens = arithmeticArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('/', '=');

                num1 = double.Parse(tokenize[0]);
                num2 = double.Parse(tokenize[1]);

                answer = num1 / num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer! Try Again!");
                        player.Score--;
                    }
                }
                index++;
            }
            
            #endregion

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
        }
        #endregion
        //========================================================================================================

        #region Flash Cards 0-99
        public static void AddZeroToNinetyNine(ref Player player, ref string[] arithmeticArray)
        {

            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Add 0-99 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer
              
                tokens = arithmeticArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('+', '=');

                num1 = double.Parse(tokenize[0]);
                num2 = double.Parse(tokenize[1]);

                answer = num1 + num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer! Try Again!");
                        player.Score--;
                    }
                }
                index++;
            }
             
            #endregion

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
        }
        public static void SubtractZeroToNinetyNine(ref Player player, ref string[] arithmeticArray)
        {
            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Subtract 0-99 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer

                tokens = arithmeticArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('-', '=');

                num1 = double.Parse(tokenize[0]);
                num2 = double.Parse(tokenize[1]);

                answer = num1 - num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer! Try Again!");
                        player.Score--;
                    }
                }
                index++;
            }
           
            #endregion

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
        }
        public static void MultiplyZeroToNinetyNine(ref Player player, ref string[] arithmeticArray)
        {
            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Multiply 0-99 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer

                tokens = arithmeticArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('*', '=');

                num1 = double.Parse(tokenize[0]);            
                num2 = double.Parse(tokenize[1]);

                answer = num1 * num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer! Try Again!");
                        player.Score--;
                    }
                }
                index++;
            }
             
            #endregion

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
        }
        public static void DivideZeroToNinetyNine(ref Player player, ref string[] arithmeticArray)
        {
            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Divide 0-99 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer

                tokens = arithmeticArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('/', '=');

                num1 = double.Parse(tokenize[0]);
                num2 = double.Parse(tokenize[1]);

                answer = num1 / num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer! Try Again!");
                        player.Score--;
                    }
                }
                index++;
            }
             
            #endregion

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
        }
        #endregion
        //========================================================================================================

        #region Flash Cards 1-499
        public static void AddZeroToFourNinetyNine(ref Player player, ref string[] arithmeticArray)
        {

            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Add 0-499 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer

                tokens = arithmeticArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('+', '=');              
                
                
                num1 = double.Parse(tokenize[0]);
                num2 = double.Parse(tokenize[1]);

                answer = num1 + num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer! Try Again!");
                        player.Score--;
                    }
                }
                index++;
            }
            
            #endregion

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
        }
        public static void SubtractZeroToFourNinetyNine(ref Player player, ref string[] arithmeticArray)
        {
            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Subtract 0-499 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer

                tokens = arithmeticArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('-', '=');

                num1 = double.Parse(tokenize[0]);
                num2 = double.Parse(tokenize[1]);

                answer = num1 - num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer! Try Again!");
                        player.Score--;
                    }
                }
                index++;
            }
             
            #endregion

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
        }
        public static void MultiplyZeroToFourNinetyNine(ref Player player, ref string[] arithmeticArray)
        {
            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Multiply 0-499 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer

                tokens = arithmeticArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('*', '=');

                num1 = double.Parse(tokenize[0]);
                num2 = double.Parse(tokenize[1]);

                answer = num1 * num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer! Try Again!");
                        player.Score--;
                    }
                }
                index++;
            }
             
            #endregion

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
        }
        public static void DivideZeroToFourNinetyNine(ref Player player, ref string[] arithmeticArray)
        {
            Console.Clear();
            #region Variables, Sentinels, and Objects
            double num1 = 0;
            double num2 = 0;
            double answer = 0;
            double userAnswer = 0;
            string input = "";
            int index = 0;
            string[] tokenize;
            string tokens = "";
            #endregion

            #region Divide 0-499 Flash Cards
            Console.WriteLine(StandardMessages.ElectroFlashTitle());
            while (index != arithmeticArray.Length)
            {
                //Get answer

                tokens = arithmeticArray[index];
                Console.WriteLine(tokens);
                tokenize = tokens.Split('/', '=');

                num1 = double.Parse(tokenize[0]);
                num2 = double.Parse(tokenize[1]);

                answer = num1 / num2;

                Console.Write("Enter your answer: ");
                input = Console.ReadLine();
                if (double.TryParse(input, out userAnswer))
                {
                    if (answer == userAnswer)
                    {
                        Console.WriteLine("Great Job");
                        player.Score++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer! Try Again!");
                        player.Score--;
                    }
                }
                index++;
            }
           
            #endregion

            #region Player Score Message
            PlayerScoreMessage.DisplayPlayersScore(ref player);
            #endregion Player Score Message
        }
        #endregion
        //========================================================================================================
    }
}
