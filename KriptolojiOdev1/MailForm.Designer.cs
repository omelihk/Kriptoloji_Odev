namespace KriptolojiOdev1
{
    partial class MailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sifreTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gonderButton = new System.Windows.Forms.Button();
            this.iptalButton = new System.Windows.Forms.Button();
            this.appPasswordLink = new System.Windows.Forms.LinkLabel();
            this.gonderenComboBox = new System.Windows.Forms.ComboBox();
            this.aliciComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gönderen E-Posta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gmail App Password:";
            // 
            // sifreTextBox
            // 
            this.sifreTextBox.Location = new System.Drawing.Point(24, 93);
            this.sifreTextBox.Name = "sifreTextBox";
            this.sifreTextBox.PasswordChar = '●';
            this.sifreTextBox.Size = new System.Drawing.Size(362, 22);
            this.sifreTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alıcı E-Posta:";
            // 
            // gonderButton
            // 
            this.gonderButton.BackColor = System.Drawing.Color.Lime;
            this.gonderButton.Location = new System.Drawing.Point(204, 212);
            this.gonderButton.Name = "gonderButton";
            this.gonderButton.Size = new System.Drawing.Size(89, 40);
            this.gonderButton.TabIndex = 6;
            this.gonderButton.Text = "Gönder";
            this.gonderButton.UseVisualStyleBackColor = false;
            this.gonderButton.Click += new System.EventHandler(this.gonderButton_Click);
            // 
            // iptalButton
            // 
            this.iptalButton.BackColor = System.Drawing.Color.Red;
            this.iptalButton.Location = new System.Drawing.Point(299, 212);
            this.iptalButton.Name = "iptalButton";
            this.iptalButton.Size = new System.Drawing.Size(89, 40);
            this.iptalButton.TabIndex = 7;
            this.iptalButton.Text = "İptal";
            this.iptalButton.UseVisualStyleBackColor = false;
            this.iptalButton.Click += new System.EventHandler(this.iptalButton_Click);
            // 
            // appPasswordLink
            // 
            this.appPasswordLink.AutoSize = true;
            this.appPasswordLink.Location = new System.Drawing.Point(21, 205);
            this.appPasswordLink.Name = "appPasswordLink";
            this.appPasswordLink.Size = new System.Drawing.Size(168, 16);
            this.appPasswordLink.TabIndex = 8;
            this.appPasswordLink.TabStop = true;
            this.appPasswordLink.Text = "App Password Nasıl Alınır?";
            this.appPasswordLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.appPasswordLink_LinkClicked);
            // 
            // gonderenComboBox
            // 
            this.gonderenComboBox.FormattingEnabled = true;
            this.gonderenComboBox.Items.AddRange(new object[] {
            "emreciftci8@gmail.com",
            "o.melihkocaoglu@gmail.com"});
            this.gonderenComboBox.Location = new System.Drawing.Point(24, 28);
            this.gonderenComboBox.Name = "gonderenComboBox";
            this.gonderenComboBox.Size = new System.Drawing.Size(362, 24);
            this.gonderenComboBox.TabIndex = 9;
            // 
            // aliciComboBox
            // 
            this.aliciComboBox.FormattingEnabled = true;
            this.aliciComboBox.Items.AddRange(new object[] {
            "emreciftci8@gmail.com",
            "o.melihkocaoglu@gmail.com"});
            this.aliciComboBox.Location = new System.Drawing.Point(24, 160);
            this.aliciComboBox.Name = "aliciComboBox";
            this.aliciComboBox.Size = new System.Drawing.Size(362, 24);
            this.aliciComboBox.TabIndex = 10;
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 256);
            this.Controls.Add(this.aliciComboBox);
            this.Controls.Add(this.gonderenComboBox);
            this.Controls.Add(this.appPasswordLink);
            this.Controls.Add(this.iptalButton);
            this.Controls.Add(this.gonderButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sifreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MailForm";
            this.Text = "MailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifreTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gonderButton;
        private System.Windows.Forms.Button iptalButton;
        private System.Windows.Forms.LinkLabel appPasswordLink;
        private System.Windows.Forms.ComboBox gonderenComboBox;
        private System.Windows.Forms.ComboBox aliciComboBox;
    }
}