using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSOOD_300856860_A1;
namespace SchoolLib.UnitTests
{
	[TestClass]
	public class CourseTest
	{
		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void AddSection_SectionAddedToCourseWithNoNameAndSectionId_ReturnsException()
		{
			var course = new Course();
			var section = new Section();
			try
			{
				course.AddSection(section);
			}
			catch (Exception ex)
			{
				Assert.AreEqual("Section is Not Valid", ex.Message);
				throw;
			}
		}
		[TestMethod]
		[ExpectedException(typeof(Exception))]
		public void NoOFEvaluationsProperty_ChangeEvaluationAfterSectionAddedToCourse_ReturnsException()
		{
			var course = new Course() { NoOfEvaluations = 4 };
			var section = new Section() { Name = "Shivam", SectionId = "QWE" };
			course.AddSection(section);
			try
			{
				course.NoOfEvaluations = 5;
			}
			catch (Exception ex)
			{
				Assert.AreEqual("Section is already assigned. Number of evaluations cannot be changed anymore.", ex.Message);
				throw;
			}
		}
		[TestMethod]
		public void AddSection_NoOfSectionisMoreThanMaxNoOfSections_ReturnsException()
		{
			var course = new Course() { MaxNoOfSections = 1 };
			var section = new Section() { Name = "Sh", SectionId = "QWE" };
			var section1 = new Section() { Name = "Sh", SectionId = "QWE" };
			try
			{
				course.AddSection(section);
				course.AddSection(section1);
			}
			catch (Exception ex)
			{
				Assert.AreEqual("Section is already assigned to " + section.Course.Name + " course", ex.Message);
				throw;
			}
		}
		[TestMethod]
		public void AddSection_NoOfSectionisLessThanMaxNoOfSections_FirstIndexValueNotNull()
		{
			var course = new Course();
			var section = new Section() { Name = "Sh", SectionId = "QWE" };
			course.AddSection(section);
			Assert.IsNotNull(course.Sections[0]);
		}
		[TestMethod]
		public void AddSection_TestingOverloadedMethod_ArrayIsNotNull()
		{
			var course = new Course();
			var section = new Section();
			course.AddSection("QWE", SemesterPeriod.FALL, "SH");
			Assert.IsNotNull(course.Sections[0]);
		}
	}
}
