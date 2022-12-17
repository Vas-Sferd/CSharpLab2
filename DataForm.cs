using CSharpLaba2.DataModel;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CSharpLaba2
{
    public partial class DataForm : Form
    {
        private static readonly string[] headers = { "\tКлюч", "\tЛогин", "\tОценка", "\tПредмет", "\tДата" };
        private EditGradeForm editForm = new EditGradeForm();
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
            GradesGrid.DataSource = database.Grades.Local.ToBindingList();
            for (int i = 0; i < GradesGrid.ColumnCount; ++i)
            {
                GradesGrid.Columns[i].HeaderText = headers[i];
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DialogResult res = editForm.ShowDialog();

            if (res != DialogResult.OK) 
            {
                return;
            }

            if (2 > editForm.SchoolMark || editForm.SchoolMark > 6 || editForm.SchoolSubject == "")
            {
                return;
            }

            Grade grade = new Grade(login, editForm.SchoolMark, editForm.SchoolSubject, editForm.DateWhenRated);
            database.Grades.Add(grade);
            database.SaveChanges();
            GradesGrid.Refresh();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (GradesGrid.SelectedRows.Count < 1)
            {
                return;
            }

            int index = GradesGrid.SelectedRows[0].Index;
            int id = Int32.Parse(GradesGrid[0, index].Value.ToString());

            Grade g = database.Grades.Find(id);
            editForm.SetData(g.SchoolMark, g.SchoolSubject, g.DateWhenRated);
            DialogResult res = editForm.ShowDialog();

            if (res != DialogResult.OK)
            {
                return;
            }

            if (2 > editForm.SchoolMark || editForm.SchoolMark > 6 || editForm.SchoolSubject == "")
            {
                return;
            }

            g.SchoolMark = editForm.SchoolMark;
            g.SchoolSubject = editForm.SchoolSubject;
            g.DateWhenRated = editForm.DateWhenRated;
            database.SaveChanges();
            GradesGrid.Refresh();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (GradesGrid.SelectedRows.Count < 1)
            {
                return;
            }

            int index = GradesGrid.SelectedRows[0].Index;
            int id = Int32.Parse(GradesGrid[0, index].Value.ToString());

            Grade g = database.Grades.Find(id);
            database.Grades.Remove(g);
            database.SaveChanges();
            GradesGrid.Refresh();
        }
    }
}
