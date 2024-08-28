using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASS02EF
{
    internal class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }
        public ICollection<Stud_Course> Stud_Courses { get; set; } 
        public ICollection<Course_Inst> Course_Instructors { get; set; }
    }
}
