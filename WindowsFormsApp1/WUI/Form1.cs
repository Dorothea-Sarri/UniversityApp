using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;

namespace WindowsFormsApp1.WUI {

    public partial class DataForm1 : Form {

        private University objects = new University();
        private const string _JsonFile = "StudentData.json";
        private const string _JsonProfessorData = "ProfessorData.json";
        private const string _JsonCourseData = "CourseData.json";
        private const string _JsonScheduleData = "SchedulesData.json";
        List<Student> Students = new List<Student>();
        public DataForm1() {
            InitializeComponent();
        }

        #region old code
        //private void DataForm_Load(object sender, EventArgs e) {

        //    // todo : load data on enter!
        //}
        //KALEI TO KOUMPI LOAD APO TO MENU 
        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e) {

        //    //JavaScriptSerializer r = new JavaScriptSerializer();

        //    //objects = r.Deserialize<University>(File.ReadAllText("Data.json"));

        //    foreach (Student a in objects.Students) {
        //        list1.Items.Add(a.Name + " " + a.Surname);
        //    }

        //    for (int i = 0; i < objects.Courses.Count - 1; i++) {

        //        listBox1.Items.Add(objects.Courses[i].Code + "--" + objects.Courses[i].Subject);
        //    }


        //    foreach (Professor k in objects.Professors) {
        //        list3.Items.Add(string.Format("{0}  {1}", k.Name, k.Surname));
        //    }
        }
        //KOUMPI SAVE APO TO MENU
        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e) {
            //JavaScriptSerializer save_Serializer = new JavaScriptSerializer();

            //File.WriteAllText("Data.json", save_Serializer.Serialize(objects));
        }
        #endregion

        #region new code
        private void DataForm1_Load(object sender, EventArgs e) {
            DeserializeFromJson();

            StudentGridView1.DataSource = objects.Students;



            CourseGridView1.DataSource = objects.Courses;


            ProfessorGridView.DataSource = objects.Professors;

            foreach (Schedule for_schedule in objects.Schedules) {
                string[] row = new string[] { for_schedule.Professors.Name + for_schedule.Professors.Surname, for_schedule.Professors.Rank.ToString(), for_schedule.Courses.Code, for_schedule.Courses.Subject };
                ScheduleGridView1.Rows.Add(row);
            }
            
            //ScheduleGridView1.DataSource = objects.Schedules;
            // todo : load data on enter!

        }

        private void initializeDedomenaToolStripMenuItem_Click(object sender, EventArgs e) {

          

            foreach (Student a in objects.Students) {
               // list1.Items.Add(a.Name + " " + a.Surname);
            }

            foreach (Course bb in objects.Courses) {
             //   listBox1.Items.Add(bb.Code + "--" + bb.Subject);
            }


            foreach (Professor cc1 in objects.Professors) {

             //   list3.Items.Add(string.Format("{0}  {1}", cc1.Name, cc1.Surname));
            }

            //should run only once!
       
        }

        private void button9_Click(object sender, EventArgs e) {

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            string data = File.ReadAllText(path);

            objects.Schedules = serializer.Deserialize<List<Schedule>>(data);

            foreach (Schedule cc1 in objects.Schedules) {
                foreach (Student a in objects.Students) {
                   // ctrlSchedule.Items.Add(a.Name + " " + a.Surname );
            }
            }
            for (int i = 0; i < objects.Schedules.Count - 1; i++) {

              //  ctrlSchedule.Items.Add(objects.Schedules[i].Courses.Subject + "--" + objects.Schedules[i].Courses.Code);
            }

            // we do a loop
            foreach (Schedule cc1 in objects.Schedules) {
                // we add to the list
              //  ctrlSchedule.Items.Add(string.Format("{0}  {1}", cc1.Professors.Name, cc1.Professors.Surname));
            }

        }

        private void button10_Click(object sender, EventArgs e) {
            JavaScriptSerializer ff = new JavaScriptSerializer();

            File.WriteAllText("SchedulesData.json", ff.Serialize(objects.Schedules));
        }

        private void ctrlExit_Click(object sender, EventArgs e) {
            try {

                // TODO: 1. CANNOT ADD SAME STUDENT + PROFESSOR IN SAME DATE & HOUR

                // TODO: 2. EACH STUDENT CANNOT HAVE MORE THAN 3 COURSES PER DAY!

                // TODO: 3. A PROFESSOR CANNOT TEACH MORE THAN 4 COURSES PER DAY AND 40 COURSES PER WEEK
                //ctrlSchedule.Items.Clear();
                Course course = (Course)CourseGridView1.CurrentRow.DataBoundItem;
                Student Stud;
                for (int i = 0; i < StudentGridView1.SelectedRows.Count; i++) 
                {
                    Stud = (Student)StudentGridView1.SelectedRows[i].DataBoundItem;
                    Students.Add(Stud);
                }
                Student student = (Student)StudentGridView1.CurrentRow.DataBoundItem;

                Professor professor = (Professor)ProfessorGridView.CurrentRow.DataBoundItem;
                DateTime Calendar = dateTimePicker2.Value;
                objects.Schedules.Add(new Schedule(Students, course, professor, Calendar));

                string[] row = new string[] { professor.Name + professor.Surname, professor.Rank.ToString(),course.Code ,course.Subject };
                ScheduleGridView1.Rows.Add(row);

                
                
                
            }
            catch {
                MessageBox.Show("error");
            }       
        }

        public void validate_professorCourse_with_studentCourse() { 
        
            //TODO: ???

        }
        public void Valid() {

           
        }
        #endregion
        private void DeserializeFromJson() {

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            JavaScriptSerializer serializer1 = new JavaScriptSerializer();
            JavaScriptSerializer serializer2 = new JavaScriptSerializer();
            JavaScriptSerializer serializer3 = new JavaScriptSerializer();
            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            string data = File.ReadAllText(path);

            string path1 = Path.Combine(Environment.CurrentDirectory, _JsonProfessorData);
            string data1 = File.ReadAllText(path1);

            string path2 = Path.Combine(Environment.CurrentDirectory, _JsonCourseData);
            string data2 = File.ReadAllText(path2);

            string path3 = Path.Combine(Environment.CurrentDirectory, _JsonScheduleData);
            string data3 = File.ReadAllText(path3);

            objects.Students = serializer.Deserialize<List<Student>>(data);
            objects.Professors = serializer1.Deserialize<List<Professor>>(data1);
            objects.Courses = serializer2.Deserialize<List<Course>>(data2);
            objects.Schedules = serializer3.Deserialize<List<Schedule>>(data3);


        }
        

        private void addToScheduleToolStripMenuItem_Click(object sender, EventArgs e) {

            // todo : display on a grid??

            // todo: add exception handling?
                //objects.Schedules.Add(new Schedule() { 
                //    Course = listBox1.SelectedItem.ToString(), Student = list1.SelectedItem.ToString()
                //        , Professor = list3.SelectedItem.ToString(), Calendar = dateTimePicker2.Value });

                //ctrlSchedule.Items.Clear();
                //foreach (var AA in objects.Schedules) {

                //    ctrlSchedule.Items.Add(
                //        AA.Calendar + " " + 
                //        AA.Course + " " + 
                //        AA.Student + " " + 
                //        AA.Professor);

                //}
        
        }

        private void button8_Click(object sender, EventArgs e) {

        }

        private void ctrlSchedule_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void ScheduleGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if(ScheduleGridView1.Columns[e.ColumnIndex].Name=="StudentList") {

                StudentForm form = new StudentForm(Students);

                form.Show();

            }
        }

        private void StudentGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}

