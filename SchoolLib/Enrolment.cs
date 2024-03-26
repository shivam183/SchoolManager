namespace SSOOD_300856860_A1
{
	using System;
	using System.Collections.Generic;

	[Serializable]
	public enum Grade { F, D, D_plus, C, C_plus, B, B_plus, A, A_plus }

	[Serializable]
	public class Enrolment
	{
		private Grade finalGrade;

		public Person Student { get; set; }

		public Section Section { get; set; }

		public string SectionId { get; }

		public List<Evaluation> Evaluations { get; set;  }

		public int NoOfEvaluations { get; }

		public Grade FinalGrade
		{
			get
			{
				CalculateFinalGrade();
				return finalGrade;
			}
			set
			{
				finalGrade = value;
			}
		}
		public void CalculateFinalGrade()
		{
			double grade = 0;
			int[] gradeRange = { 100, 90, 80, 75, 70, 65, 60, 55, 50 };
			int level = -1;
			for (int i = 0; i < NoOfEvaluations; i++)
			{
				grade += (Evaluations[i].Points / Evaluations[i].MaxPoints) * 100 * Evaluations[i].EvaluationWeight;
			}
			for (int x = 1; x < gradeRange.Length; x++)
			{
				if (grade >= gradeRange[x] && grade <= gradeRange[x - 1])
				{
					level = x;
					break;
				}
			}
			switch (level)
			{
				case 1:
					finalGrade = Grade.A_plus;
					break;
				case 2:
					finalGrade = Grade.A;
					break;
				case 3:
					finalGrade = Grade.B_plus;
					break;
				case 4:
					finalGrade = Grade.B;
					break;
				case 5:
					finalGrade = Grade.C_plus;
					break;
				case 6:
					finalGrade = Grade.C_plus;
					break;
				case 7:
					finalGrade = Grade.C;
					break;
				case 8:
					finalGrade = Grade.D_plus;
					break;
				case 9:
					finalGrade = Grade.D;
					break;
				default:
					finalGrade = Grade.F;
					break;
			}
		}
		public Enrolment(Person student, Section sectionId, int noOfEvaluations)
		{
			Student = student;
			SectionId = SectionId;
			NoOfEvaluations = noOfEvaluations;
			Evaluations = new List<Evaluation>();
		}
		//public override string ToString()
		//{
		//    return string.Format("Name of Student: {0} \nSection ID: {1} \nNo. of Evaluations: {2} ", Student.Name, Section.SectionId, NoOfEvaluations);
		//}
	}
}
