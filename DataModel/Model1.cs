using System;
using System.Data.Entity;
using System.Linq;

namespace CSharpLaba2.DataModel
{
    public class Model1 : DbContext
    {

        public Model1()
            : base("name=Model1")
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Grade> Products { get; set; }
    }
}