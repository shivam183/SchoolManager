using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSOOD_300856860_A1;

namespace SchoolLib.UnitTests
{

    [TestClass]
    public class SectionTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddStudent_NoOfEnrollmentsisGreaterThanMaxNoOfEnrollments_ReturnsException()
        {
            Course course = new Course();
            Section section = new Section() { MaxNumberOfStudents = 1 };
            course.AddSection(section);
            Person person1 = new Person();
            Person person2 = new Person();

            try
            {
                section.AddStudent(person1);
                section.AddStudent(person2);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Student Cannot be added. The section is full", ex.Message);
                throw;
            }
        }

        [TestMethod]
        
        public void AddStudent_CourseIsNotAddedToSection_ReturnsException()
        {
            Section section = new Section();
            Person person1 = new Person();

            try
            {
                section.AddStudent(person1);

            }
            catch (Exception ex)
            {
                Assert.AreEqual("Student can only be assigned to the section that is assigned to the course", ex.Message);
                throw;
            }
        }


        [TestMethod] 
        public void AddStudent_StudentAddedToCourse_FirstIndexValueNotNull()
        {

            Course course = new Course();
            Section section = new Section() { Name = "COM", SectionId = "7896" };
            course.AddSection(section);
            Person person = new Person();
            section.AddStudent(person);

            Assert.IsNotNull(section.Students[0]);



        }

        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //public void AddStudentMark_PointsMoreThanMaxPoints_ReturnsException()
        //{
        //    Course course = new Course();
        //    Section section = new Section() { Name = "SH", SectionId = "qwe" };
        //    course.AddSection(section);
        //    Person person = new Person();
        //    section.AddStudent(person);
        //    try
        //    {
        //        section.AddStudentMark(1, person, 120);
        //    }
        //    catch (Exception ex)
        //    {
        //        Assert.AreEqual("Points are more than the max number of points for the evaluation", ex.Message);
        //        throw;
        //    }

        //}

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AddStudentMark_StudentNotInTheSection_ReturnsException()
        {
            Course course = new Course();
            Section section = new Section() { Name = "SH", SectionId = "qwe" };
            course.AddSection(section);
            Person person = new Person();

            try
            {
                section.AddStudentMark(1, person, 120);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Student " + person.Name + " is not in the section", ex.Message);
                throw;
            }
        }

        //[TestMethod]
        //public void AddStudentMark_MarksAreAddedToTheStudent()
        //{
        //    Course course = new Course();
        //    Section section = new Section() { Name = "SH", SectionId = "qwe" };
        //    course.AddSection(section);
        //    Person person = new Person();

        //    section.AddStudentMark(1, person, 80);


        //}

        //[TestMethod]
        //public void FinalMarksInfo_DisplaysFinalMarks()
        //{
        //    Course course = new Course();
        //    Section section = new Section() { Name = "SH", SectionId = "qwe" };
        //    course.AddSection(section);
        //    Person person = new Person();
        //    section.AddStudent(person);

        //    section.AddStudentMark(1, person, 80);

        //    section.FinalMarksInfo();

        //    Assert.AreEqual(_Enrolment.A, _Enrolment.A);



        //}
    }
}
