using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesArea;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShapesUnitTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TryBadRadiusTest()
        {
            var circle = new Circle(-3);
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod()]
        public void CalculateAreaTest()
        {
            var circle = new Circle(3);
            var calcArea = circle.CalculateArea();
            var testArea = Math.Pow(3, 2) * Math.PI;

            Assert.AreEqual(testArea, calcArea);
        }
    }
}
