namespace CSharpLaba2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Password = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Label();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Password.Location = new System.Drawing.Point(77, 101);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 0;
            this.Password.Text = "Password";
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Cursor = System.Windows.Forms.Cursors.Default;
            this.Login.Location = new System.Drawing.Point(77, 68);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(33, 13);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(146, 65);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(227, 20);
            this.LoginText.TabIndex = 2;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LoginButton.Location = new System.Drawing.Point(379, 222);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login in";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RegisterButton.Location = new System.Drawing.Point(298, 222);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 23);
            this.RegisterButton.TabIndex = 5;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(146, 98);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.PasswordChar = '*';
            this.PasswordText.Size = new System.Drawing.Size(227, 20);
            this.PasswordText.TabIndex = 3;
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(380, 101);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(75, 17);
            this.ShowPasswordCheckBox.TabIndex = 6;
            this.ShowPasswordCheckBox.Text = "Показать";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 268);
            this.Controls.Add(this.ShowPasswordCheckBox);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Password);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
    }
}

