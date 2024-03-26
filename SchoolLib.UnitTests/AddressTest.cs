using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSOOD_300856860_A1;
namespace SchoolLib.UnitTests
{
	[TestClass]
	public class AddressTest
	{
		[TestMethod]
		public void AddressTest_DefaultConstructor_getInfo()
		{
			Address add = new Address()
			{
				StreetAddress = "1 Younge Street",
				City = "Toronto",
				PostalCode = "M9W4T5",
			};
			string expected = "Street Address:1 Younge Street City:Toronto PostalCode:M9W4T5";
			Assert.AreEqual(expected, add.ToString());
		}
		[TestMethod]
		public void AddressTest_NonDefaultConstructor()
		{
			bool exceptionThrown = false;
			try
			{
				Address add = new Address(null, "Toronto", "M9W6B4");
			}
			catch (Exception)
			{
				exceptionThrown = true;
			}
			Assert.IsFalse(exceptionThrown);
			try
			{
				Address add = new Address("1YongeStreet", null, "M9W6B4");
			}
			catch (Exception)
			{
				exceptionThrown = true;
			}
			Assert.IsFalse(exceptionThrown);
			try
			{
				Address add = new Address("1Yonge Street", "Toronto", null);
			}
			catch (Exception)
			{
				exceptionThrown = true;
			}
			Assert.IsFalse(exceptionThrown);
		}
	}
}
