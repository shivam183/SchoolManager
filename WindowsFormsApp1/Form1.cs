using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SSOOD_300856860_A1;

namespace WindowsFormsApp1
{
    [Serializable()]
    public partial class Form1 : Form
    {
        CourseManager Coursemanager;
        Course course;
        Section section;
        Teacher teacher;

        public Form1()
        {
            InitializeComponent();
            Cmb_Semester.DataSource = Enum.GetValues(typeof(SemesterPeriod));

        }

        private void btn_AddCourse_Click(object sender, EventArgs e)
        {
            Coursemanager = new CourseManager();
            course = new Course()
            {
                CourseCode = txt_Code.Text,
                Name = txt_Name.Text,
                Description = txt_Description.Text,
                NoOfEvaluations = Convert.ToInt32(txt_NoOfEvaluation.Text)

            };


            MessageBox.Show("Course Added Sucessfully", "Add Course");
            lb_Courses.Items.Add(course);
            lb_Courses.DisplayMember = nameof(course.Name);
            Coursemanager.Courses.Add(course);

        }

        private void lb_Courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course Course = lb_Courses.SelectedItem as Course;
            lbl_ACourseCode.Text = Course.CourseCode;
            lbl_ACourseName.Text = Course.Name;
            lbl_ACourseDescription.Text = Course.Description;
            lbl_ANoOfEvaluations.Text = Course.NoOfEvaluations.ToString();

            string temp = "";
            if (course.Sections.Count != 0)
            {
                foreach (var item in course.Sections)
                {

                    temp += String.Format(item.Name.ToString() + "\n");
                }
            }
            else
                lbl_ASection.Text = "";

            lbl_ASection.Text += temp;



        }


        private void btn_AddSection_Click(object sender, EventArgs e)
        {
            course = new Course();
            section = new Section()
            {
                SectionId = txt_SectionID.Text,
                Name = txt_SectionName.Text,
                Semester = (SemesterPeriod)Cmb_Semester.SelectedValue,
                MaxNumberOfStudents = Convert.ToInt32(txt_MaxNoOfStudents.Text)
            };
            MessageBox.Show("Section Added Sucessfully", "Add Section");
            lb_Sections.Items.Add(section);
            lb_Sections.DisplayMember = nameof(section.Name);
            course.Sections.Add(section);
         

        }

        private void btn_AddFaculty_Click(object sender, EventArgs e)
        {

            teacher = new Teacher(txt_TeacherName.Text, DOB_Picker.Value)
            {
                Address = new Address(txt_StreetAddress.Text, txt_City.Text, txt_PostalCode.Text),
                TelephoneNumber = Convert.ToInt64(txt_TelNumber.Text)
            };
            MessageBox.Show("Faculty Added Sucessfully", "Add Faculty");
            lb_Faculty.Items.Add(teacher);
            lb_Faculty.DisplayMember = nameof(teacher.Name);
            for (int i = 0; i < teacher.Sections.Count; i++)
            {
                teacher.Sections[i].Faculty = teacher;
            }

        }


        private void btn_AddSectionToCourse_Click(object sender, EventArgs e)
        {
            Course course = lb_Courses.SelectedItem as Course;
            Section section = lb_Sections.SelectedItem as Section;

            try
            {
                course.AddSection(section);
                MessageBox.Show(String.Format("{0} is sucessfully assigned to {1}", section.Name, course.Name), "Add Section to Course");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_AssignFacultyToSection_Click(object sender, EventArgs e)
        {
            Section section = lb_Sections.SelectedItem as Section;
            Teacher teacher = lb_Faculty.SelectedItem as Teacher;

            try
            {
                section.Faculty = teacher;
                MessageBox.Show(String.Format("{0} is successfully assigned to {1}", teacher.Name, section.Name), "Add Teacher to Section");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            Coursemanager = new CourseManager();
            try
            {
                Coursemanager.SaveSchoolInfo();
                MessageBox.Show("Information Saved Sucessfully!", "Save Information");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            Coursemanager = new CourseManager();
            try
            {
                Coursemanager.LoadSchool("user.dat");
                MessageBox.Show("Information Loaded Sucessfully", "Load Information");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
