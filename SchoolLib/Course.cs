namespace SSOOD_300856860_A1
{
	using System;
	using System.Collections.Generic;

	[Serializable]
	public class Course
	{
		private int noOfEvaluations;
		public string CourseCode { get; set; }
		
		public string Name { get; set; }
		
		public string Description { get; set; }

		public int NoOfEvaluations
		{
			get
			{
				return noOfEvaluations;
			}
			set
			{
				if (Sections.Count == 0)
				{
					noOfEvaluations = value;
				}
				else
				{
					throw new Exception("Section is already assigned. Number of evaluations cannot be changed anymore.");
				}
			}
		}
		public List<Section> Sections { get; set; }
		
		public CourseManager Manager { get; set; }
		
		public int MaxNoOfSections { get; set; }
		
		public int NoOfSections { get; set; }

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
			NoOfSections++;
			aSec.Course = this;
		}
		public void AddSection(Section aSection)
		{
			if (aSection.Name != null || aSection.SectionId != null)
			{
				if (aSection.Course != null)
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
			Sections = new List<Section>();
			NoOfSections = 0;
		}
		public Course(string name) : this()
		{
			Name = name;
		}
		public Course(string courseCode, string name) : this(name)
		{
			CourseCode = courseCode;
		}
		public override string ToString()
		{
			string result = string.Format("Course Code: {0} ,Name : {1} ,Description: {2} ,No of Evaluation: {3} ,\nNo of Sections: {4}", CourseCode, Name, Description, NoOfEvaluations, NoOfSections);
			for (int i = 0; i < NoOfSections; i++)
			{
				result += string.Format("\n\t" + Name + ":" + Sections[i].Name);
			}
			return result;
		}
	}
}
