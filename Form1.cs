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
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var passwords = from data in database.Users
                where data.Login == LoginText.Text
                select data.Password;

            if (passwords.Any(p => p == PasswordText.Text))
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
            if (LoginText.Text != "" && PasswordText.Text != "")
            {
                database.Users.Add(new User(LoginText.Text, PasswordText.Text));
                database.SaveChanges();
            }
            else 
            {
                MessageBox.Show("Вы не ввели логин или пароль");
            }
        }
    }
}
