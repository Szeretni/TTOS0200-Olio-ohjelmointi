using Microsoft.VisualStudio.TestTools.UnitTesting;
using L12_assignment_05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L12_assignment_05.Tests
{
    [TestClass()]
    public class ArrayCalcsTests
    {
        [TestMethod()]
        public void SumTest()
        {
            //arrange
            double num1 = 5.2;
            double num2 = 2.01;
            double expected = 7.21;

            //act
            double[] dArray = { num1, num2 };
            double actual = ArrayCalcs.Sum(dArray);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void AverageTest()
        {
            //arrange
            double num1 = 5.2;
            double num2 = 2;
            double expected = 3.6;

            //act
            double[] dArray = { num1, num2 };
            double actual = ArrayCalcs.Average(dArray);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MinTest()
        {
            //arrange
            double num1 = 5.2;
            double num2 = 2.01;
            double expected = 2.01;

            //act
            double[] dArray = { num1, num2 };
            double actual = ArrayCalcs.Min(dArray);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MaxTest()
        {
            //arrange
            double num1 = 5.2;
            double num2 = 2.01;
            double expected = 5.2;

            //act
            double[] dArray = { num1, num2 };
            double actual = ArrayCalcs.Max(dArray);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}