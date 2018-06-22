using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SSOOD_300856860_A1
{
    [Serializable]
    public class CourseManager
    {
        List <Course> courses;
        int numberOfCourses;
        List<Exception> exceptions;

        bool CourseAlreadyExists(Course course)
        {
            foreach (Course c in courses)
            {
                if (c.CourseCode == course.CourseCode)
                {
                    return true;
                }
            }

            return false;
        }
        public int NumberOfCourses
        {
            get { return numberOfCourses; }
            set { numberOfCourses = value; }

        }

        public List<Course> Courses
        {
            get
            {
                return courses;
            }

            set
            {
                courses = value;
            }
        }

        public CourseManager()
        {
            Courses = new List<Course>();
            exceptions = new List<Exception>();
        }


        public void AddCourse(Course aCourse)
        {

            Courses.Add(aCourse);
            numberOfCourses++;
          

        }

        public void ExportCourses(string fileName, char Delim)
        {
            FileStream stream = null;
            StreamWriter writer;
            try
            {
                stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(stream);

                for (int i = 0; i < numberOfCourses; i++)
                {
                    Course aCourse = courses[i];
                    writer.WriteLine("{0}{1}{2}{1}{3}{1}{4}", aCourse.CourseCode, Delim, aCourse.Name, aCourse.Description, aCourse.NoOfEvaluations);
                }

                writer.Close();
            }

            finally
            {
                stream.Close();
            }
        }

        public void ImportCourses(string fileName, char Delim)
        {
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                const int Limit = 400;
                string[] temp;

                using (StreamReader reader = new StreamReader(stream))
                {
                    int index = 0;
                    while (!reader.EndOfStream && index <= Limit)
                    {
                        //var line = reader.ReadLine();
                        //var array = line.Split(Delim);
                        temp = reader.ReadLine().Split(Delim);

                        if (temp.Length != 4)
                        {
                            //exceptions.Add(new Exception("Invalid number of fields in record #" + index));
                            //throw new Exception("-->Invalid number of fields in record #"+ index);



                        }


                        Course C = new Course
                        {
                            CourseCode = temp[0],
                            Name = temp[1],
                            Description = temp[2]
                        };

                        int evals;
                        if (int.TryParse(temp[3], out evals))
                        {
                            C.NoOfEvaluations = evals;


                        }
                        else
                        {
                            //exceptions.Add(new Exception("-->Number of evaluations in record" + index + "is not in correct format."));
                            // throw new Exception();

                        }




                        if (!CourseAlreadyExists(C))
                        {
                           // courses[index++] = C;
                        }
                        else
                        {
                            //exceptions.Add(new Exception("-->Course code in record" + index + "is in use"));
                            // throw new Exception();



                            //finally
                            //{
                            //    index++;
                            //}
                            Courses.Add(C);

                            Console.WriteLine(C);

                        }


                    }
                }
            }
        }


        public void SaveSchoolInfo()
        {
          
            BinaryFormatter bformatter = new BinaryFormatter();
            FileStream stream = new FileStream("user.dat", FileMode.Create, FileAccess.Write);
            bformatter.Serialize(stream, courses);
            stream.Close();


        }

        public void LoadSchool(string fileName)
        {
            
            BinaryFormatter bformatter = new BinaryFormatter();
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            Courses = (List<Course>)bformatter.Deserialize(stream);
            stream.Close();


            for (int i = 0; i < numberOfCourses; i++)
            {
                Course C1 = courses[i];
                Console.WriteLine(C1);

            }

            


        }



    }
}
