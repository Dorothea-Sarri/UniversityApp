using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl {
    public class Person :Entity {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
      

        public Person() : base() {

        }
        public Person(string name, string surname, int age) : base() {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
          
            

        }
    }
}
