using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Impl {

    public class University  {

        public List<Student> Students { get; set; }
        public List<Professor> Professors { get; set; }
        public List<Schedule> Schedules { get; set; }
        public List<Course> Courses { get; set; }


        public University() {
            Students = new List<Student>();
            Professors = new List<Professor>();
            Courses = new List<Course>();
            Schedules = new List<Schedule>();
        }



        public void run_once() {


            // TODO: MUST IMPLEMENT ENUMERATION FOR CATEGORY ?

            Courses.Add(new Course() {
                //id = "1", 
                Code = "1",
                Subject = "Quantum Physics",
                Category = 0, // physics
                Hours = 100
            });

            Courses.Add(new Course() {
                //id = "2",
                Code = "2",
                Subject = "Electo-Dynamics",
                Category = 0, // physics ?
                Hours = 50
            });

            Courses.Add(new Course() {
                //id = "3",
                Code = "03",
                Subject = "Basic Chemistry",
                Category = (CoursesCategoryEnum)1, // Chemistry
                Hours = 50
            });

            Courses.Add(new Course() {
                //id = "4",
                Code = "04",
                Subject = "Financial II",
                Category = (CoursesCategoryEnum)2, // Financial
                Hours = 50
            });

            Courses.Add(new Course() {
                //id = "5",
                Code = "5",
                Subject = "Mathematics I",
                Category = (CoursesCategoryEnum)3, // Mathematics
                Hours = 50
            });

            Students.Add(new Student("Fotis", "Chrysoulas", "1234", 18) {
                //id = Guid.NewGuid(),

                //Name = "Fotis",
                //Surname = "Chrysoulas",
                //RegistrationNumber = "1234",
                CAN_LEARN = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Chemistry, CoursesCategoryEnum.Financial }
            });


            Students.Add(new Student("Dimitris", "Raptodimos", "1235", 19) { 
         
             CAN_LEARN = new List<CoursesCategoryEnum>() { CoursesCategoryEnum.Physics, CoursesCategoryEnum.Financial } 
          });

            Professors.Add(new Professor("Maria", "Papadopoulou", 45, (ProfessorCategoryEnum)1) {
                //Name = "Maria",
                //Surname = "Papadopoulou",
                //Rank = (ProfessorCategoryEnum) 1
            });


        }

       
    }


   
  

}

