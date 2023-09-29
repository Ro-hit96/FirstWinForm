namespace FirstWinForm
{
    partial class LoginForm
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
            this.Usernamelabel = new System.Windows.Forms.Label();
            this.Passlabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PTextBox = new System.Windows.Forms.TextBox();
            this.UTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Usernamelabel
            // 
            this.Usernamelabel.AutoSize = true;
            this.Usernamelabel.Location = new System.Drawing.Point(343, 135);
            this.Usernamelabel.Name = "Usernamelabel";
            this.Usernamelabel.Size = new System.Drawing.Size(89, 20);
            this.Usernamelabel.TabIndex = 0;
            this.Usernamelabel.Text = "User Name";
            this.Usernamelabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Passlabel
            // 
            this.Passlabel.AutoSize = true;
            this.Passlabel.Location = new System.Drawing.Point(343, 255);
            this.Passlabel.Name = "Passlabel";
            this.Passlabel.Size = new System.Drawing.Size(78, 20);
            this.Passlabel.TabIndex = 1;
            this.Passlabel.Text = "Password";
            this.Passlabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Lime;
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginButton.Location = new System.Drawing.Point(347, 351);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(106, 35);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.ForeColor = System.Drawing.Color.Black;
            this.CancelButton.Location = new System.Drawing.Point(542, 351);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(106, 35);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PTextBox
            // 
            this.PTextBox.Location = new System.Drawing.Point(507, 249);
            this.PTextBox.Name = "PTextBox";
            this.PTextBox.PasswordChar = '*';
            this.PTextBox.Size = new System.Drawing.Size(173, 26);
            this.PTextBox.TabIndex = 4;
            // 
            // UTextBox
            // 
            this.UTextBox.Location = new System.Drawing.Point(507, 129);
            this.UTextBox.Name = "UTextBox";
            this.UTextBox.Size = new System.Drawing.Size(173, 26);
            this.UTextBox.TabIndex = 5;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 550);
            this.Controls.Add(this.UTextBox);
            this.Controls.Add(this.PTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Passlabel);
            this.Controls.Add(this.Usernamelabel);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usernamelabel;
        private System.Windows.Forms.Label Passlabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox PTextBox;
        private System.Windows.Forms.TextBox UTextBox;
    }
}

