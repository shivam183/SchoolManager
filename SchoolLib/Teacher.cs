namespace SSOOD_300856860_A1
{
	using System;

	[Serializable]
	public class Teacher : Person
	{
		public Teacher(string name, DateTime DOB) : base(name, DOB)
		{
		}
		public string SectionsInfo()
		{
			string result = string.Empty;
			for (int i = 0; i < Sections.Count; i++)
			{
				result += ("\n\t" + Sections[i].Name);
			}
			return result;
		}
	}
}
