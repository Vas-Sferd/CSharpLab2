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
    public partial class MainForm : Form
    {
        private GradeDataContext database;
        public MainForm(GradeDataContext database)
        {
            this.database = database;
            InitializeComponent();
        }

        private void OpenDataForm(string login)
        {
            DataForm dataForm = new DataForm(database, login);
            dataForm.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Todo: delete this strings
            OpenDataForm("");
            return;
            // **/

            var passwords = from data in database.Users
                where data.Login == LoginTextBox.Text
                select data.Password;

            if (passwords.Any(p => p == PasswordTextBox.Text))
            {
                this.Hide();
                OpenDataForm(LoginTextBox.Text);
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
            CheckBox checkBox = sender as CheckBox;
            if (checkBox == null)
            {
                return;
            }

            if (checkBox.Checked)
            {
                PasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTextBox.PasswordChar = '*';
            }
        }
    }
}
