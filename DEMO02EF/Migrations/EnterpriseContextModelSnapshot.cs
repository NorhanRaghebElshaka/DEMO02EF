using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO02EF.Migrations
{
    [DbContext(typeof(EnterpriseContext))]
    partial class EnterpriseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF_Demo_Proj.Entities.Course", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Title")
                    .HasColumnType("nvarchar(max)");

                b.HasKey("ID");

                b.ToTable("Courses");
            });

            modelBuilder.Entity("EF_Demo_Proj.Entities.Department", b =>
            {
                b.Property<int>("DeptId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnType("varchar(50)");

                b.Property<DateTime>("YearOfCreation")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("datetime2")
                    .HasDefaultValue(new DateTime(2022, 2, 17, 14, 7, 0, 685, DateTimeKind.Local).AddTicks(2383));

                b.HasKey("DeptId");

                b.ToTable("Departments");
            });

            modelBuilder.Entity("EF_Demo_Proj.Entities.Employee", b =>
            {
                b.Property<int>("EmpId")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int?>("Age")
                    .HasColumnType("int");

                b.Property<int>("DepartmentDeptId")
                    .HasColumnType("int");

                b.Property<string>("EmailAdress")
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)");

                b.Property<decimal>("Salary")
                    .HasColumnType("money");

                b.HasKey("EmpId");

                b.HasIndex("DepartmentDeptId");

                b.ToTable("Employees");
            });

            modelBuilder.Entity("EF_Demo_Proj.Entities.Student", b =>
            {
                b.Property<int>("ID")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<int?>("Age")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.HasKey("ID");

                b.ToTable("Students");
            });

            modelBuilder.Entity("EF_Demo_Proj.Entities.StudentCourse", b =>
            {
                b.Property<int>("StudentID")
                    .HasColumnType("int");

                b.Property<int>("CourseID")
                    .HasColumnType("int");

                b.Property<int>("Grade")
                    .HasColumnType("int");

                b.HasKey("StudentID", "CourseID");

                b.HasIndex("CourseID");

                b.ToTable("StudentCourse");
            });

            modelBuilder.Entity("EF_Demo_Proj.Entities.Employee", b =>
            {
                b.HasOne("EF_Demo_Proj.Entities.Department", "Department")
                    .WithMany("Employees")
                    .HasForeignKey("DepartmentDeptId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Department");
            });

            modelBuilder.Entity("EF_Demo_Proj.Entities.StudentCourse", b =>
            {
                b.HasOne("EF_Demo_Proj.Entities.Course", null)
                    .WithMany("StudentCourses")
                    .HasForeignKey("CourseID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("EF_Demo_Proj.Entities.Student", null)
                    .WithMany("StudentCourses")
                    .HasForeignKey("StudentID")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();
            });

            modelBuilder.Entity("EF_Demo_Proj.Entities.Course", b =>
            {
                b.Navigation("StudentCourses");
            });

            modelBuilder.Entity("EF_Demo_Proj.Entities.Department", b =>
            {
                b.Navigation("Employees");
            });

            modelBuilder.Entity("EF_Demo_Proj.Entities.Student", b =>
            {
                b.Navigation("StudentCourses");
            });
#pragma warning restore 612, 618
        }
    }
}
