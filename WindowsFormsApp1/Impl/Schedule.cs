using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl {
   public class Schedule : Entity {

        public List<Student> Students { get; set; }/*  =new List<Student>(); */
        public Professor Professors { get; set; }
        public Course Courses { get; set; }
        public DateTime Calendars { get; set; }
        public Schedule( Course course, Professor professor, DateTime calendar) : base() {
            Courses = course;
          
            Professors = professor;
            Calendars = calendar;
        }
        public Schedule(List<Student> students , Course course, Professor professor, DateTime calendar) : base() {
            Courses = course;
            Students = students;
            Professors = professor;
            Calendars = calendar;
        }
    }
}
