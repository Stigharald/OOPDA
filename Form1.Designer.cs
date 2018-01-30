namespace Assignment1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnSample = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.TimerSample = new System.Windows.Forms.Timer(this.components);
            this.TimerLogging = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnSample
            // 
            this.btnSample.Location = new System.Drawing.Point(12, 12);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(75, 23);
            this.btnSample.TabIndex = 1;
            this.btnSample.Text = "Sample";
            this.btnSample.UseVisualStyleBackColor = true;
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(322, 12);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 23);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Log to file";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 54);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(385, 279);
            this.TextBox.TabIndex = 3;
            this.TextBox.Text = "";
            // 
            // TimerSample
            // 
            this.TimerSample.Tick += new System.EventHandler(this.TimerSample_Tick);
            // 
            // TimerLogging
            // 
            this.TimerLogging.Tick += new System.EventHandler(this.TimerLogging_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 345);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnSample);
            this.Name = "Form1";
            this.Text = "Assignment I - Virtual sensors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSample;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Timer TimerSample;
        private System.Windows.Forms.Timer TimerLogging;
    }
}

