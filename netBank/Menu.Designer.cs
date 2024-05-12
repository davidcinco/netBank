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
            menuLabel = new Label();
            SuspendLayout();
            // 
            // depositButton
            // 
            depositButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            depositButton.Location = new Point(43, 174);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(123, 32);
            depositButton.TabIndex = 0;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = true;
            // 
            // transferButton
            // 
            transferButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            transferButton.Location = new Point(251, 174);
            transferButton.Name = "transferButton";
            transferButton.Size = new Size(123, 32);
            transferButton.TabIndex = 1;
            transferButton.Text = "Transfer";
            transferButton.UseVisualStyleBackColor = true;
            // 
            // withdrawButton
            // 
            withdrawButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            withdrawButton.Location = new Point(454, 174);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(123, 32);
            withdrawButton.TabIndex = 2;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.FromArgb(255, 128, 128);
            logOutButton.FlatAppearance.BorderColor = Color.White;
            logOutButton.FlatAppearance.BorderSize = 0;
            logOutButton.FlatStyle = FlatStyle.Flat;
            logOutButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            logOutButton.Location = new Point(454, 376);
            logOutButton.Name = "logOutButton";
            logOutButton.Size = new Size(123, 32);
            logOutButton.TabIndex = 3;
            logOutButton.Text = "Log Out";
            logOutButton.UseVisualStyleBackColor = false;
            logOutButton.Click += logOutButton_Click;
            // 
            // menuLabel
            // 
            menuLabel.AutoSize = true;
            menuLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            menuLabel.Location = new Point(267, 22);
            menuLabel.Name = "menuLabel";
            menuLabel.Size = new Size(82, 32);
            menuLabel.TabIndex = 4;
            menuLabel.Text = "MENU";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 450);
            Controls.Add(menuLabel);
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
        private Label menuLabel;
    }
}