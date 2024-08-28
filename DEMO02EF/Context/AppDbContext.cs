using DEMO02EF.Configurations;
using DEMO02EF.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DEMO02EF.Context
{
    internal class AppDbContext : DbContext
    {





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// modelBuilder.Entity<Employee>().HasKey("Id");
            //// modelBuilder.Entity<Employee>().HasKey(E => E.Id);
            //// modelBuilder.Entity<Employee>().HasKey(name => nameof(Employee.Id));

            //modelBuilder.Entity<Employee>()
            //    .HasKey(E => E.Id);

            //modelBuilder.Entity<Employee>()
            //    .Property(E => E.Name)
            //    // .HasColumnName("EmployeeName")
            //    // .HasColumnType("varchar")
            //    // .HasMaxLength(50)
            //    .IsRequired();


            modelBuilder.ApplyConfiguration(new EmployeeConfigurations());
            modelBuilder.ApplyConfiguration(new DepartmentConfigurations());

            // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



            //code to conext database
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Employee> Employee  { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
