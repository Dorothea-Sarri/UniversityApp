
namespace WindowsFormsApp1.WUI {
    partial class DataForm1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.ctrlExit = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfessorGridView = new System.Windows.Forms.DataGridView();
            this.StudentGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseGridView1 = new System.Windows.Forms.DataGridView();
            this.ScheduleGridView1 = new System.Windows.Forms.DataGridView();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.ScheduleCalendar = new System.Windows.Forms.MonthCalendar();
            this.strtTime = new System.Windows.Forms.TextBox();
            this.StartTime = new System.Windows.Forms.Label();
            this.CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proffessor_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfessorRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentList = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button8 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfessorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlExit
            // 
            this.ctrlExit.Location = new System.Drawing.Point(1212, 344);
            this.ctrlExit.Name = "ctrlExit";
            this.ctrlExit.Size = new System.Drawing.Size(143, 32);
            this.ctrlExit.TabIndex = 8;
            this.ctrlExit.Text = "Add";
            this.ctrlExit.UseVisualStyleBackColor = true;
            this.ctrlExit.Click += new System.EventHandler(this.ctrlExit_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(906, 664);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(143, 32);
            this.button9.TabIndex = 11;
            this.button9.Text = "Load";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1082, 664);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(143, 32);
            this.button10.TabIndex = 12;
            this.button10.Text = "Save";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(370, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(426, 42);
            this.label6.TabIndex = 13;
            this.label6.Text = "University Courses Scheduler";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1424, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.exitToolStripMenuItem.Text = "About";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ProfessorGridView
            // 
            this.ProfessorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfessorGridView.Location = new System.Drawing.Point(615, 70);
            this.ProfessorGridView.Name = "ProfessorGridView";
            this.ProfessorGridView.Size = new System.Drawing.Size(513, 115);
            this.ProfessorGridView.TabIndex = 16;
            this.ProfessorGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.ProfessorGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.ProfessorGridView.DoubleClick += new System.EventHandler(this.ProfessorGridView_DoubleClick);
            // 
            // StudentGridView1
            // 
            this.StudentGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView1.Location = new System.Drawing.Point(615, 194);
            this.StudentGridView1.Name = "StudentGridView1";
            this.StudentGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentGridView1.Size = new System.Drawing.Size(513, 212);
            this.StudentGridView1.TabIndex = 17;
            this.StudentGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView1_CellContentClick);
            // 
            // CourseGridView1
            // 
            this.CourseGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseGridView1.Location = new System.Drawing.Point(12, 70);
            this.CourseGridView1.Name = "CourseGridView1";
            this.CourseGridView1.Size = new System.Drawing.Size(574, 336);
            this.CourseGridView1.TabIndex = 18;
            this.CourseGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseGridView1_CellClick);
            // 
            // ScheduleGridView1
            // 
            this.ScheduleGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseCode,
            this.CourseName,
            this.CourceDate,
            this.Start_Time,
            this.Proffessor_Name,
            this.ProfessorRank,
            this.ScheduleID,
            this.StudentList,
            this.Delete});
            this.ScheduleGridView1.Location = new System.Drawing.Point(98, 471);
            this.ScheduleGridView1.Name = "ScheduleGridView1";
            this.ScheduleGridView1.Size = new System.Drawing.Size(904, 170);
            this.ScheduleGridView1.TabIndex = 19;
            this.ScheduleGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScheduleGridView1_CellContentClick);
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Manager = null;
            this.galleryDropDown1.Name = "galleryDropDown1";
            // 
            // ScheduleCalendar
            // 
            this.ScheduleCalendar.Location = new System.Drawing.Point(1176, 85);
            this.ScheduleCalendar.MaxSelectionCount = 1;
            this.ScheduleCalendar.Name = "ScheduleCalendar";
            this.ScheduleCalendar.TabIndex = 20;
            // 
            // strtTime
            // 
            this.strtTime.Location = new System.Drawing.Point(1289, 275);
            this.strtTime.Name = "strtTime";
            this.strtTime.Size = new System.Drawing.Size(100, 20);
            this.strtTime.TabIndex = 21;
            // 
            // StartTime
            // 
            this.StartTime.AutoSize = true;
            this.StartTime.Location = new System.Drawing.Point(1209, 278);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(52, 13);
            this.StartTime.TabIndex = 22;
            this.StartTime.Text = "StartTime";
            // 
            // CourseCode
            // 
            this.CourseCode.HeaderText = "Course Code";
            this.CourseCode.Name = "CourseCode";
            this.CourseCode.Width = 120;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            this.CourseName.Width = 120;
            // 
            // CourceDate
            // 
            this.CourceDate.HeaderText = "Cource Date";
            this.CourceDate.Name = "CourceDate";
            this.CourceDate.ReadOnly = true;
            // 
            // Start_Time
            // 
            this.Start_Time.HeaderText = "Start Time";
            this.Start_Time.Name = "Start_Time";
            // 
            // Proffessor_Name
            // 
            this.Proffessor_Name.HeaderText = "Professor Name";
            this.Proffessor_Name.Name = "Proffessor_Name";
            this.Proffessor_Name.ReadOnly = true;
            this.Proffessor_Name.Width = 120;
            // 
            // ProfessorRank
            // 
            this.ProfessorRank.HeaderText = "Professor Rank";
            this.ProfessorRank.Name = "ProfessorRank";
            this.ProfessorRank.Width = 120;
            // 
            // ScheduleID
            // 
            this.ScheduleID.HeaderText = "ScheduleID";
            this.ScheduleID.Name = "ScheduleID";
            this.ScheduleID.Visible = false;
            // 
            // StudentList
            // 
            this.StudentList.HeaderText = "StudentList";
            this.StudentList.Name = "StudentList";
            this.StudentList.Text = "Student List";
            this.StudentList.UseColumnTextForButtonValue = true;
            this.StudentList.Width = 80;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(1246, 664);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 32);
            this.button8.TabIndex = 23;
            this.button8.Text = "Exit";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // DataForm1
            // 
            this.ClientSize = new System.Drawing.Size(1424, 737);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.strtTime);
            this.Controls.Add(this.ScheduleCalendar);
            this.Controls.Add(this.ScheduleGridView1);
            this.Controls.Add(this.CourseGridView1);
            this.Controls.Add(this.StudentGridView1);
            this.Controls.Add(this.ProfessorGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.ctrlExit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DataForm1";
            this.Load += new System.EventHandler(this.DataForm1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfessorGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        
        private System.Windows.Forms.Button button6;
 
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
  
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button ctrlExit;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView ProfessorGridView;
        private System.Windows.Forms.DataGridView StudentGridView1;
        private System.Windows.Forms.DataGridView CourseGridView1;
        private System.Windows.Forms.DataGridView ScheduleGridView1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private System.Windows.Forms.MonthCalendar ScheduleCalendar;
        private System.Windows.Forms.TextBox strtTime;
        private System.Windows.Forms.Label StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proffessor_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfessorRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleID;
        private System.Windows.Forms.DataGridViewButtonColumn StudentList;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button button8;
    }
}