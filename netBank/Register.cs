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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;

            bool filledup = true;

            Dictionary<string, string> userData = new Dictionary<string, string>();
            userData.Add("firstName", firstName);
            userData.Add("lastName", lastName);
            userData.Add("email", email);
            userData.Add("password", password);

            foreach(KeyValuePair<string, string> pair in userData)
            {
                string value = pair.Value;
                if (value == "")
                {
                    Console.WriteLine("Need to fill up all the fields in the Register");
                    filledup = false;
                    break;
                }
            }

            if (filledup) {
                Console.WriteLine($"First Name: {firstName}\nLast Name: {lastName}\nEmail: {email}\nPassword: {password}");
            }

        }

    }
}
