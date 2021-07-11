
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
            this.button8 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initializeDedomenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addToScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfessorGridView = new System.Windows.Forms.DataGridView();
            this.StudentGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseGridView1 = new System.Windows.Forms.DataGridView();
            this.ScheduleGridView1 = new System.Windows.Forms.DataGridView();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.Proffessor_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentList = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.ctrlExit.Location = new System.Drawing.Point(853, 242);
            this.ctrlExit.Name = "ctrlExit";
            this.ctrlExit.Size = new System.Drawing.Size(143, 32);
            this.ctrlExit.TabIndex = 8;
            this.ctrlExit.Text = "Add";
            this.ctrlExit.UseVisualStyleBackColor = true;
            this.ctrlExit.Click += new System.EventHandler(this.ctrlExit_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(56, 422);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(143, 32);
            this.button8.TabIndex = 9;
            this.button8.Text = "Remove";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(832, 188);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(505, 645);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(143, 32);
            this.button9.TabIndex = 11;
            this.button9.Text = "Load";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(654, 645);
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
            this.label6.Location = new System.Drawing.Point(21, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(426, 42);
            this.label6.TabIndex = 13;
            this.label6.Text = "University Courses Scheduler";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(610, 57);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(187, 32);
            this.button11.TabIndex = 14;
            this.button11.Text = "Initialize (only run once!)";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1250, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mainToolStripMenuItem
            // 
            this.mainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initializeDedomenaToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addToScheduleToolStripMenuItem,
            this.toolStripMenuItem2,
            this.loadDataToolStripMenuItem,
            this.saveDataToolStripMenuItem});
            this.mainToolStripMenuItem.Name = "mainToolStripMenuItem";
            this.mainToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.mainToolStripMenuItem.Text = "Main";
            // 
            // initializeDedomenaToolStripMenuItem
            // 
            this.initializeDedomenaToolStripMenuItem.Name = "initializeDedomenaToolStripMenuItem";
            this.initializeDedomenaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.initializeDedomenaToolStripMenuItem.Text = "Initialize Dedomena";
            this.initializeDedomenaToolStripMenuItem.Click += new System.EventHandler(this.initializeDedomenaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // addToScheduleToolStripMenuItem
            // 
            this.addToScheduleToolStripMenuItem.Name = "addToScheduleToolStripMenuItem";
            this.addToScheduleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addToScheduleToolStripMenuItem.Text = "Add To Schedule...";
            this.addToScheduleToolStripMenuItem.Click += new System.EventHandler(this.addToScheduleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadDataToolStripMenuItem.Text = "Load Data";
            this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveDataToolStripMenuItem.Text = "Save Data";
            this.saveDataToolStripMenuItem.Click += new System.EventHandler(this.saveDataToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // ProfessorGridView
            // 
            this.ProfessorGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfessorGridView.Location = new System.Drawing.Point(28, 121);
            this.ProfessorGridView.Name = "ProfessorGridView";
            this.ProfessorGridView.Size = new System.Drawing.Size(376, 115);
            this.ProfessorGridView.TabIndex = 16;
            this.ProfessorGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StudentGridView1
            // 
            this.StudentGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentGridView1.Location = new System.Drawing.Point(440, 139);
            this.StudentGridView1.Name = "StudentGridView1";
            this.StudentGridView1.Size = new System.Drawing.Size(357, 212);
            this.StudentGridView1.TabIndex = 17;
            this.StudentGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentGridView1_CellContentClick);
            // 
            // CourseGridView1
            // 
            this.CourseGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseGridView1.Location = new System.Drawing.Point(28, 242);
            this.CourseGridView1.Name = "CourseGridView1";
            this.CourseGridView1.Size = new System.Drawing.Size(376, 135);
            this.CourseGridView1.TabIndex = 18;
            // 
            // ScheduleGridView1
            // 
            this.ScheduleGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Proffessor_Name,
            this.CourseName,
            this.StudentList});
            this.ScheduleGridView1.Location = new System.Drawing.Point(47, 460);
            this.ScheduleGridView1.Name = "ScheduleGridView1";
            this.ScheduleGridView1.Size = new System.Drawing.Size(935, 170);
            this.ScheduleGridView1.TabIndex = 19;
            this.ScheduleGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ScheduleGridView1_CellContentClick);
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Manager = null;
            this.galleryDropDown1.Name = "galleryDropDown1";
            // 
            // Proffessor_Name
            // 
            this.Proffessor_Name.HeaderText = "Proffessor_Name";
            this.Proffessor_Name.Name = "Proffessor_Name";
            this.Proffessor_Name.ReadOnly = true;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "CourseName";
            this.CourseName.Name = "CourseName";
            this.CourseName.ReadOnly = true;
            // 
            // StudentList
            // 
            this.StudentList.HeaderText = "StudentList";
            this.StudentList.Name = "StudentList";
            this.StudentList.Text = "Student List";
            this.StudentList.UseColumnTextForButtonValue = true;
            // 
            // DataForm1
            // 
            this.ClientSize = new System.Drawing.Size(1250, 737);
            this.Controls.Add(this.ScheduleGridView1);
            this.Controls.Add(this.CourseGridView1);
            this.Controls.Add(this.StudentGridView1);
            this.Controls.Add(this.ProfessorGridView);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button8);
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
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initializeDedomenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView ProfessorGridView;
        private System.Windows.Forms.DataGridView StudentGridView1;
        private System.Windows.Forms.DataGridView CourseGridView1;
        private System.Windows.Forms.DataGridView ScheduleGridView1;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proffessor_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewButtonColumn StudentList;
    }
}