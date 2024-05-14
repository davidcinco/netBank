namespace netBank
{
    partial class Deposit
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
            depositLabel = new Label();
            depositAmountLabel = new Label();
            amountTextBox = new TextBox();
            balanceLabel = new Label();
            totalLabel = new Label();
            currenttextBox = new TextBox();
            totaltextBox = new TextBox();
            depositButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // depositLabel
            // 
            depositLabel.AutoSize = true;
            depositLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            depositLabel.ForeColor = Color.White;
            depositLabel.Location = new Point(12, 9);
            depositLabel.Name = "depositLabel";
            depositLabel.Size = new Size(109, 37);
            depositLabel.TabIndex = 0;
            depositLabel.Text = "Deposit";
            // 
            // depositAmountLabel
            // 
            depositAmountLabel.AutoSize = true;
            depositAmountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            depositAmountLabel.ForeColor = Color.White;
            depositAmountLabel.Location = new Point(161, 74);
            depositAmountLabel.Name = "depositAmountLabel";
            depositAmountLabel.Size = new Size(450, 32);
            depositAmountLabel.TabIndex = 1;
            depositAmountLabel.Text = "Type In the Amount you want to Deposit";
            // 
            // amountTextBox
            // 
            amountTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            amountTextBox.Location = new Point(250, 124);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(301, 50);
            amountTextBox.TabIndex = 2;
            amountTextBox.TextAlign = HorizontalAlignment.Center;
            amountTextBox.TextChanged += amountTextBox_TextChanged;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            balanceLabel.ForeColor = Color.White;
            balanceLabel.Location = new Point(423, 221);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(188, 32);
            balanceLabel.TabIndex = 3;
            balanceLabel.Text = "Current Balance:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            totalLabel.ForeColor = Color.White;
            totalLabel.Location = new Point(536, 284);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(70, 32);
            totalLabel.TabIndex = 4;
            totalLabel.Text = "Total:";
            // 
            // currenttextBox
            // 
            currenttextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            currenttextBox.Location = new Point(612, 213);
            currenttextBox.Name = "currenttextBox";
            currenttextBox.ReadOnly = true;
            currenttextBox.Size = new Size(157, 43);
            currenttextBox.TabIndex = 5;
            currenttextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // totaltextBox
            // 
            totaltextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            totaltextBox.Location = new Point(612, 277);
            totaltextBox.Name = "totaltextBox";
            totaltextBox.ReadOnly = true;
            totaltextBox.Size = new Size(157, 43);
            totaltextBox.TabIndex = 6;
            totaltextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // depositButton
            // 
            depositButton.BackColor = Color.LimeGreen;
            depositButton.FlatAppearance.BorderSize = 0;
            depositButton.FlatStyle = FlatStyle.Flat;
            depositButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            depositButton.ForeColor = Color.White;
            depositButton.Location = new Point(326, 352);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(185, 80);
            depositButton.TabIndex = 7;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = false;
            depositButton.Click += depositButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Crimson;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(584, 352);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(185, 80);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelButton);
            Controls.Add(depositButton);
            Controls.Add(totaltextBox);
            Controls.Add(currenttextBox);
            Controls.Add(totalLabel);
            Controls.Add(balanceLabel);
            Controls.Add(amountTextBox);
            Controls.Add(depositAmountLabel);
            Controls.Add(depositLabel);
            Name = "Deposit";
            Text = "Deposit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label depositLabel;
        private Label depositAmountLabel;
        private TextBox amountTextBox;
        private Label balanceLabel;
        private Label totalLabel;
        private TextBox currenttextBox;
        private TextBox totaltextBox;
        private Button depositButton;
        private Button cancelButton;
    }
}