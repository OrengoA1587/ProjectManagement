using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatamanLibrary
{
    public class Calculator
    {
        #region Answer Checker
        public static int CheckAddition(int number1, int number2, int correctAnswer)
        {
           correctAnswer = number1 + number2;
           return correctAnswer;
        }
        public static int CheckSubtraction(int number1, int number2, int correctAnswer)
        {
            correctAnswer = number1 - number2;
            return correctAnswer;
        }
        public static int CheckMultiplication(int number1, int number2, int correctAnswer)
        {
            correctAnswer = number1 * number2;
            return correctAnswer;
        }
        public static int CheckDivision(int number1, int number2, int correctAnswer)
        {
            correctAnswer = number1 / number2;
            return correctAnswer;
        }
        #endregion
    }
}
