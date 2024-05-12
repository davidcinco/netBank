namespace netBank
{
    partial class Register
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
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            emailLabel = new Label();
            passwordLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            registerButton = new Button();
            ReturnButton = new Button();
            registrationTitleLabel = new Label();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.ForeColor = Color.White;
            firstNameLabel.Location = new Point(188, 92);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(129, 32);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.ForeColor = Color.White;
            lastNameLabel.Location = new Point(421, 92);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(126, 32);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.ForeColor = Color.White;
            emailLabel.Location = new Point(188, 170);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(71, 32);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(188, 247);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(111, 32);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.Location = new Point(188, 127);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(210, 33);
            firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(421, 127);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(210, 33);
            lastNameTextBox.TabIndex = 5;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(188, 205);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(443, 33);
            emailTextBox.TabIndex = 6;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(188, 282);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(210, 33);
            passwordTextBox.TabIndex = 7;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.LimeGreen;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(438, 336);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(193, 63);
            registerButton.TabIndex = 8;
            registerButton.Text = "Register";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // ReturnButton
            // 
            ReturnButton.BackColor = Color.DodgerBlue;
            ReturnButton.FlatAppearance.BorderSize = 0;
            ReturnButton.FlatStyle = FlatStyle.Flat;
            ReturnButton.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            ReturnButton.ForeColor = Color.White;
            ReturnButton.Location = new Point(188, 337);
            ReturnButton.Name = "ReturnButton";
            ReturnButton.Size = new Size(219, 62);
            ReturnButton.TabIndex = 9;
            ReturnButton.Text = "Already have an Account";
            ReturnButton.UseVisualStyleBackColor = false;
            ReturnButton.Click += ReturnButton_Click;
            // 
            // registrationTitleLabel
            // 
            registrationTitleLabel.AutoSize = true;
            registrationTitleLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            registrationTitleLabel.ForeColor = Color.White;
            registrationTitleLabel.Location = new Point(12, 9);
            registrationTitleLabel.Name = "registrationTitleLabel";
            registrationTitleLabel.Size = new Size(159, 37);
            registrationTitleLabel.TabIndex = 10;
            registrationTitleLabel.Text = "Registration";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(registrationTitleLabel);
            Controls.Add(ReturnButton);
            Controls.Add(registerButton);
            Controls.Add(passwordTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(emailLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label emailLabel;
        private Label passwordLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Button registerButton;
        private Button ReturnButton;
        private Label registrationTitleLabel;
    }
}