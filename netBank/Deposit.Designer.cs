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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
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
            depositAmountLabel.Location = new Point(183, 73);
            depositAmountLabel.Name = "depositAmountLabel";
            depositAmountLabel.Size = new Size(450, 32);
            depositAmountLabel.TabIndex = 1;
            depositAmountLabel.Text = "Type In the Amount you want to Deposit";
            // 
            // amountTextBox
            // 
            amountTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            amountTextBox.Location = new Point(267, 124);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(301, 50);
            amountTextBox.TabIndex = 2;
            amountTextBox.TextAlign = HorizontalAlignment.Center;
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
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(612, 213);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 43);
            textBox1.TabIndex = 5;
            textBox1.Text = "8000.38";
            textBox1.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(612, 277);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 43);
            textBox2.TabIndex = 6;
            textBox2.Text = "8000.38";
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // depositButton
            // 
            depositButton.BackColor = Color.LimeGreen;
            depositButton.FlatAppearance.BorderSize = 0;
            depositButton.FlatStyle = FlatStyle.Flat;
            depositButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            depositButton.ForeColor = Color.White;
            depositButton.Location = new Point(411, 371);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(157, 58);
            depositButton.TabIndex = 7;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Crimson;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(612, 371);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(157, 58);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // Deposit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelButton);
            Controls.Add(depositButton);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Button depositButton;
        private Button cancelButton;
    }
}