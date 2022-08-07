using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class StopWatch : Form
    {
        public StopWatch()
        {
            InitializeComponent();
           
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            timerTextBox.Text = "Seconds";
            var seconds = 10;

            for (var i = seconds - 1; i <= seconds; i--)
            {

                Thread.Sleep(1000);
                timerTextBox.Text = "\rSeconds" + i;
                timerTextBox.Update();
                if (i == 0)
                {

                    timerTextBox.Text = "\rTime has finsished";


                }
            }
        }
    }
}
