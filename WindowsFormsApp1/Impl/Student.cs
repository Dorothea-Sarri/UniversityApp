using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl {
    public class Student : Person {

        public string RegistrationNumber { get; set; }
        public List<Course> coursesCanLearn { get; set; }
        public Student() : base() {

        }
        public Student(string name, string surname, string registrationNumber, int age, List<Course> canLearn) : base() {
            RegistrationNumber = registrationNumber;
            this.coursesCanLearn = canLearn;
        }
    }
}
