using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApp1.Impl {

    public class Course : Entity {

        public string Code { get; set; }
        public string Subject { get; set; }
        public float Hours { get; set; }
        public CoursesCategoryEnum Category { get; set; }
        public Course() : base() {
        }
        public Course(string code, string subject, float hours, CoursesCategoryEnum category) : base() {
            Code = code;
            Subject = subject;
            Hours = hours;
            Category = category;

        }
    }
}
