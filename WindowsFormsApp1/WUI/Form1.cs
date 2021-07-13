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

        private University university = new University();
        private const string _JsonFile = "StudentData.json";
        private const string _JsonProfessorData = "ProfessorData.json";
        private const string _JsonCourseData = "CourseData.json";
        private const string _JsonScheduleData = "SchedulesData.json";
        List<Student> Students = new List<Student>();
        public DataForm1() {
            InitializeComponent();
        }

        
        private void DataForm1_Load(object sender, EventArgs e) {
            DeserializeFromJson();
            LoadGridViews();
            CourseGridView1.Columns["ID"].Visible = false;
        }
        private void LoadGridViews() {

            StudentGridView1.DataSource = university.Students;
            CourseGridView1.DataSource = university.Courses;
            ProfessorGridView.DataSource = university.Professors;
            foreach (Schedule for_schedule in university.Schedules) {
                string[] row = new string[] { for_schedule.Courses.Code, for_schedule.Courses.Subject, for_schedule.Calendars, for_schedule.Hour, for_schedule.Professors.Name + for_schedule.Professors.Surname, for_schedule.Professors.Rank.ToString(), for_schedule.ID.ToString() };
                ScheduleGridView1.Rows.Add(row);
            }
        }
      
        private void SaveSchedule() {
            JavaScriptSerializer schedulesSerializer = new JavaScriptSerializer();
            JavaScriptSerializer professorSerializer = new JavaScriptSerializer();
            JavaScriptSerializer studentSerializer = new JavaScriptSerializer();
            JavaScriptSerializer courseSerializer = new JavaScriptSerializer();

            File.WriteAllText("SchedulesData.json", schedulesSerializer.Serialize(university.Schedules));
            File.WriteAllText("ProfessorData.json", professorSerializer.Serialize(university.Professors));
            File.WriteAllText("StudentData.json", studentSerializer.Serialize(university.Students));
            File.WriteAllText("CourseData.json", courseSerializer.Serialize(university.Courses));

        }
        private bool DatesAreInTheSameWeek(DateTime firtsDate, DateTime endDate) {
            //Check 2 date if have the same first day of the week
            var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
            var date1 = firtsDate.Date.AddDays(-1 * (int)cal.GetDayOfWeek(firtsDate));
            var date2 = endDate.Date.AddDays(-1 * (int)cal.GetDayOfWeek(endDate));

            return date1 == date2;
        }
        private Boolean ProfessorCheck(List<Schedule> schedule, Professor professor, String Calendar, String hour) {
            int lessons_per_day_hour = 0;
            int lessons_per_day = 0;
            int lessons_per_week = 0;


            DateTime dt = Convert.ToDateTime(Calendar);
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(dt);
            for (int i = 0; i < schedule.Count; i++) {
                if (professor.ID == schedule[i].Professors.ID && (Calendar == university.Schedules[i].Calendars && hour == university.Schedules[i].Hour)) {
                    lessons_per_day_hour++;
                }
                else if (professor.ID == schedule[i].Professors.ID && Calendar == university.Schedules[i].Calendars) {
                    lessons_per_day++;
                }

                if (professor.ID == schedule[i].Professors.ID && DatesAreInTheSameWeek(dt, Convert.ToDateTime(university.Schedules[i].Calendars))) {
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
                
                for (int j = 0; j < student.Count; j++) {
                    for (int q = 0; q < schedule[i].Students.Count; q++) {
                       
                        if (student[j].ID == schedule[i].Students[q].ID && (Calendar == university.Schedules[i].Calendars && hour == university.Schedules[i].Hour)) {
                            lessons_per_day_hour++;
                        }
                        else if (student[j].ID == schedule[i].Students[q].ID && Calendar == university.Schedules[i].Calendars) {
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
    

     
        private void DeserializeFromJson() {

            JavaScriptSerializer studentsSerializer = new JavaScriptSerializer();
            JavaScriptSerializer professorsSerializer = new JavaScriptSerializer();
            JavaScriptSerializer coursesSerializer = new JavaScriptSerializer();
            JavaScriptSerializer schedulesSerializer = new JavaScriptSerializer();
            string pathStudents = Path.Combine(Environment.CurrentDirectory, _JsonFile);
            string dataStudents = File.ReadAllText(pathStudents);

            string pathProfessors = Path.Combine(Environment.CurrentDirectory, _JsonProfessorData);
            string dataProfessors = File.ReadAllText(pathProfessors);

            string pathCourses = Path.Combine(Environment.CurrentDirectory, _JsonCourseData);
            string dataCourses = File.ReadAllText(pathCourses);

            string pathSchedules = Path.Combine(Environment.CurrentDirectory, _JsonScheduleData);
            string dataSchedules = File.ReadAllText(pathSchedules);

            university.Students = studentsSerializer.Deserialize<List<Student>>(dataStudents);
            university.Professors = professorsSerializer.Deserialize<List<Professor>>(dataProfessors);
            university.Courses = coursesSerializer.Deserialize<List<Course>>(dataCourses);
            university.Schedules = schedulesSerializer.Deserialize<List<Schedule>>(dataSchedules);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {


        }

        private void ScheduleGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (ScheduleGridView1.Columns[e.ColumnIndex].Name == "Delete") {
                university.Schedules.RemoveAt(e.RowIndex);
                ScheduleGridView1.Rows.Clear();
                foreach (Schedule for_schedule in university.Schedules) {
                    string[] row = new string[] { for_schedule.Courses.Code, for_schedule.Courses.Subject, for_schedule.Calendars, for_schedule.Hour, for_schedule.Professors.Name + for_schedule.Professors.Surname, for_schedule.Professors.Rank.ToString(), for_schedule.ID.ToString() };
                    ScheduleGridView1.Rows.Add(row);
                }
            }
            if (ScheduleGridView1.Columns[e.ColumnIndex].Name == "StudentList") {
                
               
                //List<Student> l = new List<Student>();
                //l.Clear();
                //Schedule schedule = null;
                //Student Stud = null;
               
                //Students.Clear();
                //for (int i = 0; i < ScheduleGridView1.SelectedRows.Count; i++) {

                //    schedule = (Schedule)ScheduleGridView1.SelectedRows[i].DataBoundItem;
                //    for (int j = 0; j < schedule.Students.Count; j++) {
                //        l.Add(schedule.Students[j]);
                //    }
                    
                //}

                StudentForm form = new StudentForm(university.Students);
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

            for (int i = 0; i < university.Students.Count; i++) {
                for (int j = 0; j < university.Students[i].coursesCanLearn.Count; j++) {
                    if (university.Students[i].coursesCanLearn[j].ID == course.ID) {
                        students.Add(university.Students[i]);

                    }
                }

            }
            for (int i = 0; i < university.Professors.Count; i++) {
                for (int j = 0; j < university.Professors[i].coursesCanTeach.Count; j++) {
                    if (university.Professors[i].coursesCanTeach[j].ID == course.ID) {
                        professors.Add(university.Professors[i]);

                    }
                }

            }
            StudentGridView1.DataSource = students;
            ProfessorGridView.DataSource = professors;
        }

      

        private void Add_Click(object sender, EventArgs e) {
            try {

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
                //Schedule schedule = new Schedule();

                if (ProfessorCheck(university.Schedules, professor, Calendar, hour) && StudentCheck(university.Schedules, Students, Calendar, hour)) {
                    MessageBox.Show("Valid Professor And Student Insert to Schedule");
                    Schedule schedule = new Schedule(Students, course, professor, Calendar, hour);
                    university.Schedules.Add(schedule);
                    string[] row = new string[] { course.Code, course.Subject, Calendar, hour, professor.Name + professor.Surname, professor.Rank.ToString(), schedule.ID.ToString() };
                    ScheduleGridView1.Rows.Add(row);
                    SaveSchedule();
                }
                else {
                    MessageBox.Show("Invalid Selection");
                }
             


            }
            catch (NullReferenceException) {
                MessageBox.Show("You have not select Some of the neccecery components of the Schedule");
            }
            catch {
                MessageBox.Show("Error");
            }
        }

        private void Exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }



        private void Save_Click(object sender, EventArgs e) {
            SaveSchedule();
        }

        private void About_Click(object sender, EventArgs e) {
            MessageBox.Show("Τhis application was created during Epsilonet Coding School by Dorothea Sarri");
        }

        private void label6_Click(object sender, EventArgs e) {

        }
    }
}

