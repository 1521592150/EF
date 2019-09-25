using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace EF.Configer
{
    class StudentConfiger:EntityTypeConfiguration<Student>
    {
        public StudentConfiger()
        {
            this.ToTable("Student");
            this.HasKey(e => e.SID);
            this.Property(e => e.SName).HasMaxLength(20);
        }
    }
}
