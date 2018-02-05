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
            this.CheckboxLogging = new System.Windows.Forms.CheckBox();
            this.TimerGui = new System.Windows.Forms.Timer(this.components);
            this.lblSampletimeLeft = new System.Windows.Forms.Label();
            this.lblLoggingTime = new System.Windows.Forms.Label();
            this.checkBoxAutosample = new System.Windows.Forms.CheckBox();
            this.lblSamplingLeftCaption = new System.Windows.Forms.Label();
            this.lblLoggingLeftCaption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSample
            // 
            this.btnSample.Location = new System.Drawing.Point(12, 12);
            this.btnSample.Name = "btnSample";
            this.btnSample.Size = new System.Drawing.Size(75, 32);
            this.btnSample.TabIndex = 1;
            this.btnSample.Text = "Sample";
            this.btnSample.UseVisualStyleBackColor = true;
            this.btnSample.Click += new System.EventHandler(this.btnSample_Click);
            // 
            // btnLog
            // 
            this.btnLog.Location = new System.Drawing.Point(252, 12);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(75, 32);
            this.btnLog.TabIndex = 2;
            this.btnLog.Text = "Log to file";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 82);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(336, 144);
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
            // CheckboxLogging
            // 
            this.CheckboxLogging.AutoSize = true;
            this.CheckboxLogging.Location = new System.Drawing.Point(333, 22);
            this.CheckboxLogging.Name = "CheckboxLogging";
            this.CheckboxLogging.Size = new System.Drawing.Size(15, 14);
            this.CheckboxLogging.TabIndex = 4;
            this.CheckboxLogging.UseVisualStyleBackColor = true;
            // 
            // TimerGui
            // 
            this.TimerGui.Tick += new System.EventHandler(this.TimerGui_Tick);
            // 
            // lblSampletimeLeft
            // 
            this.lblSampletimeLeft.AutoSize = true;
            this.lblSampletimeLeft.Location = new System.Drawing.Point(94, 26);
            this.lblSampletimeLeft.Name = "lblSampletimeLeft";
            this.lblSampletimeLeft.Size = new System.Drawing.Size(0, 13);
            this.lblSampletimeLeft.TabIndex = 5;
            // 
            // lblLoggingTime
            // 
            this.lblLoggingTime.AutoSize = true;
            this.lblLoggingTime.Location = new System.Drawing.Point(211, 26);
            this.lblLoggingTime.Name = "lblLoggingTime";
            this.lblLoggingTime.Size = new System.Drawing.Size(0, 13);
            this.lblLoggingTime.TabIndex = 6;
            // 
            // checkBoxAutosample
            // 
            this.checkBoxAutosample.AutoSize = true;
            this.checkBoxAutosample.Location = new System.Drawing.Point(12, 51);
            this.checkBoxAutosample.Name = "checkBoxAutosample";
            this.checkBoxAutosample.Size = new System.Drawing.Size(81, 17);
            this.checkBoxAutosample.TabIndex = 7;
            this.checkBoxAutosample.Text = "Autosample";
            this.checkBoxAutosample.UseVisualStyleBackColor = true;
            // 
            // lblSamplingLeftCaption
            // 
            this.lblSamplingLeftCaption.AutoSize = true;
            this.lblSamplingLeftCaption.Location = new System.Drawing.Point(94, 9);
            this.lblSamplingLeftCaption.Name = "lblSamplingLeftCaption";
            this.lblSamplingLeftCaption.Size = new System.Drawing.Size(0, 13);
            this.lblSamplingLeftCaption.TabIndex = 8;
            // 
            // lblLoggingLeftCaption
            // 
            this.lblLoggingLeftCaption.AutoSize = true;
            this.lblLoggingLeftCaption.Location = new System.Drawing.Point(195, 9);
            this.lblLoggingLeftCaption.Name = "lblLoggingLeftCaption";
            this.lblLoggingLeftCaption.Size = new System.Drawing.Size(0, 13);
            this.lblLoggingLeftCaption.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 238);
            this.Controls.Add(this.lblLoggingLeftCaption);
            this.Controls.Add(this.lblSamplingLeftCaption);
            this.Controls.Add(this.checkBoxAutosample);
            this.Controls.Add(this.lblLoggingTime);
            this.Controls.Add(this.lblSampletimeLeft);
            this.Controls.Add(this.CheckboxLogging);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnSample);
            this.Name = "Form1";
            this.Text = "Assignment I - Virtual sensors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSample;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Timer TimerSample;
        private System.Windows.Forms.Timer TimerLogging;
        private System.Windows.Forms.CheckBox CheckboxLogging;
        private System.Windows.Forms.Timer TimerGui;
        private System.Windows.Forms.Label lblSampletimeLeft;
        private System.Windows.Forms.Label lblLoggingTime;
        private System.Windows.Forms.CheckBox checkBoxAutosample;
        private System.Windows.Forms.Label lblSamplingLeftCaption;
        private System.Windows.Forms.Label lblLoggingLeftCaption;
    }
}

