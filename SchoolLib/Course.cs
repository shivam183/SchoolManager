using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSOOD_300856860_A1
{
    [Serializable]
    public class Course
    {
        string courseCode;
        string name;
        string description;
        int noOfEvaluations;
        int noOfSections;
        int maxNoOfSections;
      
        CourseManager manager;
        List<Section> sections;

        public string CourseCode
        {
            get
            {
                return courseCode;
            }
            set
            {
                courseCode = value;
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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int NoOfEvaluations
        {
            get
            {
                return noOfEvaluations;
            }

            set
            {

                if (Sections.Count== 0)
                {
                    noOfEvaluations = value;
                }
                else
                {

                    throw new Exception("Section is already assigned. Number of evaluations cannot be changed anymore.");
                }

            }
        }

        public List<Section> Sections
        {
            get
            {
                return sections;
            }

            set
            {
                sections = value;
            }
        }

        public CourseManager Manager
        {
            get
            {
                return manager;
            }

            set
            {
                manager = value;
            }
        }


        public int MaxNoOfSections
        {
            get { return maxNoOfSections; }
            set { maxNoOfSections = value; }
        }

        public int NoOfSections
        {
            get { return noOfSections; }
            set { noOfSections = value; }
        }

        public void AddSection(string sectionID, SemesterPeriod semesterPeriod, string sectionName)
        {

            Section aSec = new Section()
            {
                Name = sectionName,
                MaxNumberOfStudents = 30,
                SectionId = sectionID,
                Semester = semesterPeriod
            };

            Sections.Add(aSec);
            noOfSections++;
            aSec.Course = this;

        }

        public void AddSection(Section aSection)
        {
            
            if(aSection.Name != null || aSection.SectionId != null)
            {
                if(aSection.Course!=null)
                {
                    Sections.Add(aSection);
                    NoOfSections++;
                    aSection.Course = this;
        
                }
                else
                {
                    throw new Exception("Section is already assigned to " + aSection.Course.Name + " course");
                }
            }
            else
            {
                throw new Exception("Section is Not Valid");
            }
            
        }


        public Course()
        {
            MaxNoOfSections = 20;
            sections = new List<Section>();
            NoOfSections = 0;

        }

        public Course(string name):this()
        {

            this.name = name;

        }

        public Course(string courseCode, string name) : this(name)
        {
            this.CourseCode = courseCode;
           

        }

        public override string ToString()
      
        {

            string result;
            result = string.Format("Course Code: {0} ,Name : {1} ,Description: {2} ,No of Evaluation: {3} ,\nNo of Sections: {4}", CourseCode, Name, Description, NoOfEvaluations, noOfSections);

            for (int i = 0; i < noOfSections; i++)
            {
                result += string.Format("\n\t" + name + ":"+ Sections[i].Name );
            }

            return result;
        }
    }
}
