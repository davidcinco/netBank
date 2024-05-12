namespace netBank
{
    partial class SignIn
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
            signInButton = new Button();
            emailLabel = new Label();
            passwordLabel = new Label();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            registerButton = new Button();
            title = new Label();
            SuspendLayout();
            // 
            // signInButton
            // 
            signInButton.BackColor = Color.DodgerBlue;
            signInButton.FlatAppearance.BorderSize = 0;
            signInButton.FlatStyle = FlatStyle.Flat;
            signInButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            signInButton.ForeColor = Color.White;
            signInButton.Location = new Point(94, 287);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(89, 34);
            signInButton.TabIndex = 0;
            signInButton.Text = "Sign In";
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += button1_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(94, 97);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(63, 30);
            emailLabel.TabIndex = 1;
            emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(94, 183);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(99, 30);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(94, 130);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(189, 33);
            emailTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(94, 216);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(189, 33);
            passwordTextBox.TabIndex = 4;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(128, 128, 255);
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(194, 287);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(89, 34);
            registerButton.TabIndex = 5;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            title.ForeColor = Color.White;
            title.Location = new Point(134, 31);
            title.Name = "title";
            title.Size = new Size(105, 32);
            title.TabIndex = 6;
            title.Text = "NetBank";
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(386, 408);
            Controls.Add(title);
            Controls.Add(registerButton);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Controls.Add(signInButton);
            Name = "SignIn";
            Text = "NetBank - Sign In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signInButton;
        private Label emailLabel;
        private Label passwordLabel;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Button registerButton;
        private Label title;
    }
}