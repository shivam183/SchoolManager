using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSOOD_300856860_A1;

namespace SchoolLib.UnitTests
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        public void NonDefaultConstructor_getInfo_ReturnsValue()
        {
            Person person = new Person("Shivam", new DateTime(1990, 1, 1))
            {
                TelephoneNumber = 6479368241
            };

            string expected = "Reg No: 1 ,Name: Shivam ,Date Of Birth: 1990-01-01 12:00:00 AM \nAddress: Street:  City:  State:  ,Tel:6479368241";
            Assert.AreEqual(expected, person.ToString());

        }
    }
}
