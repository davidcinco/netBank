﻿using System;
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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void amountTextBox_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"Se cambio {amountTextBox.Text}");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {

        }
    }
}
