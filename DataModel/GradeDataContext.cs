using System;
using System.Data.Entity;
using System.Linq;

namespace CSharpLaba2.DataModel
{
    public class GradeDataContext : DbContext
    {

        public GradeDataContext()
            : base("name=GradeDataContext")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}