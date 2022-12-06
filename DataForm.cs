using CSharpLaba2.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLaba2
{
    public partial class DataForm : Form
    {
        private GradeDataContext database;
        private readonly String login;
        public DataForm(GradeDataContext database, String login)
        {
            this.database = database;
            this.login = login;
            InitializeComponent();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            database.Grades.Where(g => g.StudentLogin == login).Load();
            GradesGrid.DataSource = database.Grades.Local;
        }
    }
}
