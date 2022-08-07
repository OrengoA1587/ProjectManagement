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
using DatamanLibrary;

namespace WinFormUI
{
    public partial class WriteToDocumentLoadingBarForm : Form
    {
        public Player defaultPlayer = new Player();//Create default player to pass player.Counter variable
        public WriteToDocumentLoadingBarForm(ref Player player)           
        {
            defaultPlayer.Counter = player.Counter; //Sets defaultPlayer.Counter to player.Counter

            InitializeComponent();
            //FileWriterProgress();
            
        }
        int count = 0;
        
        private void saveButton_Click(object sender, EventArgs e)
        {
            //player1.Counter = 1;
            int num = defaultPlayer.Counter;//Keeps original file size number
            fileSizeLabel.Text = count.ToString();
            fileWriterProgressBar.Minimum = 0;
            fileWriterProgressBar.Maximum = 101;
            fileUploadProgressBar.Minimum = 0;
            fileUploadProgressBar.Maximum = 101;

            while (defaultPlayer.Counter > 0)
            {
                fileUploadProgressBar.Value += 101 / num;
                fileUploadProgressBar.Update();
                for (int i = 0; i <= 101; i++)
                {

                    Thread.Sleep(20);
                    fileWriterProgressBarLabel.Text = fileWriterProgressBar.Value.ToString() + "%";
                    fileWriterProgressBar.Value = i;

                    fileWriterProgressBarLabel.Update(); //Updates label to new text                

                }          
                
                count++;
                defaultPlayer.Counter--;
                fileSizeLabel.Text = count.ToString() + " Problem(s) ";
                fileSizeLabel.Update();//Updates label to new text  


            }
            finishButton.Visible = true;//Sets finishButton to visible
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
    }
}
