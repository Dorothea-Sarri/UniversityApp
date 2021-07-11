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
           objects.Courses= serializer1.Deserialize<List<Course>>(data1);



        }
        private void loadData() {
            DeserializeFromJson();

        
            foreach (Course bb in objects.Courses) {
                listBox1.Items.Add(bb.Code + "--" + bb.Subject);
            }


            foreach (Professor cc1 in objects.Professors) {

                listBox2.Items.Add(string.Format("{0}  {1}", cc1.Name, cc1.Surname));
            }



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            Professor p = (Professor)listBox2.SelectedItem;
            Course c = (Course)listBox1.SelectedItem;

          // p.CAN_TEACH.Add();
        }
    }
}
