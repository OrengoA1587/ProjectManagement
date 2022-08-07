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

namespace WinFormUI
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
            progressBarLabel.Visible = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            progressBarLabel.Visible = true;
            startupProgressBar.Visible = true;//Set progress bar to visible
            startupProgressBar.Minimum = 0;//Set progress bar minimum value
            startupProgressBar.Maximum = 100;//Set progress bar maximum value

            //Use for loop to fill progress bar
            for(int i = 0; i <= 100; i++)
            {
                Thread.Sleep(20);
                startupProgressBar.Value = i;
                progressBarLabel.Text = startupProgressBar.Value.ToString() + "% ";
                progressBarLabel.Update();
            }
            enterButton.Visible = true;//Set enter button to visible

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            this.Close();//Closes form
        }
    }
}
