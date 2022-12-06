using CSharpLaba2.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLaba2
{
    public partial class Form1 : Form
    {
        private Model1 database;
        public Form1(Model1 database)
        {
            this.database = database;
            InitializeComponent();
            LoginTextBox.Text = "" + LoginTextBox.PasswordChar;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var passwords = from data in database.Users
                where data.Login == LoginTextBox.Text
                select data.Password;

            if (passwords.Any(p => p == PasswordTextBox.Text))
            {
                MessageBox.Show("Вы вошли");
            }
            else
            {
                MessageBox.Show("Вас сюда не звали");
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                database.Users.Add(new User(LoginTextBox.Text, PasswordTextBox.Text));
                database.SaveChanges();
            }
            else 
            {
                MessageBox.Show("Вы не ввели логин или пароль");
            }
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox checkBox = (CheckBox)sender;
                if (checkBox.Checked)
                {
                    PasswordTextBox.PasswordChar = '\0';
                }
                else
                {
                    PasswordTextBox.PasswordChar = '*';
                }
            }
            catch
            {

            }
        }
    }
}
