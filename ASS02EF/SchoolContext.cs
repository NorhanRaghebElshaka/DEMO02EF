using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS02EF
{
    
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Instructors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<Student>()
                .ToTable("Students")
                .HasKey(s => s.ID);

            modelBuilder.Entity<Student>()
                .HasOne(s => s.Department)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.Dep_Id);

            modelBuilder.Entity<Course>()
                .ToTable("Courses")
                .HasKey(c => c.ID);

            modelBuilder.Entity<Instructor>()
                .ToTable("Instructors")
                .HasKey(i => i.ID);

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.Dept_ID);

            modelBuilder.Entity<Stud_Course>()
                .ToTable("Stud_Courses")
                .HasKey(sc => new { sc.stud_ID, sc.Course_ID });

            modelBuilder.Entity<Course_Inst>()
                .ToTable("Course_Inst")
                .HasKey(ci => new { ci.inst_ID, ci.Course_ID });
        }
    }
}
