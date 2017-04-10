namespace Smtp_client_WindowMode
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
            this.IP_TextBox = new System.Windows.Forms.TextBox();
            this.Port_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainConsole = new System.Windows.Forms.TextBox();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SendButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SenderTextBox = new System.Windows.Forms.TextBox();
            this.ReceiverTextBox = new System.Windows.Forms.TextBox();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.DataTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileTextBox = new System.Windows.Forms.TextBox();
            this.FileSizeBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ClearFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IP_TextBox
            // 
            this.IP_TextBox.Location = new System.Drawing.Point(94, 17);
            this.IP_TextBox.Name = "IP_TextBox";
            this.IP_TextBox.Size = new System.Drawing.Size(209, 22);
            this.IP_TextBox.TabIndex = 0;
            this.IP_TextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Port_TextBox
            // 
            this.Port_TextBox.Location = new System.Drawing.Point(94, 51);
            this.Port_TextBox.Name = "Port_TextBox";
            this.Port_TextBox.Size = new System.Drawing.Size(82, 22);
            this.Port_TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // MainConsole
            // 
            this.MainConsole.Location = new System.Drawing.Point(12, 82);
            this.MainConsole.Multiline = true;
            this.MainConsole.Name = "MainConsole";
            this.MainConsole.ReadOnly = true;
            this.MainConsole.Size = new System.Drawing.Size(661, 175);
            this.MainConsole.TabIndex = 4;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(182, 49);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(121, 27);
            this.ConnectButton.TabIndex = 5;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(514, 430);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(159, 46);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Log in";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(404, 12);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(169, 22);
            this.UsernameBox.TabIndex = 8;
            this.UsernameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(404, 54);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(169, 22);
            this.PasswordBox.TabIndex = 9;
            this.PasswordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // SenderTextBox
            // 
            this.SenderTextBox.Location = new System.Drawing.Point(94, 263);
            this.SenderTextBox.Name = "SenderTextBox";
            this.SenderTextBox.Size = new System.Drawing.Size(414, 22);
            this.SenderTextBox.TabIndex = 12;
            // 
            // ReceiverTextBox
            // 
            this.ReceiverTextBox.Location = new System.Drawing.Point(94, 291);
            this.ReceiverTextBox.Name = "ReceiverTextBox";
            this.ReceiverTextBox.Size = new System.Drawing.Size(414, 22);
            this.ReceiverTextBox.TabIndex = 13;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(94, 319);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(414, 22);
            this.SubjectTextBox.TabIndex = 14;
            // 
            // DataTextBox
            // 
            this.DataTextBox.Location = new System.Drawing.Point(12, 347);
            this.DataTextBox.Multiline = true;
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.Size = new System.Drawing.Size(496, 129);
            this.DataTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(63, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "To";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Subject:";
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(514, 300);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(159, 34);
            this.BrowseButton.TabIndex = 19;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileTextBox
            // 
            this.FileTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.FileTextBox.Location = new System.Drawing.Point(514, 357);
            this.FileTextBox.Name = "FileTextBox";
            this.FileTextBox.ReadOnly = true;
            this.FileTextBox.Size = new System.Drawing.Size(159, 22);
            this.FileTextBox.TabIndex = 20;
            this.FileTextBox.Text = "No File";
            this.FileTextBox.TextChanged += new System.EventHandler(this.FileTextBox_TextChanged);
            // 
            // FileSizeBox
            // 
            this.FileSizeBox.BackColor = System.Drawing.SystemColors.Info;
            this.FileSizeBox.Location = new System.Drawing.Point(514, 402);
            this.FileSizeBox.Name = "FileSizeBox";
            this.FileSizeBox.ReadOnly = true;
            this.FileSizeBox.Size = new System.Drawing.Size(159, 22);
            this.FileSizeBox.TabIndex = 21;
            this.FileSizeBox.Text = "0";
            this.FileSizeBox.TextChanged += new System.EventHandler(this.FileSizeBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(561, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Filename";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(576, 382);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Size";
            // 
            // ClearFileButton
            // 
            this.ClearFileButton.Location = new System.Drawing.Point(514, 266);
            this.ClearFileButton.Name = "ClearFileButton";
            this.ClearFileButton.Size = new System.Drawing.Size(159, 28);
            this.ClearFileButton.TabIndex = 24;
            this.ClearFileButton.Text = "Clear";
            this.ClearFileButton.UseVisualStyleBackColor = true;
            this.ClearFileButton.Click += new System.EventHandler(this.ClearFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 488);
            this.Controls.Add(this.ClearFileButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FileSizeBox);
            this.Controls.Add(this.FileTextBox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.ReceiverTextBox);
            this.Controls.Add(this.SenderTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.MainConsole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Port_TextBox);
            this.Controls.Add(this.IP_TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IP_TextBox;
        private System.Windows.Forms.TextBox Port_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MainConsole;
        private System.Windows.Forms.Button ConnectButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SenderTextBox;
        private System.Windows.Forms.TextBox ReceiverTextBox;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.TextBox DataTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox FileTextBox;
        private System.Windows.Forms.TextBox FileSizeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ClearFileButton;
    }
}

