using Entity_Framework.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework.Context
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");
           
            builder.HasKey(d => d.IdDept);
           
            builder.Property(d => d.IdDept).UseIdentityColumn(10, 10);
           
            builder.Property(d => d.Name).IsRequired(true).HasMaxLength(50).IsUnicode(false);
           
            builder.Property(d => d.YearOfCreation).HasDefaultValue(DateTime.Now);
        }
    }
}
