using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SSOOD_300856860_A1;
namespace SchoolLib.UnitTests
{
    [TestClass]
    public class EvaluationTest
    {
        [TestMethod]
        public void DefaultConstructor_GetInfo_returnsValue()
        {
            Evaluation evaluation = new Evaluation()
            {
                EvaluationWeight = 2.0,
                TypeOfEvaluation = EvaluationType.ASSIGNMENT,
                MaxPoints = 10,
                Points = 5.0

            };

            string expected = "Type of Evaluation: ASSIGNMENT \nMaximum Points: 10 \nEvaluation Weight: 200 \nPoints Scored: 5";

            Assert.AreEqual(expected, evaluation.ToString());
        }


        [TestMethod]
        public void NonDefaultConstructor_GetInfo_returnsValue()
        {
            Evaluation evaluation = new Evaluation(EvaluationType.ASSIGNMENT, 10, 2.0);

            string expected = "Type of Evaluation: ASSIGNMENT \nMaximum Points: 10 \nEvaluation Weight: 200 \nPoints Scored: 0";

            Assert.AreEqual(expected, evaluation.ToString());

        }
    }
}
