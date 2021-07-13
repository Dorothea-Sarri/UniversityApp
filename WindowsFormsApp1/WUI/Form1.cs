using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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

        

        #region new code
        private void DataForm1_Load(object sender, EventArgs e) {
            DeserializeFromJson();
            LoadGridViews();



        }
        private void LoadGridViews() {


            StudentGridView1.DataSource = objects.Students;
            CourseGridView1.DataSource = objects.Courses;
            ProfessorGridView.DataSource = objects.Professors;

            foreach (Schedule for_schedule in objects.Schedules) {
                string[] row = new string[] { for_schedule.Courses.Code, for_schedule.Courses.Subject, for_schedule.Calendars, for_schedule.Hour, for_schedule.Professors.Name + for_schedule.Professors.Surname, for_schedule.Professors.Rank.ToString(), for_schedule.ID.ToString() };
                ScheduleGridView1.Rows.Add(row);
            }
        }
        private void initializeDedomenaToolStripMenuItem_Click(object sender, EventArgs e) {

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
            SaveSchedule();
        }
        private void SaveSchedule() {
            JavaScriptSerializer ff = new JavaScriptSerializer();
            JavaScriptSerializer ProfessorSerializer = new JavaScriptSerializer();
            JavaScriptSerializer StudentSerializer = new JavaScriptSerializer();
            JavaScriptSerializer CourseSerializer = new JavaScriptSerializer();

            File.WriteAllText("SchedulesData.json", ff.Serialize(objects.Schedules));
            File.WriteAllText("ProfessorData.json", ProfessorSerializer.Serialize(objects.Professors));
            File.WriteAllText("StudentData.json", StudentSerializer.Serialize(objects.Students));
            File.WriteAllText("CourseData.json", CourseSerializer.Serialize(objects.Courses));

        }
        private bool DatesAreInTheSameWeek(DateTime date1, DateTime date2) {
            //Check 2 date if have the same first day of the week
            var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
            var d1 = date1.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date1));
            var d2 = date2.Date.AddDays(-1 * (int)cal.GetDayOfWeek(date2));

            return d1 == d2;
        }
        private Boolean ProfessorCheck(List<Schedule> schedule, Professor professor, String Calendar, String hour) {
            int lessons_per_day_hour = 0;
            int lessons_per_day = 0;
            int lessons_per_week = 0;


            DateTime dt = Convert.ToDateTime(Calendar);
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(dt);
            for (int i = 0; i < schedule.Count; i++) {
                if (professor.ID == schedule[i].Professors.ID && (Calendar == objects.Schedules[i].Calendars && hour == objects.Schedules[i].Hour)) {
                    lessons_per_day_hour++;
                }
                else if (professor.ID == schedule[i].Professors.ID && Calendar == objects.Schedules[i].Calendars) {
                    lessons_per_day++;
                }

                if (professor.ID == schedule[i].Professors.ID && DatesAreInTheSameWeek(dt, Convert.ToDateTime(objects.Schedules[i].Calendars))) {
                    lessons_per_week++;
                }
            }
            for (int i = 0; i < schedule.Count; i++) {
                if ((professor.ID == schedule[i].Professors.ID && lessons_per_day_hour < 1) || ((professor.ID != schedule[i].Professors.ID && lessons_per_day_hour < 1))) {
                    if (lessons_per_day < 4) {
                        if (lessons_per_week < 40) { // Can Change 40 to a smaller number for test purpuses
                            MessageBox.Show("Professor Can Teach This Cource");
                            return true;
                        }
                        else {
                            MessageBox.Show("Professor has More than 40 Cources in one Week");
                            return false;
                        }

                    }
                    else {
                        MessageBox.Show("Professor has More than 4 Cources in one Day");
                        return false;
                    }

                }
                else {
                    MessageBox.Show("Professor has More than 1 Cources in one Day and the same Hour");
                    return false;
                }

            }
            return false;
        }

        private Boolean StudentCheck(List<Schedule> schedule, List<Student> student, String Calendar, String hour) {
            int lessons_per_day_hour = 0;
            int lessons_per_day = 0;
            DateTime dt = Convert.ToDateTime(Calendar);
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(dt);
            MessageBox.Show("Student Check Begin");
            for (int i = 0; i < schedule.Count; i++) {
                //MessageBox.Show("dd");
                for (int j = 0; j < student.Count; j++) {
                    for (int q = 0; q < schedule[i].Students.Count; q++) {
                        //MessageBox.Show("22");
                        if (student[j].ID == schedule[i].Students[q].ID && (Calendar == objects.Schedules[i].Calendars && hour == objects.Schedules[i].Hour)) {
                            lessons_per_day_hour++;
                        }
                        else if (student[j].ID == schedule[i].Students[q].ID && Calendar == objects.Schedules[i].Calendars) {
                            lessons_per_day++;
                        }
                    }
                }

            }
            for (int i = 0; i < schedule.Count; i++) {
                for (int j = 0; j < student.Count; j++) {
                    
                    if ((student[j].ID == schedule[i].Students[j].ID && lessons_per_day_hour < 1) || ((student[j].ID != schedule[i].Students[j].ID && lessons_per_day_hour < 1))) {
                        if (lessons_per_day < 3) {
                            MessageBox.Show("Succeffull Insertion for: "+ student[j].Name +", " +student[j].Surname);
                            return true;
                        }
                        else {
                            MessageBox.Show("Student" + student[j].Name + ", " + student[j].Surname+" has More than 3 Cources in one Day");
                            return false;
                        }

                    }
                    else {
                        MessageBox.Show("Student " + student[j].Name + ", " + student[j].Surname+ " has More than 1 Cources in one Day and the same Hour");
                        return false;
                    }
                }
            }
            return false;
        }
        private void ctrlExit_Click(object sender, EventArgs e) {
            try {

                // TODO: 1.1 CANNOT ADD SAME PROFESSOR IN SAME DATE & HOUR DONE

                // TODO: 1.2 CANNOT ADD SAME STUDENT IN SAME DATE & HOUR DONE

                // TODO: 2. EACH STUDENT CANNOT HAVE MORE THAN 3 COURSES PER DAY! DONE

                // TODO: 3. A PROFESSOR CANNOT TEACH MORE THAN 4 COURSES PER DAY AND 40 COURSES PER WEEK DONE

                Course course = (Course)CourseGridView1.CurrentRow.DataBoundItem;
                Student Stud = null;
                Students.Clear();
                for (int i = 0; i < StudentGridView1.SelectedRows.Count; i++) {
                    Stud = (Student)StudentGridView1.SelectedRows[i].DataBoundItem;
                    Students.Add(Stud);
                }
                Student student = (Student)StudentGridView1.CurrentRow.DataBoundItem;
                string hour = strtTime.Text;
                Professor professor = (Professor)ProfessorGridView.CurrentRow.DataBoundItem;
                String Calendar = ScheduleCalendar.SelectionRange.Start.ToString("dd/MM/yyyy");
                Schedule S = new Schedule();

                if (ProfessorCheck(objects.Schedules, professor, Calendar, hour) && StudentCheck(objects.Schedules, Students, Calendar, hour)) {
                    MessageBox.Show("Valid Professor And Student Insert to Schedule");
                    Schedule s = new Schedule(Students, course, professor, Calendar, hour);
                    objects.Schedules.Add(s);
                    string[] row = new string[] { course.Code, course.Subject, Calendar, hour, professor.Name + professor.Surname, professor.Rank.ToString(), s.ID.ToString() };
                    ScheduleGridView1.Rows.Add(row);
                    SaveSchedule();
                }
                else {
                    MessageBox.Show("Invalid Selection");
                }
                //for (int i = 0; i < objects.Schedules.Count; i++) {
                //    // for (int j = 0; j < objects.Schedules[i].Students.Count; j++) {
                //    MessageBox.Show("aaaaa");
                //    if (professor.ID == objects.Schedules[i].Professors.ID && Calendar != objects.Schedules[i].Calendars) {
                //        MessageBox.Show("Valid Professor");
                //        objects.Schedules.Add(new Schedule(Students, course, professor, Calendar));
                //        string[] row = new string[] { professor.Name + professor.Surname, professor.Rank.ToString(), course.Code, course.Subject };
                //        ScheduleGridView1.Rows.Add(row);
                //        SaveSchedule();
                //    }
                //    for (int j = 0; j < objects.Schedules[i].Students.Count; j++) {
                //        if (student.ID == objects.Schedules[i].Students[j].ID && Calendar != objects.Schedules[i].Calendars) {
                //            MessageBox.Show("Valid Student");
                //        }
                //    }



                // }

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

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {


        }

        private void ScheduleGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (ScheduleGridView1.Columns[e.ColumnIndex].Name == "Delete") {
                objects.Schedules.RemoveAt(e.RowIndex);
                ScheduleGridView1.Rows.Clear();
                foreach (Schedule for_schedule in objects.Schedules) {
                    string[] row = new string[] { for_schedule.Courses.Code, for_schedule.Courses.Subject, for_schedule.Calendars, for_schedule.Hour, for_schedule.Professors.Name + for_schedule.Professors.Surname, for_schedule.Professors.Rank.ToString(), for_schedule.ID.ToString() };
                    ScheduleGridView1.Rows.Add(row);
                }
            }
            if (ScheduleGridView1.Columns[e.ColumnIndex].Name == "StudentList") {
                MessageBox.Show(objects.Schedules[0].Students[0].Name.ToString());
                //Schedule s; //= (Schedule)ScheduleGridView1.CurrentRow.DataBoundItem;
                //List<Schedule> l = new List<Schedule>();
                //for (int i = 0; i < ScheduleGridView1.SelectedRows.Count; i++) {
                //    s = (Schedule)ScheduleGridView1.SelectedRows[i].DataBoundItem;
                //    l.Add(s);
                //}
                //StudentForm form = new StudentForm(l[0].Students);
                //objects.Schedules
                List<Student> l = new List<Student>();
                l.Clear();
                Schedule s = null;
                Student Stud = null;
                //s = (Schedule)ScheduleGridView1.CurrentRow.DataBoundItem;
                Students.Clear();
                for (int i = 0; i < ScheduleGridView1.SelectedRows.Count; i++) {
                    
                    s = (Schedule)ScheduleGridView1.SelectedRows[i].DataBoundItem;
                    for (int j = 0; j < s.Students.Count; j++) {
                        l.Add(s.Students[j]);
                    }
                    
                }


                //Schedule s; //= (Schedule)ScheduleGridView1.CurrentRow.DataBoundItem;
                //List<Student> l = new List<Student>();
                //for (int i = 0; i < objects.Schedules.Count; i++) {
                //    l = objects.Schedules[i].Students;
                //}
                StudentForm form = new StudentForm(l);
                form.Show();
            }
            
        }

        private void StudentGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void ProfessorGridView_DoubleClick(object sender, EventArgs e) {

        }

        private void CourseGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            Course course = (Course)CourseGridView1.CurrentRow.DataBoundItem;
            List<Student> students = new List<Student>();
            List<Professor> professors = new List<Professor>();

            for (int i = 0; i < objects.Students.Count; i++) {
                for (int j = 0; j < objects.Students[i].CAN_LEARN.Count; j++) {
                    if (objects.Students[i].CAN_LEARN[j].ID == course.ID) {
                        students.Add(objects.Students[i]);

                    }
                }

            }
            for (int i = 0; i < objects.Professors.Count; i++) {
                for (int j = 0; j < objects.Professors[i].CAN_TEACH.Count; j++) {
                    if (objects.Professors[i].CAN_TEACH[j].ID == course.ID) {
                        professors.Add(objects.Professors[i]);

                    }
                }

            }
            StudentGridView1.DataSource = students;
            ProfessorGridView.DataSource = professors;
        }
    }
}

