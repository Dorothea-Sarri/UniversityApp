using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Impl;


namespace WindowsFormsApp1.WUI {
    public partial class StudentForm : Form {
        List<Student> Students = new List<Student>();
        public StudentForm(List<Student> Students) {
            InitializeComponent();
            this.Students = Students;
        }

        private void StudentForm_Load(object sender, EventArgs e) {
              dataGridView1.DataSource = Students;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

       }
    }
}
