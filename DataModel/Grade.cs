using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Key]
        public int GradeId { get; set; }
        public string StudentLogin { get; set; }
        public int SchoolMark { get; set; }
        public string SchoolSubject { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DateWhenRated { get; set; }
    }
}
