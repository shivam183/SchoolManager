using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSOOD_300856860_A1;

namespace CollegeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CourseManager courseMng = new CourseManager();
            #region Course
            newBlockMessage("Creating course Prog1");
            Course prog1 = new Course();
            Console.WriteLine(prog1);
            Console.WriteLine();

            newBlockMessage("Setting the values for Prog1");
            prog1.CourseCode = "COMP100";
            prog1.Name = "Programming 1";
            prog1.Description = "Programming1 description";
            prog1.NoOfEvaluations = 3;
            Console.WriteLine(prog1);

            newBlockMessage("Creating course Prog2");
            Course prog2 = new Course("COMP123", "Programming2") { Description = "prog 2 desc", NoOfEvaluations = 3 };
            Console.WriteLine(prog2);
            #endregion

            #region Course manager

            newBlockMessage("Creating course manager and export courses");
            courseMng.AddCourse(prog1);
            courseMng.AddCourse(prog2);

            try
            {
                courseMng.ExportCourses("ExportCourses.txt", '|');
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            #endregion

            #region Person
            newBlockMessage("Creating person Student1");
            Student student1 = new Student()
            {
                Name = "Bob",
                DOB = new DateTime(1990, 1, 1),
                Address = new Address("35 Elm St", "Toronto", "ON"),
                TelephoneNumber = 4161111111
            };
            Console.WriteLine(student1);

            newBlockMessage("Creating another person Student2");
            Student student2 = new Student()
            {
                Name = "John",
                DOB = new DateTime(1991, 12, 31),
                Address = new Address("35 Ontario St", "Toronto", "ON"),
                TelephoneNumber = 4162222222
            };
            Console.WriteLine(student2);

            newBlockMessage("Creating another person Student3");
            Student student3 = new Student()
            {
                Name = "Lee",
                DOB = new DateTime(1993, 3, 3),
                Address = new Address("3 Queen St", "Toronto", "ON"),
                TelephoneNumber = 4163333333
            };
            Console.WriteLine(student3);

            newBlockMessage("Creating another person Student4");
            Student student4 = new Student()
            {
                Name = "Wes",
                DOB = new DateTime(1994, 4, 4),
                Address = new Address("44 Bayview St", "Toronto", "ON"),
                TelephoneNumber = 4164444444
            };
            Console.WriteLine(student4);

            newBlockMessage("Creating person Faculty");
            Teacher aFaculty = new Teacher("Ann", new DateTime(1960, 1, 1))
            {
                Address = new Address("1 King St W", "Toronto", "ON"),
                TelephoneNumber = 4167654321
            };
            Console.WriteLine(aFaculty);
            #endregion

            #region Section 

            newBlockMessage("Creating section Section 1");
            Section aSec1 = new Section()
            {
                SectionId = "F01",
                Name = "Section 1",
                Semester = SemesterPeriod.FALL,
                //NoOfEvaluations = 2,
                Faculty = aFaculty
            };
            Console.WriteLine(aSec1);

            newBlockMessage("Creating section Section 2");
            Section aSec2 = new Section(prog1, 50, SemesterPeriod.WINTER)
            {
                SectionId = "W02",
                Name = "Section 2",
                //NoOfEvaluations = 5,
                Faculty = aFaculty
            };
            Console.WriteLine(aSec2);
            #endregion

            #region Add Sections
            newBlockMessage("Adding Sections");

            newBlockMessage("Adding invalid section (Section 3) to course prog1");
            Section aSec3 = new Section();
            try
            {
                prog1.AddSection(aSec3);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(prog1);

            newBlockMessage("Adding valid section to course prog1");
            aSec3.Name = "Section 3";
            aSec3.SectionId = "F03";
            aSec3.MaxNumberOfStudents = 10;
            aSec3.Semester = SemesterPeriod.FALL;

            try
            {
                prog1.AddSection(aSec3);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(prog1);

            newBlockMessage("Trying to change number of evaluations for the course that already has section assigned");
            try
            {
                prog1.NoOfEvaluations = 4;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            newBlockMessage("Trying to change number of evaluations for the course that does not have section assigned");
            try
            {
                prog2.NoOfEvaluations = 2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(prog2);

            newBlockMessage("Adding valid section already assigned to course prog2");
            try
            {
                prog2.AddSection(aSec3);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(prog2);




            newBlockMessage("Adding section 1 to prog1 course");
            try
            {
                prog2.AddSection(aSec1);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(prog1);
            #endregion

            #region Faculty's sections
            newBlockMessage("Section that faculty teaches");
            Console.WriteLine(aFaculty);
            Console.WriteLine(aFaculty.SectionsInfo());
            #endregion


            #region Add Student
            newBlockMessage("Adding Students");

            newBlockMessage("Creating new section Section 4 with max number of students 1");
            Section aSec4 = new Section()
            {
                SectionId = "F04",
                Name = "Section 4",
                MaxNumberOfStudents = 1,
                Semester = SemesterPeriod.FALL,
                Faculty = aFaculty
            };
            Console.WriteLine(aSec4);

            newBlockMessage("Adding Student to Section 4. Section is not added to a course");
            try
            {
                aSec4.AddStudent(student1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(aSec4);


            newBlockMessage("Adding section 4 to a course prog 1");
            try
            {
                prog1.AddSection(aSec4);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(prog1);

            newBlockMessage("Adding Student1 to Section 4. Section is added to a course");
            try
            {
                aSec4.AddStudent(student1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(aSec4);

            newBlockMessage("Adding Student2 to Section 4. Section is full");
            try
            {
                aSec4.AddStudent(student2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(aSec4);

            newBlockMessage("Adding three students to Section 3. ");
            try
            {
                aSec3.AddStudent(student2);
                aSec3.AddStudent(student3);
                aSec3.AddStudent(student4);
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(aSec3);

            newBlockMessage("Adding three students to Section 1. ");
            try
            {
                aSec1.AddStudent(student2);
                aSec1.AddStudent(student3);
                aSec1.AddStudent(student4);
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(aSec1);
            #endregion

            #region Evaluation
            newBlockMessage("Defining evaluations for Section 3. ");

            aSec3.DefineEvaluation(1, EvaluationType.TEST, 100, .5);
            aSec3.DefineEvaluation(2, EvaluationType.LAB, 80, .3);
            aSec3.DefineEvaluation(3, EvaluationType.QUIZ, 20, 0.2);

            aSec1.DefineEvaluation(1, EvaluationType.TEST, 100, .5);
            aSec1.DefineEvaluation(2, EvaluationType.ASSIGNMENT, 80, .5);

            Console.WriteLine(aSec3.GetEvaluationsInfo());
            #endregion

            #region Adding marks
            newBlockMessage("Adding marks for the evaluations to Section 3 and Section 4 ");

            newBlockMessage("Adding mark for a student not enrolled in the section.");
            try
            {
                aSec3.AddStudentMark(1, student1, 90);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            newBlockMessage("Adding mark for a student higher than max points for the evaluation.");
            try
            {
                aSec3.AddStudentMark(2, student2, 90);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            newBlockMessage("Adding marks for students ");
            try
            {
                aSec3.AddStudentMark(1, student2, 90);
                aSec3.AddStudentMark(1, student3, 40);
                aSec3.AddStudentMark(1, student4, 100);
                aSec3.AddStudentMark(2, student2, 70);
                aSec3.AddStudentMark(2, student4, 80);
                aSec3.AddStudentMark(3, student2, 15);
                aSec3.AddStudentMark(3, student3, 16);
                aSec3.AddStudentMark(3, student4, 20);

                aSec1.AddStudentMark(1, student2, 50);
                aSec1.AddStudentMark(1, student3, 40);
                aSec1.AddStudentMark(1, student4, 70);
                aSec1.AddStudentMark(2, student2, 70);
                aSec1.AddStudentMark(2, student4, 60);
                aSec1.AddStudentMark(2, student4, 50);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Section 3 evaluations");
            Console.WriteLine(aSec3.GetEvaluationsInfo());

            Console.WriteLine();
            Console.WriteLine("Section 1 evaluations");
            Console.WriteLine(aSec1.GetEvaluationsInfo());
            #endregion

            #region FinalMarks
            newBlockMessage("Calculate final marks for section 3");
            Console.WriteLine(aSec3.FinalMarksInfo());
            Console.WriteLine();
            newBlockMessage("Calculate final marks for section 1");
            Console.WriteLine(aSec1.FinalMarksInfo());
            Console.WriteLine();
            #endregion

            #region Transcript

            Console.WriteLine("Student 2:{0} transcript", student2.Name);
            Console.WriteLine(student2.PrintTranscript());
            #endregion

            #region Saving school and loading it again
            newBlockMessage("Saving the school info");
            try
            {
                courseMng.SaveSchoolInfo();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            newBlockMessage("Loading the school info");
            CourseManager newCourseMng = new CourseManager();
            try
            {
                newCourseMng.LoadSchool("user.dat");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            newBlockMessage("Display loaded courses");
            Course aCourse;
            Section aSection;
            for (int i = 0; i < newCourseMng.NumberOfCourses; i++)
            {
                aCourse = newCourseMng.Courses[i];
                Console.WriteLine(aCourse);
                Console.WriteLine("Course section with students");

                foreach (Section aSec in aCourse.Sections)
                {
                    Console.WriteLine(aSec);
                    Console.WriteLine();
                    Console.WriteLine("...And Marks:");
                    Console.WriteLine(aSec.GetEvaluationsInfo());
                    Console.WriteLine("...And Final Marks:");
                    Console.WriteLine(aSec.FinalMarksInfo());
                }
                Console.WriteLine("----------------------------------");
            }
            #endregion

            #region Loading additional courses
            newBlockMessage("Importing additional courses");
            try
            {
                newCourseMng.ImportCourses("AdditionalCourses.txt", ',');
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int i = 0; i < newCourseMng.NumberOfCourses; i++)
            {
                aCourse = newCourseMng.Courses[i];
                Console.WriteLine(aCourse);
            }
            #endregion

        }




        private static void newBlockMessage(string message)
        {
            Console.WriteLine("\n---------------{0}-------------", message);
        }
    }
}

