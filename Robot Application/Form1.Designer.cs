namespace Robot_Application
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
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.extendButton = new System.Windows.Forms.Button();
            this.retractButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.cmdTextBox = new System.Windows.Forms.TextBox();
            this.stationComboBox = new System.Windows.Forms.ComboBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(271, 14);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(82, 47);
            this.upButton.TabIndex = 0;
            this.upButton.Text = "Up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(359, 14);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(82, 47);
            this.downButton.TabIndex = 1;
            this.downButton.Text = "Down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // extendButton
            // 
            this.extendButton.Location = new System.Drawing.Point(271, 67);
            this.extendButton.Name = "extendButton";
            this.extendButton.Size = new System.Drawing.Size(82, 47);
            this.extendButton.TabIndex = 2;
            this.extendButton.Text = "Extend";
            this.extendButton.UseVisualStyleBackColor = true;
            this.extendButton.Click += new System.EventHandler(this.extendButton_Click);
            // 
            // retractButton
            // 
            this.retractButton.Location = new System.Drawing.Point(359, 65);
            this.retractButton.Name = "retractButton";
            this.retractButton.Size = new System.Drawing.Size(82, 49);
            this.retractButton.TabIndex = 3;
            this.retractButton.Text = "Retract";
            this.retractButton.UseVisualStyleBackColor = true;
            this.retractButton.Click += new System.EventHandler(this.retractButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(316, 120);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(82, 47);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(12, 14);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(253, 168);
            this.messageBox.TabIndex = 5;
            this.messageBox.Text = "";
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            // 
            // cmdTextBox
            // 
            this.cmdTextBox.Location = new System.Drawing.Point(12, 190);
            this.cmdTextBox.Multiline = true;
            this.cmdTextBox.Name = "cmdTextBox";
            this.cmdTextBox.Size = new System.Drawing.Size(192, 22);
            this.cmdTextBox.TabIndex = 6;
            this.cmdTextBox.TextChanged += new System.EventHandler(this.cmdTextBox_TextChanged);
            // 
            // stationComboBox
            // 
            this.stationComboBox.FormattingEnabled = true;
            this.stationComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.stationComboBox.Location = new System.Drawing.Point(294, 191);
            this.stationComboBox.Name = "stationComboBox";
            this.stationComboBox.Size = new System.Drawing.Size(121, 21);
            this.stationComboBox.TabIndex = 8;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(210, 190);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(55, 24);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 226);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.stationComboBox);
            this.Controls.Add(this.cmdTextBox);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.retractButton);
            this.Controls.Add(this.extendButton);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Robot Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button extendButton;
        private System.Windows.Forms.Button retractButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.TextBox cmdTextBox;
        private System.Windows.Forms.ComboBox stationComboBox;
        private System.Windows.Forms.Button sendButton;
    }
}

