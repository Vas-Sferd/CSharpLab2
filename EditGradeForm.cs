using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLaba2
{
    public partial class EditGradeForm : Form
    {
        public int SchoolMark { get => Int32.Parse(MarkComboBox.Text); private set => MarkComboBox.Text = value.ToString(); }
        public string SchoolSubject { get => SubjectComboBox.Text; private set => SubjectComboBox.Text = value; }
        public DateTime DateWhenRated { get => TimePicker.Value; private set => TimePicker.Value = value; }

        public EditGradeForm()
        {
            InitializeComponent();

            SchoolMark = 4;
            SchoolSubject = "";
            DateWhenRated = DateTime.Now;
        }

        public void SetData(int schoolMark, string schoolSubject, DateTime dateWhenRated)
        {
            SchoolMark = schoolMark;
            SchoolSubject = schoolSubject;
            DateWhenRated = dateWhenRated;
        }

        private void AddGradeForm_Load(object sender, EventArgs e)
        {
            OkButton.DialogResult = DialogResult.OK;
            CancelButton.DialogResult = DialogResult.Cancel;
        }
    }
}
