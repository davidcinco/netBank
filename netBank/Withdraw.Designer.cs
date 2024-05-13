namespace netBank
{
    partial class Withdraw
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
            withdrawLabel = new Label();
            withdrawMessageLabel = new Label();
            withdrawtextBox = new TextBox();
            currentBalanceLabel = new Label();
            balanceLeftLabel = new Label();
            currenttextBox = new TextBox();
            lefttextBox = new TextBox();
            withdrawButton = new Button();
            cancelButton = new Button();
            withdrawBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // withdrawLabel
            // 
            withdrawLabel.AutoSize = true;
            withdrawLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            withdrawLabel.ForeColor = Color.White;
            withdrawLabel.Location = new Point(12, 9);
            withdrawLabel.Name = "withdrawLabel";
            withdrawLabel.Size = new Size(132, 37);
            withdrawLabel.TabIndex = 0;
            withdrawLabel.Text = "Withdraw";
            // 
            // withdrawMessageLabel
            // 
            withdrawMessageLabel.AutoSize = true;
            withdrawMessageLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            withdrawMessageLabel.ForeColor = Color.White;
            withdrawMessageLabel.Location = new Point(165, 73);
            withdrawMessageLabel.Name = "withdrawMessageLabel";
            withdrawMessageLabel.Size = new Size(469, 32);
            withdrawMessageLabel.TabIndex = 1;
            withdrawMessageLabel.Text = "Type In the Amount you want to Withdraw";
            // 
            // withdrawtextBox
            // 
            withdrawtextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            withdrawtextBox.Location = new Point(245, 119);
            withdrawtextBox.Name = "withdrawtextBox";
            withdrawtextBox.Size = new Size(303, 50);
            withdrawtextBox.TabIndex = 2;
            withdrawtextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // currentBalanceLabel
            // 
            currentBalanceLabel.AutoSize = true;
            currentBalanceLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            currentBalanceLabel.ForeColor = Color.White;
            currentBalanceLabel.Location = new Point(431, 217);
            currentBalanceLabel.Name = "currentBalanceLabel";
            currentBalanceLabel.Size = new Size(188, 32);
            currentBalanceLabel.TabIndex = 3;
            currentBalanceLabel.Text = "Current Balance:";
            // 
            // balanceLeftLabel
            // 
            balanceLeftLabel.AutoSize = true;
            balanceLeftLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            balanceLeftLabel.ForeColor = Color.White;
            balanceLeftLabel.Location = new Point(471, 272);
            balanceLeftLabel.Name = "balanceLeftLabel";
            balanceLeftLabel.Size = new Size(148, 32);
            balanceLeftLabel.TabIndex = 4;
            balanceLeftLabel.Text = "Balance Left:";
            // 
            // currenttextBox
            // 
            currenttextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            currenttextBox.Location = new Point(625, 217);
            currenttextBox.Name = "currenttextBox";
            currenttextBox.Size = new Size(144, 43);
            currenttextBox.TabIndex = 5;
            currenttextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // lefttextBox
            // 
            lefttextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lefttextBox.Location = new Point(625, 272);
            lefttextBox.Name = "lefttextBox";
            lefttextBox.Size = new Size(144, 43);
            lefttextBox.TabIndex = 6;
            lefttextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // withdrawButton
            // 
            withdrawButton.BackColor = Color.LimeGreen;
            withdrawButton.FlatAppearance.BorderSize = 0;
            withdrawButton.FlatStyle = FlatStyle.Flat;
            withdrawButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            withdrawButton.ForeColor = Color.White;
            withdrawButton.Location = new Point(333, 358);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(185, 80);
            withdrawButton.TabIndex = 7;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Crimson;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(584, 358);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(185, 80);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // withdrawBtn
            // 
            withdrawBtn.BackColor = Color.LimeGreen;
            withdrawBtn.FlatAppearance.BorderSize = 0;
            withdrawBtn.FlatStyle = FlatStyle.Flat;
            withdrawBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            withdrawBtn.ForeColor = Color.White;
            withdrawBtn.Location = new Point(333, 356);
            withdrawBtn.Name = "withdrawBtn";
            withdrawBtn.Size = new Size(185, 80);
            withdrawBtn.TabIndex = 7;
            withdrawBtn.Text = "Withdraw";
            withdrawBtn.UseVisualStyleBackColor = false;
            withdrawBtn.Click += withdrawBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Crimson;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.ForeColor = Color.White;
            cancelBtn.Location = new Point(584, 356);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(185, 80);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // Withdraw
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelBtn);
            Controls.Add(cancelButton);
            Controls.Add(withdrawBtn);
            Controls.Add(withdrawButton);
            Controls.Add(lefttextBox);
            Controls.Add(currenttextBox);
            Controls.Add(balanceLeftLabel);
            Controls.Add(currentBalanceLabel);
            Controls.Add(withdrawtextBox);
            Controls.Add(withdrawMessageLabel);
            Controls.Add(withdrawLabel);
            Name = "Withdraw";
            Text = "Withdraw";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label withdrawLabel;
        private Label withdrawMessageLabel;
        private TextBox withdrawtextBox;
        private Label currentBalanceLabel;
        private Label balanceLeftLabel;
        private TextBox currenttextBox;
        private TextBox lefttextBox;
        private Button withdrawButton;
        private Button cancelButton;
        private Button withdrawBtn;
        private Button cancelBtn;
    }
}