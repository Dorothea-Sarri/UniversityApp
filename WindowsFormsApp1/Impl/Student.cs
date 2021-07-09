using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl {
   public  class Student : Person {
      
        public string RegistrationNumber { get; set; }
        public List<CoursesCategoryEnum> CAN_LEARN { get; set; }
       
        public Student(string name, string surname, string registrationNumber, int age ) : base() {
                     
            RegistrationNumber = registrationNumber;

        }

    }
}
