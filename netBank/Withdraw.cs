using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace netBank
{
    public partial class Withdraw : Form
    {
        private float balance = 3432.49f;
        public Withdraw()
        {
            InitializeComponent();
            currenttextBox.Text = Balance.ToString();
        }

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }



        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"BALANCE BEFORE {Balance}");
            float amount = float.Parse(withdrawtextBox.Text);
            Balance = (Balance - amount);
            Console.WriteLine($"BALANCE AFTER {Balance}");
        }

        private void withdrawtextBox_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"Se cambio {withdrawtextBox.Text}");
            float total = (Balance - float.Parse(withdrawtextBox.Text));
            lefttextBox.Text = total.ToString();
            
        }
    }
}
