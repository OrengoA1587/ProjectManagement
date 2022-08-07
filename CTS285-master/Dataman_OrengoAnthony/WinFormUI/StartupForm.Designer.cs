namespace WinFormUI
{
    partial class StartupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.startupProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressBarLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.startButton.FlatAppearance.BorderSize = 3;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Location = new System.Drawing.Point(743, 552);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(92, 43);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.enterButton.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.enterButton.FlatAppearance.BorderSize = 3;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enterButton.Location = new System.Drawing.Point(743, 552);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(92, 43);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Visible = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // startupProgressBar
            // 
            this.startupProgressBar.Location = new System.Drawing.Point(11, 560);
            this.startupProgressBar.Name = "startupProgressBar";
            this.startupProgressBar.Size = new System.Drawing.Size(651, 35);
            this.startupProgressBar.TabIndex = 2;
            // 
            // progressBarLabel
            // 
            this.progressBarLabel.AutoSize = true;
            this.progressBarLabel.BackColor = System.Drawing.Color.Transparent;
            this.progressBarLabel.Font = new System.Drawing.Font("Microsoft Himalaya", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressBarLabel.ForeColor = System.Drawing.Color.Lime;
            this.progressBarLabel.Location = new System.Drawing.Point(668, 560);
            this.progressBarLabel.Name = "progressBarLabel";
            this.progressBarLabel.Size = new System.Drawing.Size(46, 32);
            this.progressBarLabel.TabIndex = 3;
            this.progressBarLabel.Text = "0%";
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.DataStartupImage;
            this.ClientSize = new System.Drawing.Size(836, 596);
            this.Controls.Add(this.progressBarLabel);
            this.Controls.Add(this.startupProgressBar);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.startButton);
            this.Name = "StartupForm";
            this.Text = "Startup Image";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.ProgressBar startupProgressBar;
        private System.Windows.Forms.Label progressBarLabel;
    }
}

