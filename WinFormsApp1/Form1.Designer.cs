namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(118, 12);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(311, 418);
            this.checkedListBox.TabIndex = 0;
            // 
            // SignIn
            // 
            this.SignIn.Location = new System.Drawing.Point(12, 122);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(100, 23);
            this.SignIn.TabIndex = 1;
            this.SignIn.Text = "Войти";
            this.SignIn.UseVisualStyleBackColor = true;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Location = new System.Drawing.Point(12, 31);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(17, 15);
            this.Id.TabIndex = 2;
            this.Id.Text = "Id";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(12, 49);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 23);
            this.IdTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(12, 93);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 23);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(12, 75);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(49, 15);
            this.Password.TabIndex = 4;
            this.Password.Text = "Пароль";
            // 
            // SignUp
            // 
            this.SignUp.Location = new System.Drawing.Point(12, 151);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(100, 23);
            this.SignUp.TabIndex = 6;
            this.SignUp.Text = "Зарегистрироваться";
            this.SignUp.UseVisualStyleBackColor = true;
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.checkedListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button SignUp;
    }
}
