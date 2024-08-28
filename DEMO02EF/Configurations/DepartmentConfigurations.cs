using DEMO02EF.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO02EF.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(D => D.DeptId);
            builder.Property(D => D.DeptId).UseIdentityColumn(seed: 100, increment: 100);
            builder.Property(D => D.Name).HasColumnName("DepartmentName")
                .HasColumnType("varchar")
                .HasMaxLength(100);
        }
    }
}
