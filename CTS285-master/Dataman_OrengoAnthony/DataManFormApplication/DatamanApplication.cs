using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataManFormApplication
{
    public partial class DatamanApplication : Form
    {
        int numberOne = 0;
        int numberTwo = 0;
        int userAnswer = 0;
        int correctAnswer = 0;
        int tryCounter = 0;
        Double resultValue = 0;
        String operationPerformed = "";
        bool answerCheckerLoop = false;
        bool isOperationPerformed;
        Font font = new Font("Microsoft Sans Serif", 14.0f);
        Font font2 = new Font("Microsoft Sans Serif", 30.0f);
        public DatamanApplication()
        {
            InitializeComponent();
        }
        
        private void button_WOC_Click_Click(object sender, EventArgs e)
        {
            responseBox.Clear();
            if ((outputBox.Text == "0") || (isOperationPerformed))
                outputBox.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;

            outputBox.Text = outputBox.Text + button.Text;
            
        }

        private void outputBox_Enter(object sender, EventArgs e)
        {
            ActiveControl = (Control)sender;
        }

        private void CheckAnswer_Click(object sender, EventArgs e)
        {
            #region Answer Checker Input
            string[] tokens = outputBox.Text.Split('+','-','X','x','/', '=');
            if(tokens.Length < 3)
            {
                responseBox.Text = "Invalid!";
                outputBox.Clear();
            }
            else if(int.TryParse(tokens[0], out numberOne))
            {
                if (int.TryParse(tokens[1], out numberTwo))
                {
                    if (int.TryParse(tokens[2], out userAnswer))
                    {

                    }
                    else
                    {
                        responseBox.Text = "Invalid!";
                        outputBox.Clear();
                    }

                }
                else
                {
                    responseBox.Text = "Invalid!";
                    outputBox.Clear();
                }

            }
            else
            {
                responseBox.Text = "Invalid!";
                outputBox.Clear();
            }
            #endregion Answer Checker Input

            string problem;

            #region Addition Checker
            if (outputBox.Text.Contains('+'))
            {
                correctAnswer = numberOne + numberTwo;
                bool addLoop = false;
                tryCounter++;
                do
                {
                    
                    if (userAnswer == correctAnswer)
                    {
                        responseBox.Text = "Correct! \nGood Job!";
                        tryCounter = 0;
                        answerCheckerLoop = true;
                        outputBox.Clear();
                    }
                    else if (userAnswer != correctAnswer)
                    {
                        responseBox.Text = "Incorrect Answer!Try Again!";
                        outputBox.Text = "Incorrect Answer!Try Again!";
                        
                        do
                        {
                            outputBox.Clear();
                            responseBox.Text = "Incorrect Answer!Try Again!";
                            outputBox.Text = tokens[0] + "+" + tokens[1] + "=";
                            if (tryCounter == 2)
                            {
                                responseBox.Text = $"You Exceeded the number of tries!\n The correct answer is: {correctAnswer}";
                                answerCheckerLoop = true;
                                addLoop = true;
                            }
                            else if (tryCounter != 2)
                            {


                                if (userAnswer == correctAnswer)
                                {
                                    responseBox.Text = "Correct! \nGood Job!";
                                    answerCheckerLoop = true;
                                    addLoop = true;
                                    outputBox.Clear();
                                }
                                else
                                {
                                    answerCheckerLoop = true;
                                    addLoop = true;
                                }
                            }

                        } while (addLoop == false);
                    }
                } while (answerCheckerLoop == false);               
            }
            #endregion

            #region Subtraction Checker
            else if (outputBox.Text.Contains('-'))
            {
                correctAnswer = numberOne - numberTwo;
                if(numberTwo > numberOne)
                {
                    responseBox.Text = "Invalid!";
                    outputBox.Clear();
                }
                else
                {
                    if (userAnswer == correctAnswer)
                    {
                        responseBox.Text = "Correct! \nGood Job!";
                        outputBox.Clear();
                    }
                    else
                    {
                        responseBox.Text = "Incorrect Answer!Try Again!";
                        outputBox.Text = tokens[0] + "-" + tokens[1] + "=" + tokens[2];
                        if (userAnswer == correctAnswer)
                        {
                            responseBox.Text = "Correct! \nGood Job!";
                            outputBox.Clear();
                        }
                        else
                        {
                            responseBox.Text = $"Incorrect Answer!\nThe correct answer is {correctAnswer}.";
                            outputBox.Clear();
                        }

                    }

                }                
            }
            #endregion

            #region Multiplication Checker
            if (outputBox.Text.Contains('X') || outputBox.Text.Contains('x')) 
            {
                correctAnswer = numberOne * numberTwo;
                if (userAnswer == correctAnswer)
                {
                    responseBox.Text = "Correct! \nGood Job!";
                    outputBox.Clear();
                }
                else
                {
                    responseBox.Text = "Incorrect Answer!Try Again!";
                    outputBox.Text = tokens[0] + "X" + tokens[1] + "=" + tokens[2];
                    if (userAnswer == correctAnswer)
                    {
                        responseBox.Text = "Correct! \nGood Job!";
                        outputBox.Clear();
                    }
                    else
                    {
                        responseBox.Text = $"Incorrect Answer!\nThe correct answer is {correctAnswer}.";
                        outputBox.Clear();
                    }

                }
            }
            #endregion

            #region Division Checker
            if (outputBox.Text.Contains('/'))
            {
                correctAnswer = numberOne / numberTwo;
                if (userAnswer == correctAnswer)
                {
                    responseBox.Text = "Correct! \nGood Job!";
                    outputBox.Clear();
                }
                else
                {
                    responseBox.Text = "Incorrect Answer!Try Again!";
                    outputBox.Text = tokens[0] + "/" + tokens[1] + "=" + tokens[2];
                    if (userAnswer == correctAnswer)
                    {
                        responseBox.Text = "Correct! \nGood Job!";
                        outputBox.Clear();
                    }
                    else
                    {
                        responseBox.Text = $"Incorrect Answer!\nThe correct answer is {correctAnswer}.";
                        outputBox.Clear();
                    }

                }
            }
            #endregion
        }

        private void on_button_Click(object sender, EventArgs e)
        {
            if (outputBox.Text == "" && responseBox.Text == "")
            {                
                outputBox.Font = font;
                outputBox.Text = "Welcome to Dataman. Press On again to begin Answer Checker";

            }
            else
            {
                outputBox.Font = font2;
                responseBox.Clear();
                outputBox.Clear();
            }
        }


        private void off_button_Click(object sender, EventArgs e)
        {
           
            
            TurnOff();
        }
        private void TurnOff()
        {
            Thread.Sleep(2000);
            outputBox.Text = "GoodBye";
            Environment.Exit(0);
        }

        
    }
}
