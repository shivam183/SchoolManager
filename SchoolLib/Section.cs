namespace SSOOD_300856860_A1
{
	using System;
	using System.Collections.Generic;

	[Serializable]
	public enum SemesterPeriod { FALL, WINTER, SUMMER }

	[Serializable]
	public class Section
	{
		public string SectionId { get; set; }

		public string Name { get; set; }

		public List<Enrolment> Students { get; set; }

		public Course Course { get; set; }

		public SemesterPeriod Semester { get; set; }

		public Person Faculty { get; set; }

		public int MaxNumberOfStudents { get; set; }

		private int NoOfEnrollments { get; set; }

		public void AddStudent(Person aperson)
		{
			if (Course == null)
			{
				throw new Exception("Student can only be assigned to the section that is assigned to the course");
			}
			else if (NoOfEnrollments == MaxNumberOfStudents)
			{
				throw new Exception("Student Cannot be added. The section is full");
			}
			else
			{
				Enrolment aEnrolment = new Enrolment(aperson, this, Course.NoOfEvaluations);
				Students.Add(aEnrolment);
				NoOfEnrollments++;
				aperson.Sections.Add(this);
			}
		}
		public void DefineEvaluation(int evaluationOrderNumber, EvaluationType evaluation, int maxPoints, double evaluationWeight)
		{
			for (int i = 0; i < Students.Count; i++)
			{
				Students[i].Evaluations.Insert(evaluationOrderNumber - 1, new Evaluation(evaluation, maxPoints, evaluationWeight));
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
					if (points > Students[i].Evaluations[evaluationOrderNumber - 1].MaxPoints)
					{
						throw new Exception("Points are more than the max number of points for the evaluation");
					}
					else
					{
						Students[i].Evaluations[evaluationOrderNumber - 1].Points = points;
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
			string result = string.Empty;
			for (int i = 0; i < Students.Count - 1; i++)
			{
				result += String.Format("   {0}.{1}[{2}]", i, Students[0].Evaluations[i].EvaluationType, Students[0].Evaluations[i].MaxPoints);
			}
			result += "\n";
			for (int i = 0; i < Students.Count; i++)
			{
				result += String.Format("{0,5}", Students[i].Student.Name);
				for (int j = 0; j < Course.NoOfEvaluations; j++)
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
			string result = string.Empty;
			for (int i = 0; i < Students.Count; i++)
			{
				result += string.Format(Students[i].Student.Name + ":" + Students[i].FinalGrade + "\n");
			}
			return result;
		}
		public override string ToString()
		{
			string result = string.Format("Section ID: {0}, Name: {1}, Max no. of students: {2}, Semester Time: {3}", SectionId, Name, MaxNumberOfStudents, Semester);
			if (Faculty == null)
			{
				result += "\n\tFaculty:";
			}
			else
			{
				result += "\n\tFaculty: " + Faculty.Name;
				Faculty.Sections.Add(this);
			}
			result += "\nNumber of Students: " + NoOfEnrollments;
			for (int i = 0; i < NoOfEnrollments; i++)
			{
				result += "\n\t" + Students[i].Student.Name;
			}
			return result;
		}
		public Section()
		{
			MaxNumberOfStudents = 40;
			NoOfEnrollments = 0;
			Students = new List<Enrolment>();
			Course = new Course();
		}
		public Section(Course courseCode, int maxNoOfEnrollments, SemesterPeriod semester)
		{
			Course = courseCode;
			MaxNumberOfStudents = maxNoOfEnrollments;
			Semester = semester;
		}
	}
}
