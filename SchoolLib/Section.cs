using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSOOD_300856860_A1;

namespace SSOOD_300856860_A1
{
    [Serializable]
    public enum SemesterPeriod
    {
        FALL, WINTER, SUMMER
    }
    [Serializable]
    public class Section
    {  // All of the fields 
        string sectionId;
        string name;
        int maxNumberOfStudents;
        int noOfEnrollments;
        List <Enrolment> students;
        Person faculty;
        Course course;
        SemesterPeriod semester;

        // All of the properties 
        public string SectionId
        {
            get
            {
                return sectionId;
            }

            set
            {
                sectionId = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public List<Enrolment> Students
        {
            get
            {
                return students;
            }


        }

        public Course Course
        {
            get
            {
                return course;
            }

            set
            {
                course = value;
            }
        }

        public SemesterPeriod Semester
        {
            get
            {
                return semester;
            }

            set
            {
                semester = value;
            }
        }
        public Person Faculty
        {
            get
            {
                return faculty;
            }

            set
            {
                faculty = value;
            }
        }
        
        public int MaxNumberOfStudents
        {
            get
            {
                return maxNumberOfStudents;
            }

            set
            {
                maxNumberOfStudents = value;
            }
        }

        public void AddStudent(Person aperson)
        {
            
            if (Course == null)
            {
                throw new Exception("Student can only be assigned to the section that is assigned to the course");
            }
            else if (noOfEnrollments == maxNumberOfStudents)
            {
                throw new Exception("Student Cannot be added. The section is full");
            }
            else
            {
                Enrolment aEnrolment = new Enrolment(aperson, this, Course.NoOfEvaluations);
                Students.Add(aEnrolment);
                noOfEnrollments++;
                aperson.Sections.Add(this);
                
            }


        }

        public void DefineEvaluation(int evaluationOrderNumber, EvaluationType evaluation, int maxPoints, double evaluationWeight)
        {
         
            for (int i = 0; i < Students.Count; i++)
            {
                
                Students[i].Evaluations.Add(new Evaluation(evaluation, maxPoints, evaluationWeight));
                
            }

        }
        public void AddStudentMark(int evaluationOrderNumber, Person astudent, int points)
        {
            bool check = false;
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].Student == astudent)
                {
                    check = true;
                    if (points > students[i].Evaluations[evaluationOrderNumber - 1].MaxPoints)
                    {
                        throw new Exception("Points are more than the max number of points for the evaluation");
                    }
                    else
                    {
                        students[i].Evaluations[evaluationOrderNumber - 1].Points = points;
                    }
                }
            }
            if (check == false)
            {
                throw new Exception("Student " + astudent.Name + " is not in the section");
            }

        }
        public string GetEvaluationsInfo()
        {
            string result = "";

            for (int i = 0; i < Students.Count-1; i++)
            {
                result += String.Format("   {0}.{1}[{2}]", i, students[0].Evaluations[i].TypeOfEvaluation, students[0].Evaluations[i].MaxPoints);
            }
            
            result += "\n";

            for (int i = 0; i < Students.Count; i++)
            {
                result += String.Format("{0,5}", Students[i].Student.Name);
                for (int j = 0; j < course.NoOfEvaluations; j++)
                {
                    Evaluation eval = Students[i].Evaluations[j];
                    result += String.Format("{0,6}/{1,2}", eval.Points, (eval.Points / eval.MaxPoints) * 100 * eval.EvaluationWeight);
                }
                result += "\n";
            }
            return result;

        }
        public string FinalMarksInfo()
        {
            string result = "";
            for (int i = 0; i < Students.Count; i++)
            {
                result += string.Format(Students[i].Student.Name + ":" + Students[i].FinalGrade + "\n");
            }

            
            return result;
        }

        //Get all the info
        public override string ToString()
        {
            string result;
            result = string.Format("Section ID: {0} ,Name: {1} ,Max no. of students: {2} ,Semester Time: {3}  ", SectionId, Name, MaxNumberOfStudents, semester);
            if (faculty == null)
            {
                result += "\n\tFaculty:";
            }
            else
            {
                result += "\n\tFaculty: " + faculty.Name;
                Faculty.Sections.Add(this);
            }

            result += "\nNumber of Students: " + noOfEnrollments;

            for (int i = 0; i < noOfEnrollments; i++)
            {
                result += "\n\t" + students[i].Student.Name;
            }


            return result;
        }

        //All Constructors
        //Default Constructor
        public Section()
        {
            MaxNumberOfStudents = 40;
            noOfEnrollments = 0;
            students = new List<Enrolment>();
            course = new Course();

        }
        
        public Section(Course courseCode, int maxNoOfEnrollments, SemesterPeriod semester)
        {
            this.course = courseCode;
            this.maxNumberOfStudents = maxNoOfEnrollments;
            this.semester = semester;

        }



    }
}
