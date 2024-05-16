using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace netBank
{
    public partial class Deposit : Form
    {
        private float balance = 3432.49f;

        public Deposit()
        {
            InitializeComponent();
            currenttextBox.Text = Balance.ToString();
        }
        public float Balance
        {
            get{ return balance ;}
            set { balance = value ; }
        }
        

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            float total = (Balance + float.Parse(amountTextBox.Text));
            totaltextBox.Text = total.ToString();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"BALANCE BEFORE {Balance}");
            float amount = float.Parse(amountTextBox.Text);
            Balance = (Balance + amount);
            Console.WriteLine($"BALANCE AFTER {Balance}");

        }
    }
}
