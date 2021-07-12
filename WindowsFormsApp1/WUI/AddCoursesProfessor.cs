using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using WindowsFormsApp1.Impl;
using System.IO;

namespace WindowsFormsApp1.WUI {
    public partial class AddCoursesProfessor : Form {
        private University objects = new University();
        public List<Form> OpenForms { get; set; }
        private const string _JsonProfessorData = "ProfessorData.json";
        private const string _JsonCourseData = "CourseData.json";
        public AddCoursesProfessor() {
            InitializeComponent();
        }
        private void AddCoursesProfessor_Load(object sender, EventArgs e) {
            OpenForms = new List<Form>();
            this.IsMdiContainer = true;
            loadData();
        }
        private void DeserializeFromJson() {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            JavaScriptSerializer serializer1 = new JavaScriptSerializer();
            string path = Path.Combine(Environment.CurrentDirectory, _JsonProfessorData);
            string data = File.ReadAllText(path);
            string path1 = Path.Combine(Environment.CurrentDirectory, _JsonCourseData);
            string data1 = File.ReadAllText(path1);
            objects.Professors = serializer.Deserialize<List<Professor>>(data);
            objects.Courses = serializer1.Deserialize<List<Course>>(data1);
        }
        private void loadData() {
            DeserializeFromJson();
            dataGridView1.DataSource = objects.Professors;
            dataGridView2.DataSource = objects.Courses;

        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            Course course = (Course)dataGridView2.CurrentRow.DataBoundItem;
            Professor professor = (Professor)dataGridView1.CurrentRow.DataBoundItem;
           // objects.Schedules.Add(new Schedule(Students, course, professor, Calendar));
            string[] row = new string[] { professor.Name + professor.Surname, professor.Rank.ToString(), course.Code, course.Subject };
            //ScheduleGridView1.Rows.Add(row);
        }
    }
}
