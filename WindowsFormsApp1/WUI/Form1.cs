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
            button11.Hide();
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
                String x = ", ";
                Student Stud;

                List<String> v = new List<String>();

                for (int i = 0; i < StudentGridView1.SelectedRows.Count; i++) {
                    Stud = (Student)StudentGridView1.SelectedRows[i].DataBoundItem;
                    
                    v.Add(Stud.Name);
                }
                //MessageBox.Show(v.ToString()); 
                //StudentGridView1.SelectedRows.Count;
                Student student = (Student)StudentGridView1.CurrentRow.DataBoundItem;

                Professor professor = (Professor)ProfessorGridView.CurrentRow.DataBoundItem;
                DateTime Calendar = dateTimePicker2.Value;
                objects.Schedules.Add(new Schedule(course, professor, Calendar));


                //ScheduleGridView1.ColumnCount = 5;
                
                //ScheduleGridView1.Columns[0].Name = "Professor Name";
                //ScheduleGridView1.Columns[1].Name = "Professor Surname";
                //ScheduleGridView1.Columns[2].Name = "Professor Rank";
                //ScheduleGridView1.Columns[3].Name = "Cource Code";
                //ScheduleGridView1.Columns[4].Name = "Cource Subject";
                


                //string[] row = new string[] { professor.Name, professor.Surname, professor.Rank.ToString(),course.Code,course.Subject };
                //ScheduleGridView1.Rows.Add(row);

                string[] row = new string[] { professor.Name, course.Subject };
                ScheduleGridView1.Rows.Add(row);


                //////DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();
                //////col.DisplayMember = "Students Name";
                //////ScheduleGridView1.Columns.Add(col);
                
                //////col.DataSource = v;

                //DataGridViewButtonColumn but = new DataGridViewButtonColumn();
                //but.Text = "Show Student For This Course";
                //ScheduleGridView1.Columns.Add(but);
                
                
                
                
               // col.DataPropertyName = "userid";
               // col.ValueMember = "id";
                //ScheduleGridView1.Columns[5].Name = (col);
                
                //ScheduleGridView1.Rows.Add(DataGridViewComboBoxColumn)

                //ScheduleGridView1.Rows.Add("Professor Name", "Professor Surname", "Professor Rank", "Cource Code", "Cource Subject", "Students Names");
                //cheduleGridView1.Rows.Insert("Professor Name", "Professor Surname", "Professor Rank", "Cource Code", "Cource Subject", "Students Names");


                //addForm._MasterData = MasterData;
                //addForm.SqlConnectionAddForm = _SqlConnection;
                //addForm.ShowDialog();

                //gridControl1.MainView = gridLedger;





                //  }
                MessageBox.Show("all ok!");
            }
            catch {
                MessageBox.Show("error");
            }
            finally {

                MessageBox.Show(" ok!");
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
            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            string data = File.ReadAllText(path);

            string path1 = Path.Combine(Environment.CurrentDirectory, _JsonProfessorData);
            string data1 = File.ReadAllText(path1);
            string path2 = Path.Combine(Environment.CurrentDirectory, _JsonCourseData);
            string data2 = File.ReadAllText(path2);

            objects.Students = serializer.Deserialize<List<Student>>(data);
            objects.Professors = serializer1.Deserialize<List<Professor>>(data1);
            objects.Courses = serializer2.Deserialize<List<Course>>(data2);

       
        }
        private void button11_Click(object sender, EventArgs e) {

            DeserializeFromJson();

          
                StudentGridView1.DataSource = objects.Students;
           

         
                CourseGridView1.DataSource = objects.Courses;


            ProfessorGridView.DataSource = objects.Professors;
            //foreach (Professor cc1 in objects.Professors) {

            //  //list3.Items.Add(string.Format("{0}  {1}", cc1.Name, cc1.Surname));
            //    list3.Items.Add(cc1.ToString());
            //}

            //should run only once!
            button11.Hide();
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
              

            }
        }

        private void StudentGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}

