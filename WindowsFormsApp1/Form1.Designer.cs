
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Code = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_NoOfEvaluation = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_NoOfEvaluation = new System.Windows.Forms.TextBox();
            this.btn_AddCourse = new System.Windows.Forms.Button();
            this.lb_Courses = new System.Windows.Forms.ListBox();
            this.lbl_CourseCode = new System.Windows.Forms.Label();
            this.lbl_CourseName = new System.Windows.Forms.Label();
            this.lbl_CourseDescription = new System.Windows.Forms.Label();
            this.lbl_CourseNoOfEvaluations = new System.Windows.Forms.Label();
            this.lbl_ACourseCode = new System.Windows.Forms.Label();
            this.lbl_ACourseName = new System.Windows.Forms.Label();
            this.lbl_ACourseDescription = new System.Windows.Forms.Label();
            this.lbl_ANoOfEvaluations = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SectionID = new System.Windows.Forms.TextBox();
            this.txt_SectionName = new System.Windows.Forms.TextBox();
            this.btn_AddSection = new System.Windows.Forms.Button();
            this.lb_Sections = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_AddSectionToCourse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TeacherName = new System.Windows.Forms.TextBox();
            this.DOB_Picker = new System.Windows.Forms.DateTimePicker();
            this.txt_StreetAddress = new System.Windows.Forms.TextBox();
            this.txt_TelNumber = new System.Windows.Forms.TextBox();
            this.btn_AddFaculty = new System.Windows.Forms.Button();
            this.lb_Faculty = new System.Windows.Forms.ListBox();
            this.btn_AssignFacultyToSection = new System.Windows.Forms.Button();
            this.btn_LoadFile = new System.Windows.Forms.Button();
            this.btn_SaveFile = new System.Windows.Forms.Button();
            this.Cmb_Semester = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_MaxNoOfStudents = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_PostalCode = new System.Windows.Forms.TextBox();
            this.gb_Sections = new System.Windows.Forms.GroupBox();
            this.lbl_ASection = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.gb_Sections.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Code
            // 
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.Location = new System.Drawing.Point(0, 9);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(32, 13);
            this.lbl_Code.TabIndex = 0;
            this.lbl_Code.Text = "Code";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(0, 35);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(0, 63);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(60, 13);
            this.lbl_Description.TabIndex = 2;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_NoOfEvaluation
            // 
            this.lbl_NoOfEvaluation.AutoSize = true;
            this.lbl_NoOfEvaluation.Location = new System.Drawing.Point(0, 93);
            this.lbl_NoOfEvaluation.Name = "lbl_NoOfEvaluation";
            this.lbl_NoOfEvaluation.Size = new System.Drawing.Size(116, 13);
            this.lbl_NoOfEvaluation.TabIndex = 3;
            this.lbl_NoOfEvaluation.Text = "Number Of Evaluations";
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(122, 2);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(100, 20);
            this.txt_Code.TabIndex = 4;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(122, 28);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 5;
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(122, 56);
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(100, 20);
            this.txt_Description.TabIndex = 6;
            // 
            // txt_NoOfEvaluation
            // 
            this.txt_NoOfEvaluation.Location = new System.Drawing.Point(122, 86);
            this.txt_NoOfEvaluation.Name = "txt_NoOfEvaluation";
            this.txt_NoOfEvaluation.Size = new System.Drawing.Size(100, 20);
            this.txt_NoOfEvaluation.TabIndex = 7;
            // 
            // btn_AddCourse
            // 
            this.btn_AddCourse.Location = new System.Drawing.Point(3, 131);
            this.btn_AddCourse.Name = "btn_AddCourse";
            this.btn_AddCourse.Size = new System.Drawing.Size(75, 23);
            this.btn_AddCourse.TabIndex = 8;
            this.btn_AddCourse.Text = "Add Course";
            this.btn_AddCourse.UseVisualStyleBackColor = true;
            this.btn_AddCourse.Click += new System.EventHandler(this.Btn_AddCourse_Click);
            // 
            // lb_Courses
            // 
            this.lb_Courses.FormattingEnabled = true;
            this.lb_Courses.Location = new System.Drawing.Point(12, 185);
            this.lb_Courses.Name = "lb_Courses";
            this.lb_Courses.Size = new System.Drawing.Size(100, 95);
            this.lb_Courses.TabIndex = 9;
            this.lb_Courses.SelectedIndexChanged += new System.EventHandler(this.Lb_Courses_SelectedIndexChanged);
            // 
            // lbl_CourseCode
            // 
            this.lbl_CourseCode.AutoSize = true;
            this.lbl_CourseCode.Location = new System.Drawing.Point(7, 328);
            this.lbl_CourseCode.Name = "lbl_CourseCode";
            this.lbl_CourseCode.Size = new System.Drawing.Size(71, 13);
            this.lbl_CourseCode.TabIndex = 10;
            this.lbl_CourseCode.Text = "Course Code:";
            // 
            // lbl_CourseName
            // 
            this.lbl_CourseName.AutoSize = true;
            this.lbl_CourseName.Location = new System.Drawing.Point(7, 355);
            this.lbl_CourseName.Name = "lbl_CourseName";
            this.lbl_CourseName.Size = new System.Drawing.Size(74, 13);
            this.lbl_CourseName.TabIndex = 11;
            this.lbl_CourseName.Text = "Course Name:";
            // 
            // lbl_CourseDescription
            // 
            this.lbl_CourseDescription.AutoSize = true;
            this.lbl_CourseDescription.Location = new System.Drawing.Point(7, 384);
            this.lbl_CourseDescription.Name = "lbl_CourseDescription";
            this.lbl_CourseDescription.Size = new System.Drawing.Size(99, 13);
            this.lbl_CourseDescription.TabIndex = 12;
            this.lbl_CourseDescription.Text = "Course Description:";
            // 
            // lbl_CourseNoOfEvaluations
            // 
            this.lbl_CourseNoOfEvaluations.AutoSize = true;
            this.lbl_CourseNoOfEvaluations.Location = new System.Drawing.Point(7, 410);
            this.lbl_CourseNoOfEvaluations.Name = "lbl_CourseNoOfEvaluations";
            this.lbl_CourseNoOfEvaluations.Size = new System.Drawing.Size(155, 13);
            this.lbl_CourseNoOfEvaluations.TabIndex = 13;
            this.lbl_CourseNoOfEvaluations.Text = "Course Number Of Evaluations:";
            // 
            // lbl_ACourseCode
            // 
            this.lbl_ACourseCode.AutoSize = true;
            this.lbl_ACourseCode.Location = new System.Drawing.Point(84, 328);
            this.lbl_ACourseCode.Name = "lbl_ACourseCode";
            this.lbl_ACourseCode.Size = new System.Drawing.Size(0, 13);
            this.lbl_ACourseCode.TabIndex = 15;
            // 
            // lbl_ACourseName
            // 
            this.lbl_ACourseName.AutoSize = true;
            this.lbl_ACourseName.Location = new System.Drawing.Point(87, 355);
            this.lbl_ACourseName.Name = "lbl_ACourseName";
            this.lbl_ACourseName.Size = new System.Drawing.Size(0, 13);
            this.lbl_ACourseName.TabIndex = 16;
            // 
            // lbl_ACourseDescription
            // 
            this.lbl_ACourseDescription.AutoSize = true;
            this.lbl_ACourseDescription.Location = new System.Drawing.Point(112, 384);
            this.lbl_ACourseDescription.Name = "lbl_ACourseDescription";
            this.lbl_ACourseDescription.Size = new System.Drawing.Size(0, 13);
            this.lbl_ACourseDescription.TabIndex = 17;
            // 
            // lbl_ANoOfEvaluations
            // 
            this.lbl_ANoOfEvaluations.AutoSize = true;
            this.lbl_ANoOfEvaluations.Location = new System.Drawing.Point(168, 410);
            this.lbl_ANoOfEvaluations.Name = "lbl_ANoOfEvaluations";
            this.lbl_ANoOfEvaluations.Size = new System.Drawing.Size(0, 13);
            this.lbl_ANoOfEvaluations.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Section ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Section Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Semester";
            // 
            // txt_SectionID
            // 
            this.txt_SectionID.Location = new System.Drawing.Point(367, 2);
            this.txt_SectionID.Name = "txt_SectionID";
            this.txt_SectionID.Size = new System.Drawing.Size(100, 20);
            this.txt_SectionID.TabIndex = 23;
            // 
            // txt_SectionName
            // 
            this.txt_SectionName.Location = new System.Drawing.Point(367, 32);
            this.txt_SectionName.Name = "txt_SectionName";
            this.txt_SectionName.Size = new System.Drawing.Size(100, 20);
            this.txt_SectionName.TabIndex = 24;
            // 
            // btn_AddSection
            // 
            this.btn_AddSection.Location = new System.Drawing.Point(265, 125);
            this.btn_AddSection.Name = "btn_AddSection";
            this.btn_AddSection.Size = new System.Drawing.Size(75, 23);
            this.btn_AddSection.TabIndex = 26;
            this.btn_AddSection.Text = "Add Section";
            this.btn_AddSection.UseVisualStyleBackColor = true;
            this.btn_AddSection.Click += new System.EventHandler(this.Btn_AddSection_Click);
            // 
            // lb_Sections
            // 
            this.lb_Sections.FormattingEnabled = true;
            this.lb_Sections.Location = new System.Drawing.Point(268, 185);
            this.lb_Sections.Name = "lb_Sections";
            this.lb_Sections.Size = new System.Drawing.Size(100, 95);
            this.lb_Sections.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Teacher Name";
            // 
            // btn_AddSectionToCourse
            // 
            this.btn_AddSectionToCourse.Location = new System.Drawing.Point(157, 185);
            this.btn_AddSectionToCourse.Name = "btn_AddSectionToCourse";
            this.btn_AddSectionToCourse.Size = new System.Drawing.Size(75, 73);
            this.btn_AddSectionToCourse.TabIndex = 32;
            this.btn_AddSectionToCourse.Text = "Assign Section To Course";
            this.btn_AddSectionToCourse.UseVisualStyleBackColor = true;
            this.btn_AddSectionToCourse.Click += new System.EventHandler(this.Btn_AddSectionToCourse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Date Of Birth";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(489, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Street Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Telephone Number";
            // 
            // txt_TeacherName
            // 
            this.txt_TeacherName.Location = new System.Drawing.Point(593, 7);
            this.txt_TeacherName.Name = "txt_TeacherName";
            this.txt_TeacherName.Size = new System.Drawing.Size(121, 20);
            this.txt_TeacherName.TabIndex = 36;
            // 
            // DOB_Picker
            // 
            this.DOB_Picker.Location = new System.Drawing.Point(593, 33);
            this.DOB_Picker.Name = "DOB_Picker";
            this.DOB_Picker.Size = new System.Drawing.Size(121, 20);
            this.DOB_Picker.TabIndex = 37;
            // 
            // txt_StreetAddress
            // 
            this.txt_StreetAddress.Location = new System.Drawing.Point(593, 59);
            this.txt_StreetAddress.Name = "txt_StreetAddress";
            this.txt_StreetAddress.Size = new System.Drawing.Size(121, 20);
            this.txt_StreetAddress.TabIndex = 38;
            // 
            // txt_TelNumber
            // 
            this.txt_TelNumber.Location = new System.Drawing.Point(593, 138);
            this.txt_TelNumber.Name = "txt_TelNumber";
            this.txt_TelNumber.Size = new System.Drawing.Size(121, 20);
            this.txt_TelNumber.TabIndex = 39;
            // 
            // btn_AddFaculty
            // 
            this.btn_AddFaculty.Location = new System.Drawing.Point(724, 136);
            this.btn_AddFaculty.Name = "btn_AddFaculty";
            this.btn_AddFaculty.Size = new System.Drawing.Size(75, 23);
            this.btn_AddFaculty.TabIndex = 40;
            this.btn_AddFaculty.Text = "Add Faculty";
            this.btn_AddFaculty.UseVisualStyleBackColor = true;
            this.btn_AddFaculty.Click += new System.EventHandler(this.Btn_AddFaculty_Click);
            // 
            // lb_Faculty
            // 
            this.lb_Faculty.FormattingEnabled = true;
            this.lb_Faculty.Location = new System.Drawing.Point(531, 185);
            this.lb_Faculty.Name = "lb_Faculty";
            this.lb_Faculty.Size = new System.Drawing.Size(100, 95);
            this.lb_Faculty.TabIndex = 41;
            // 
            // btn_AssignFacultyToSection
            // 
            this.btn_AssignFacultyToSection.Location = new System.Drawing.Point(392, 185);
            this.btn_AssignFacultyToSection.Name = "btn_AssignFacultyToSection";
            this.btn_AssignFacultyToSection.Size = new System.Drawing.Size(75, 73);
            this.btn_AssignFacultyToSection.TabIndex = 42;
            this.btn_AssignFacultyToSection.Text = "Assign Faculty To Section";
            this.btn_AssignFacultyToSection.UseVisualStyleBackColor = true;
            this.btn_AssignFacultyToSection.Click += new System.EventHandler(this.Btn_AssignFacultyToSection_Click);
            // 
            // btn_LoadFile
            // 
            this.btn_LoadFile.Location = new System.Drawing.Point(639, 384);
            this.btn_LoadFile.Name = "btn_LoadFile";
            this.btn_LoadFile.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadFile.TabIndex = 43;
            this.btn_LoadFile.Text = "Load File";
            this.btn_LoadFile.UseVisualStyleBackColor = true;
            this.btn_LoadFile.Click += new System.EventHandler(this.Btn_LoadFile_Click);
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.Location = new System.Drawing.Point(639, 345);
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveFile.TabIndex = 46;
            this.btn_SaveFile.Text = "Save File";
            this.btn_SaveFile.UseVisualStyleBackColor = true;
            this.btn_SaveFile.Click += new System.EventHandler(this.Btn_SaveFile_Click);
            // 
            // Cmb_Semester
            // 
            this.Cmb_Semester.FormattingEnabled = true;
            this.Cmb_Semester.Location = new System.Drawing.Point(367, 58);
            this.Cmb_Semester.Name = "Cmb_Semester";
            this.Cmb_Semester.Size = new System.Drawing.Size(100, 21);
            this.Cmb_Semester.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(262, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Max No. Of Students";
            // 
            // txt_MaxNoOfStudents
            // 
            this.txt_MaxNoOfStudents.Location = new System.Drawing.Point(367, 85);
            this.txt_MaxNoOfStudents.Name = "txt_MaxNoOfStudents";
            this.txt_MaxNoOfStudents.Size = new System.Drawing.Size(100, 20);
            this.txt_MaxNoOfStudents.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(489, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(489, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Postal Code";
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(593, 86);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(121, 20);
            this.txt_City.TabIndex = 51;
            // 
            // txt_PostalCode
            // 
            this.txt_PostalCode.Location = new System.Drawing.Point(593, 112);
            this.txt_PostalCode.Name = "txt_PostalCode";
            this.txt_PostalCode.Size = new System.Drawing.Size(121, 20);
            this.txt_PostalCode.TabIndex = 52;
            // 
            // gb_Sections
            // 
            this.gb_Sections.Controls.Add(this.lbl_ASection);
            this.gb_Sections.Location = new System.Drawing.Point(12, 439);
            this.gb_Sections.Name = "gb_Sections";
            this.gb_Sections.Size = new System.Drawing.Size(169, 89);
            this.gb_Sections.TabIndex = 54;
            this.gb_Sections.TabStop = false;
            this.gb_Sections.Text = "Sections";
            // 
            // lbl_ASection
            // 
            this.lbl_ASection.AutoSize = true;
            this.lbl_ASection.Location = new System.Drawing.Point(34, 31);
            this.lbl_ASection.Name = "lbl_ASection";
            this.lbl_ASection.Size = new System.Drawing.Size(0, 13);
            this.lbl_ASection.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(639, 505);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 55;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 542);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.gb_Sections);
            this.Controls.Add(this.txt_PostalCode);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_MaxNoOfStudents);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cmb_Semester);
            this.Controls.Add(this.btn_SaveFile);
            this.Controls.Add(this.btn_LoadFile);
            this.Controls.Add(this.btn_AssignFacultyToSection);
            this.Controls.Add(this.lb_Faculty);
            this.Controls.Add(this.btn_AddFaculty);
            this.Controls.Add(this.txt_TelNumber);
            this.Controls.Add(this.txt_StreetAddress);
            this.Controls.Add(this.DOB_Picker);
            this.Controls.Add(this.txt_TeacherName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_AddSectionToCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_Sections);
            this.Controls.Add(this.btn_AddSection);
            this.Controls.Add(this.txt_SectionName);
            this.Controls.Add(this.txt_SectionID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ANoOfEvaluations);
            this.Controls.Add(this.lbl_ACourseDescription);
            this.Controls.Add(this.lbl_ACourseName);
            this.Controls.Add(this.lbl_ACourseCode);
            this.Controls.Add(this.lbl_CourseNoOfEvaluations);
            this.Controls.Add(this.lbl_CourseDescription);
            this.Controls.Add(this.lbl_CourseName);
            this.Controls.Add(this.lbl_CourseCode);
            this.Controls.Add(this.lb_Courses);
            this.Controls.Add(this.btn_AddCourse);
            this.Controls.Add(this.txt_NoOfEvaluation);
            this.Controls.Add(this.txt_Description);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Code);
            this.Controls.Add(this.lbl_NoOfEvaluation);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Code);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shivam Sood | 300856860";
            this.gb_Sections.ResumeLayout(false);
            this.gb_Sections.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Code;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_NoOfEvaluation;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.TextBox txt_NoOfEvaluation;
        private System.Windows.Forms.Button btn_AddCourse;
        private System.Windows.Forms.ListBox lb_Courses;
        private System.Windows.Forms.Label lbl_CourseCode;
        private System.Windows.Forms.Label lbl_CourseName;
        private System.Windows.Forms.Label lbl_CourseDescription;
        private System.Windows.Forms.Label lbl_CourseNoOfEvaluations;
        private System.Windows.Forms.Label lbl_ACourseCode;
        private System.Windows.Forms.Label lbl_ACourseName;
        private System.Windows.Forms.Label lbl_ACourseDescription;
        private System.Windows.Forms.Label lbl_ANoOfEvaluations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SectionID;
        private System.Windows.Forms.TextBox txt_SectionName;
        private System.Windows.Forms.Button btn_AddSection;
        private System.Windows.Forms.ListBox lb_Sections;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_AddSectionToCourse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TeacherName;
        private System.Windows.Forms.DateTimePicker DOB_Picker;
        private System.Windows.Forms.TextBox txt_StreetAddress;
        private System.Windows.Forms.TextBox txt_TelNumber;
        private System.Windows.Forms.Button btn_AddFaculty;
        private System.Windows.Forms.ListBox lb_Faculty;
        private System.Windows.Forms.Button btn_AssignFacultyToSection;
        private System.Windows.Forms.Button btn_LoadFile;
        private System.Windows.Forms.Button btn_SaveFile;
        private System.Windows.Forms.ComboBox Cmb_Semester;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_MaxNoOfStudents;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_PostalCode;
        private System.Windows.Forms.GroupBox gb_Sections;
        private System.Windows.Forms.Label lbl_ASection;
        private System.Windows.Forms.Button btn_Exit;
    }
}

