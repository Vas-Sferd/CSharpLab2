using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLaba2.DataModel
{
    public class Grade
    {
        public Grade() { }
        public Grade(int id, string login, int schoolMark, string schoolSubject)
        {
            GradeId = id;
            StudentLogin = login;
            SchoolMark = schoolMark;
            SchoolSubject = schoolSubject;
        } 
        public int GradeId { get; set; }
        public string StudentLogin { get; set; }
        public int SchoolMark { get; set; }
        public string SchoolSubject { get; set; }
    }
}
