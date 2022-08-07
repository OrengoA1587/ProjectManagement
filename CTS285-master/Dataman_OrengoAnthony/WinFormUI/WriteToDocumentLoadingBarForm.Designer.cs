
namespace WinFormUI
{
    partial class WriteToDocumentLoadingBarForm
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
            this.fileWriterProgressBar = new System.Windows.Forms.ProgressBar();
            this.fileWriterProgressBarLabel = new System.Windows.Forms.Label();
            this.fileTrackerLabel = new System.Windows.Forms.Label();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.finishButton = new System.Windows.Forms.Button();
            this.fileUploadProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // fileWriterProgressBar
            // 
            this.fileWriterProgressBar.Location = new System.Drawing.Point(17, 69);
            this.fileWriterProgressBar.Name = "fileWriterProgressBar";
            this.fileWriterProgressBar.Size = new System.Drawing.Size(420, 29);
            this.fileWriterProgressBar.TabIndex = 0;
            // 
            // fileWriterProgressBarLabel
            // 
            this.fileWriterProgressBarLabel.AutoSize = true;
            this.fileWriterProgressBarLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileWriterProgressBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileWriterProgressBarLabel.ForeColor = System.Drawing.Color.Lime;
            this.fileWriterProgressBarLabel.Location = new System.Drawing.Point(210, 101);
            this.fileWriterProgressBarLabel.Name = "fileWriterProgressBarLabel";
            this.fileWriterProgressBarLabel.Size = new System.Drawing.Size(54, 20);
            this.fileWriterProgressBarLabel.TabIndex = 1;
            this.fileWriterProgressBarLabel.Text = "0%    ";
            // 
            // fileTrackerLabel
            // 
            this.fileTrackerLabel.AutoSize = true;
            this.fileTrackerLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileTrackerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileTrackerLabel.ForeColor = System.Drawing.Color.White;
            this.fileTrackerLabel.Location = new System.Drawing.Point(121, 179);
            this.fileTrackerLabel.Name = "fileTrackerLabel";
            this.fileTrackerLabel.Size = new System.Drawing.Size(86, 20);
            this.fileTrackerLabel.TabIndex = 2;
            this.fileTrackerLabel.Text = "Uploaded";
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileSizeLabel.ForeColor = System.Drawing.Color.Lime;
            this.fileSizeLabel.Location = new System.Drawing.Point(220, 179);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(24, 20);
            this.fileSizeLabel.TabIndex = 3;
            this.fileSizeLabel.Text = "0 ";
            // 
            // saveButton
            // 
            this.saveButton.FlatAppearance.BorderSize = 3;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(17, 21);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(87, 32);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // finishButton
            // 
            this.finishButton.FlatAppearance.BorderSize = 3;
            this.finishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finishButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.Location = new System.Drawing.Point(405, 163);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(87, 34);
            this.finishButton.TabIndex = 5;
            this.finishButton.Text = "Finish";
            this.finishButton.UseVisualStyleBackColor = true;
            this.finishButton.Visible = false;
            this.finishButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileUploadProgressBar
            // 
            this.fileUploadProgressBar.Location = new System.Drawing.Point(17, 134);
            this.fileUploadProgressBar.Name = "fileUploadProgressBar";
            this.fileUploadProgressBar.Size = new System.Drawing.Size(420, 23);
            this.fileUploadProgressBar.TabIndex = 6;
            // 
            // WriteToDocumentLoadingBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinFormUI.Properties.Resources.DataManLogo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 201);
            this.Controls.Add(this.fileUploadProgressBar);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.fileTrackerLabel);
            this.Controls.Add(this.fileWriterProgressBarLabel);
            this.Controls.Add(this.fileWriterProgressBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "WriteToDocumentLoadingBarForm";
            this.Text = "WriteToDocumentLoadingBarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar fileWriterProgressBar;
        private System.Windows.Forms.Label fileWriterProgressBarLabel;
        private System.Windows.Forms.Label fileTrackerLabel;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.ProgressBar fileUploadProgressBar;
    }
}