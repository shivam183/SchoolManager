using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SSOOD_300856860_A1;
namespace WindowsFormsApp1
{
	[Serializable()]
	public partial class Form1 : Form
	{
		private readonly CourseManager Manager;
		public Form1()
		{
			InitializeComponent();
			Cmb_Semester.DataSource = Enum.GetValues(typeof(SemesterPeriod));
			Manager = new CourseManager();
		}
		private void Btn_AddCourse_Click(object sender, EventArgs e)
		{
			Course course = new Course()
			{
				CourseCode = txt_Code.Text,
				Name = txt_Name.Text,
				Description = txt_Description.Text,
				NoOfEvaluations = Convert.ToInt32(txt_NoOfEvaluation.Text)
			};
			MessageBox.Show("Course Added Sucessfully", "Add Course");
			lb_Courses.Items.Add(course);
			lb_Courses.DisplayMember = nameof(course.Name);

			txt_Code.ResetText();
			txt_Name.ResetText();
			txt_Description.ResetText();
			txt_NoOfEvaluation.ResetText();
		}
		private void Lb_Courses_SelectedIndexChanged(object sender, EventArgs e)
		{
			Course course = lb_Courses.SelectedItem as Course;

			if (course != null)
			{
				lbl_ACourseCode.Text = course.CourseCode;
				lbl_ACourseName.Text = course.Name;
				lbl_ACourseDescription.Text = course.Description;
				lbl_ANoOfEvaluations.Text = course.NoOfEvaluations.ToString();

				string temp = "";
				if (course.Sections.Count != 0)
				{
					foreach (var item in course.Sections)
					{
						temp += string.Format(item.Name.ToString() + "\n");
					}
				}
				else
				{
					lbl_ASection.Text = "";
				}

				lbl_ASection.Text = temp;
			}
		}
		private void Btn_AddSection_Click(object sender, EventArgs e)
		{
			Section section = new Section()
			{
				SectionId = txt_SectionID.Text,
				Name = txt_SectionName.Text,
				Semester = (SemesterPeriod)Cmb_Semester.SelectedValue,
				MaxNumberOfStudents = Convert.ToInt32(txt_MaxNoOfStudents.Text)
			};

			MessageBox.Show("Section Added Sucessfully", "Add Section");
			lb_Sections.Items.Add(section);
			lb_Sections.DisplayMember = nameof(section.Name);

			txt_SectionID.ResetText();
			txt_SectionName.ResetText();
			Cmb_Semester.ResetText();
			txt_MaxNoOfStudents.ResetText();
		}
		private void Btn_AddFaculty_Click(object sender, EventArgs e)
		{
			Teacher teacher = new Teacher(txt_TeacherName.Text, DOB_Picker.Value)
			{
				Address = new Address(txt_StreetAddress.Text, txt_City.Text, txt_PostalCode.Text),
				TelephoneNumber = Convert.ToInt64(txt_TelNumber.Text)
			};

			MessageBox.Show("Faculty Added Sucessfully", "Add Faculty");

			lb_Faculty.Items.Add(teacher);

			lb_Faculty.DisplayMember = nameof(teacher.Name);

			txt_TeacherName.ResetText();
			DOB_Picker.ResetText();
			txt_StreetAddress.ResetText();
			txt_City.ResetText();
			txt_PostalCode.ResetText();
			txt_TelNumber.ResetText();
		}
		private void Btn_AddSectionToCourse_Click(object sender, EventArgs e)
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
		private void Btn_AssignFacultyToSection_Click(object sender, EventArgs e)
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
		private void Btn_SaveFile_Click(object sender, EventArgs e)
		{
			try
			{
				Manager.Courses = lb_Courses.Items.Cast<Course>().ToList();
				Manager.SaveSchoolInfo();
				MessageBox.Show("Information Saved Sucessfully!", "Save Information");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void Btn_LoadFile_Click(object sender, EventArgs e)
		{
			try
			{
				Manager.LoadSchool("user.dat");

				foreach (Course course in Manager.Courses)
				{
					lb_Courses.Items.Add(course);
					lb_Courses.DisplayMember = nameof(course.Name);

					foreach (Section section in course.Sections)
					{
						lb_Sections.Items.Add(section);
						lb_Sections.DisplayMember = nameof(section.Name);

						lb_Faculty.Items.Add(section.Faculty);
						lb_Faculty.DisplayMember = nameof(section.Faculty.Name);
					}
				}

				MessageBox.Show("Information Loaded Sucessfully", "Load Information");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void Btn_Exit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
