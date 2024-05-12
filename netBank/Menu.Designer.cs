namespace netBank
{
    partial class Menu
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
            depositButton = new Button();
            transferButton = new Button();
            withdrawButton = new Button();
            logOutButton = new Button();
            WelcomeLabel = new Label();
            timeLabel = new Label();
            SuspendLayout();
            // 
            // depositButton
            // 
            depositButton.BackColor = Color.DodgerBlue;
            depositButton.FlatAppearance.BorderSize = 0;
            depositButton.FlatStyle = FlatStyle.Flat;
            depositButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            depositButton.ForeColor = Color.White;
            depositButton.Location = new Point(54, 174);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(139, 79);
            depositButton.TabIndex = 0;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = false;
            depositButton.Click += depositButton_Click;
            // 
            // transferButton
            // 
            transferButton.BackColor = Color.Salmon;
            transferButton.FlatAppearance.BorderSize = 0;
            transferButton.FlatStyle = FlatStyle.Flat;
            transferButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            transferButton.ForeColor = Color.White;
            transferButton.Location = new Point(258, 174);
            transferButton.Name = "transferButton";
            transferButton.Size = new Size(139, 79);
            transferButton.TabIndex = 1;
            transferButton.Text = "Transfer";
            transferButton.UseVisualStyleBackColor = false;
            transferButton.Click += transferButton_Click;
            // 
            // withdrawButton
            // 
            withdrawButton.BackColor = Color.MediumSeaGreen;
            withdrawButton.FlatAppearance.BorderSize = 0;
            withdrawButton.FlatStyle = FlatStyle.Flat;
            withdrawButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            withdrawButton.ForeColor = Color.White;
            withdrawButton.Location = new Point(454, 174);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(139, 79);
            withdrawButton.TabIndex = 2;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = false;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.FromArgb(192, 0, 0);
            logOutButton.FlatAppearance.BorderColor = Color.White;
            logOutButton.FlatAppearance.BorderSize = 0;
            logOutButton.FlatStyle = FlatStyle.Flat;
            logOutButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            logOutButton.ForeColor = Color.White;
            logOutButton.Location = new Point(454, 376);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(123, 32);
            logOutButton.TabIndex = 3;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            WelcomeLabel.ForeColor = Color.White;
            WelcomeLabel.Location = new Point(12, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(167, 32);
            WelcomeLabel.TabIndex = 4;
            WelcomeLabel.Text = "Welcome User";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            timeLabel.ForeColor = Color.White;
            timeLabel.Location = new Point(493, 20);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(122, 21);
            timeLabel.TabIndex = 5;
            timeLabel.Text = "--/--/-- 00:00:00";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(627, 450);
            Controls.Add(timeLabel);
            Controls.Add(WelcomeLabel);
            Controls.Add(logOutButton);
            Controls.Add(withdrawButton);
            Controls.Add(transferButton);
            Controls.Add(depositButton);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button depositButton;
        private Button transferButton;
        private Button withdrawButton;
        private Button logOutButton;
        private Label WelcomeLabel;
        private Label timeLabel;
    }
}