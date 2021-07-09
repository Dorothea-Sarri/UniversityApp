using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl {
   public class Schedule : Entity {

        public List<Student> Students { get; set; }
        public Professor Professor { get; set; }
        public Course Course { get; set; }
        public DateTime Calendar { get; set; }
        public Schedule(List<Student> students, Professor professor, Course course, DateTime calendar) : base() {
            Students = students;
            Professor = professor;
            Course = course;
            Calendar = calendar;
        }
    }
}
