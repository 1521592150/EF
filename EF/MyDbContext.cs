using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Configer;
using System.Reflection;
using System.Data.Entity;
namespace EF
{
    public class MyDbContext : DbContext
    {
        public MyDbContext():base("sql")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
        public DbSet<Student> Student { get; set; }
    }
}
