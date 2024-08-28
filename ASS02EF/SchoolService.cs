using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS02EF
{
    public class SchoolService
    {
        private readonly SchoolContext _context;

        public SchoolService(SchoolContext context)
        {
            _context = context;
        }

        public void PerformCRUDOperations()
        {
            var studentRepo = new Repository<Student>(_context);
            var courseRepo = new Repository<Course>(_context);
           
            studentRepo.Add(new Student { FName = "John", LName = "Doe", Address = "123 St", Age = 20, Dep_Id = 1 });

            // Read
            var students = studentRepo.GetAll();

            // Update
            var student = studentRepo.GetById(1);
            student.Address = "456 St";
            studentRepo.Update(student);

            // Delete
            studentRepo.Delete(1);
        }
    }
}
