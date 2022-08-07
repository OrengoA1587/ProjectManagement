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
using System.Timers;
using System.Diagnostics;
namespace WinFormUI
{
    public partial class WipeOutApplication : Form
    {
        
        StopWatch watch = new StopWatch();
        public WipeOutApplication()
        {
            InitializeComponent();
          
        }
        public bool isOperationPerformed;

        private void StopWatch_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer time = new System.Windows.Forms.Timer();
            time.Interval = 10000;
            time.Tick += new EventHandler(time_Tick);
            time.Start();
        }
        private void time_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("The form will now be closed.", "Time Elapsed");
            this.Close();
        }
        private void numButtons_Click(object sender, EventArgs e)
        {
            watch.ShowDialog();
            responseBox.Clear();
            if ((outputBox.Text == "0") || (isOperationPerformed))
                outputBox.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
           
            outputBox.Text = outputBox.Text + button.Text;
        }
         
    }
}
