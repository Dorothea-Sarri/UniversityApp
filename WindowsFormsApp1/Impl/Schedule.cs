using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl {
    public class Schedule : Entity {

        public List<Student> Students { get; set; }
        public Professor Professors { get; set; }
        public Course Courses { get; set; }
        public String Calendars { get; set; }
        public String Hour { get; set; }
        public Schedule() : base() {

        }
        public Schedule(List<Student> students, Course course, Professor professor, String calendar, String hour) : base() {
            Courses = course;
            Students = students;
            Professors = professor;
            Calendars = calendar;
            Hour = hour;
        }
    }
}
