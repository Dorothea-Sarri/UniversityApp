
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm1));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfessorGridView = new System.Windows.Forms.DataGridView();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfessorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentGridView1 = new System.Windows.Forms.DataGridView();
            this.RegistrationNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseGridView1 = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourceDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proffessor_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfessorRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScheduleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentList = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.ScheduleCalendar = new System.Windows.Forms.MonthCalendar();
            this.strtTime = new System.Windows.Forms.TextBox();
            this.StartTime = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCourses = new System.Windows.Forms.Label();
            this.lblProfessors = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfessorGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdd.Location = new System.Drawing.Point(1212, 344);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 32);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(970, 717);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(143, 32);
            this.btnLoad.TabIndex = 11;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.Load_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1131, 717);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 32);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(338, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(428, 44);
            this.label6.TabIndex = 13;
            this.label6.Text = "University Courses Scheduler";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1489, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(52, 20);
            this.About.Text = "About";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // ProfessorGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.RosyBrown;
            this.ProfessorGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ProfessorGridView.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProfessorGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProfessorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfessorGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rank,
            this.Name,
            this.Surname,
            this.Age,
            this.ProfessorId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProfessorGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProfessorGridView.Location = new System.Drawing.Point(557, 132);
            this.ProfessorGridView.Name = "ProfessorGridView";
            this.ProfessorGridView.Size = new System.Drawing.Size(445, 141);
            this.ProfessorGridView.TabIndex = 16;
            this.ProfessorGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.ProfessorGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.ProfessorGridView.DoubleClick += new System.EventHandler(this.ProfessorGridView_DoubleClick);
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Rank";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            this.Rank.Visible = false;
            // 
            // Name
            // 
            this.Name.HeaderText = "Professor Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            this.Name.Visible = false;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Professor Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Visible = false;
            // 
            // Age
            // 
            this.Age.HeaderText = "Professor Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Visible = false;
            // 
            // ProfessorId
            // 
            this.ProfessorId.HeaderText = "Professor Id";
            this.ProfessorId.Name = "ProfessorId";
            this.ProfessorId.ReadOnly = true;
            this.ProfessorId.Visible = false;
            // 
            // StudentGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RosyBrown;
            this.StudentGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.StudentGridView1.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.StudentGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistrationNumber,
            this.StudentName,
            this.StudentSurname,
            this.StudentAge,
            this.StudentId});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.StudentGridView1.Location = new System.Drawing.Point(557, 306);
            this.StudentGridView1.Name = "StudentGridView1";
            this.StudentGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentGridView1.Size = new System.Drawing.Size(445, 185);
            this.StudentGridView1.TabIndex = 17;
            this.StudentGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView1_CellContentClick);
            // 
            // RegistrationNumber
            // 
            this.RegistrationNumber.HeaderText = "Registration Number";
            this.RegistrationNumber.Name = "RegistrationNumber";
            this.RegistrationNumber.ReadOnly = true;
            this.RegistrationNumber.Visible = false;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "StudentName";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Visible = false;
            // 
            // StudentSurname
            // 
            this.StudentSurname.HeaderText = "Student Surname";
            this.StudentSurname.Name = "StudentSurname";
            this.StudentSurname.ReadOnly = true;
            this.StudentSurname.Visible = false;
            // 
            // StudentAge
            // 
            this.StudentAge.HeaderText = "Student Age";
            this.StudentAge.Name = "StudentAge";
            this.StudentAge.ReadOnly = true;
            this.StudentAge.Visible = false;
            // 
            // StudentId
            // 
            this.StudentId.HeaderText = "Student Id";
            this.StudentId.Name = "StudentId";
            this.StudentId.ReadOnly = true;
            this.StudentId.Visible = false;
            // 
            // CourseGridView1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.RosyBrown;
            this.CourseGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.CourseGridView1.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CourseGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.CourseGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Subject,
            this.Hours,
            this.Category,
            this.ID});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.CourseGridView1.GridColor = System.Drawing.Color.Snow;
            this.CourseGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CourseGridView1.Location = new System.Drawing.Point(23, 125);
            this.CourseGridView1.Name = "CourseGridView1";
            this.CourseGridView1.Size = new System.Drawing.Size(444, 340);
            this.CourseGridView1.TabIndex = 18;
            this.CourseGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseGridView1_CellClick);
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            this.Code.Visible = false;
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            this.Subject.Visible = false;
            // 
            // Hours
            // 
            this.Hours.HeaderText = "Hours";
            this.Hours.Name = "Hours";
            this.Hours.ReadOnly = true;
            this.Hours.Visible = false;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // ScheduleGridView1
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.RosyBrown;
            this.ScheduleGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ScheduleGridView1.BackgroundColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ScheduleGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ScheduleGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.ScheduleGridView1.Location = new System.Drawing.Point(23, 538);
            this.ScheduleGridView1.Name = "ScheduleGridView1";
            this.ScheduleGridView1.Size = new System.Drawing.Size(911, 170);
            this.ScheduleGridView1.TabIndex = 19;
            this.ScheduleGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScheduleGridView1_CellContentClick);
            // 
            // CourseCode
            // 
            this.CourseCode.HeaderText = "Course Code";
            this.CourseCode.Name = "CourseCode";
            this.CourseCode.Width = 120;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Subject";
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
            this.ScheduleCalendar.TitleBackColor = System.Drawing.Color.Brown;
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
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1289, 717);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 32);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lblCourses
            // 
            this.lblCourses.AutoSize = true;
            this.lblCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCourses.Location = new System.Drawing.Point(19, 100);
            this.lblCourses.Name = "lblCourses";
            this.lblCourses.Size = new System.Drawing.Size(223, 20);
            this.lblCourses.TabIndex = 24;
            this.lblCourses.Text = "Available Courses in University";
            // 
            // lblProfessors
            // 
            this.lblProfessors.AutoSize = true;
            this.lblProfessors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProfessors.Location = new System.Drawing.Point(554, 107);
            this.lblProfessors.Name = "lblProfessors";
            this.lblProfessors.Size = new System.Drawing.Size(242, 20);
            this.lblProfessors.TabIndex = 25;
            this.lblProfessors.Text = "Professors who can teach lesson";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStudents.Location = new System.Drawing.Point(554, 282);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(226, 20);
            this.lblStudents.TabIndex = 26;
            this.lblStudents.Text = "Students who can learn lesson";
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSchedule.Location = new System.Drawing.Point(20, 510);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(76, 20);
            this.lblSchedule.TabIndex = 27;
            this.lblSchedule.Text = "Schedule";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // DataForm1
            // 
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1489, 784);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lblProfessors);
            this.Controls.Add(this.lblCourses);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.strtTime);
            this.Controls.Add(this.ScheduleCalendar);
            this.Controls.Add(this.ScheduleGridView1);
            this.Controls.Add(this.CourseGridView1);
            this.Controls.Add(this.StudentGridView1);
            this.Controls.Add(this.ProfessorGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            //this.Name = "DataForm1";
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
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.DataGridView ProfessorGridView;
        private System.Windows.Forms.DataGridView StudentGridView1;
        private System.Windows.Forms.DataGridView CourseGridView1;
        private System.Windows.Forms.DataGridView ScheduleGridView1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private System.Windows.Forms.MonthCalendar ScheduleCalendar;
        private System.Windows.Forms.TextBox strtTime;
        private System.Windows.Forms.Label StartTime;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourceDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proffessor_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfessorRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScheduleID;
        private System.Windows.Forms.DataGridViewButtonColumn StudentList;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfessorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.Label lblCourses;
        private System.Windows.Forms.Label lblProfessors;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}