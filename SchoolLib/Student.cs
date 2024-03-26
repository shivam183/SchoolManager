namespace SSOOD_300856860_A1
{
	using System;

	[Serializable]
	public class Student : Person
	{
		public string PrintTranscript()
		{
			string result = string.Empty;
			for (int i = 0; i < Sections.Count; i++)
			{
				result += string.Format("\n" + Sections[i].Course.CourseCode);
				foreach (var item in Sections[i].Students)
				{
					if (item.Student.Name == Name)
					{
						result += string.Format(":" + item.FinalGrade);
					}
				}
			}
			return result;
		}
	}
}
