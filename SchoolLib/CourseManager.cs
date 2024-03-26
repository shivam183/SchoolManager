namespace SSOOD_300856860_A1
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Runtime.Serialization.Formatters.Binary;

	[Serializable]
	public class CourseManager
	{
		public int NumberOfCourses { get; set; }
		public List<Course> Courses { get; set; }
		public CourseManager()
		{
			Courses = new List<Course>();
		}
		public void AddCourse(Course aCourse)
		{
			Courses.Add(aCourse);
			NumberOfCourses++;
		}
		public void ExportCourses(string fileName, char delim)
		{
			FileStream stream = null;
			StreamWriter writer;
			try
			{
				stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
				writer = new StreamWriter(stream);
				for (int i = 0; i < NumberOfCourses; i++)
				{
					Course aCourse = Courses[i];
					writer.WriteLine("{0}{1}{2}{1}{3}{1}{4}", aCourse.CourseCode, delim, aCourse.Name, aCourse.Description, aCourse.NoOfEvaluations);
				}
				writer.Close();
			}
			finally
			{
				stream.Close();
			}
		}
		public void ImportCourses(string fileName, char delim)
		{
			Courses = new List<Course>();

			using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
			{
				using (StreamReader reader = new StreamReader(stream))
				{
					while (!reader.EndOfStream)
					{
						string[] components = reader.ReadLine().Split(delim);

						if (components.Length != 4)
						{
							continue;
						}

						string courseCode = components[0];
						string courseName = components[1];
						string courseDescription = components[2];
						
						if (!int.TryParse(components[3], out int noOfEvaluations))
						{
							continue;
						}

						Course course = new Course()
						{
							CourseCode = courseCode,
							Name = courseName,
							Description = courseDescription,
							NoOfEvaluations = noOfEvaluations
						};

						AddCourse(course);
					}
				}
			}
		}
		public void SaveSchoolInfo()
		{
			BinaryFormatter bformatter = new BinaryFormatter();
			FileStream stream = new FileStream("user.dat", FileMode.Create, FileAccess.Write);
			bformatter.Serialize(stream, Courses);
			stream.Close();
		}
		public void LoadSchool(string fileName)
		{
			BinaryFormatter bformatter = new BinaryFormatter();
			FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			Courses = (List<Course>)bformatter.Deserialize(stream);
			stream.Close();
		}
	}
}
