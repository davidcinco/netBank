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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deposit deposit = new Deposit();
            deposit.Show();
        }

        private void transferButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transfer transfer = new Transfer();
            transfer.Show();
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
        }
    }
}
