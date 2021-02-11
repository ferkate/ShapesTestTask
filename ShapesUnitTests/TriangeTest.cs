using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesArea;
using System;

namespace ShapesUnitTests
{
    [TestClass]
    public class TriangeTest
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TryBadLeftSideTest()
        {
            var triangle = new Triangle(-3, 4, 5);
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TryBadRigthSideTest()
        {
            var triangle = new Triangle(3, -4, 5);
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TryBadBaseSideTest()
        {
            var triangle = new Triangle(3, 4, -5);
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod()]
        public void CalculatePerimeterTest()
        {
            var triangle = new Triangle(3, 6, 8);
            var calcP = triangle.CalculatePerimeter();
            var testP = 3 + 6 + 8;

            Assert.AreEqual(testP, calcP);
        }

        [TestMethod()]
        public void CalculateTriangleAreaTest()
        {
            var triangle = new Triangle(3, 6, 8);
            var calcArea = triangle.CalculateArea();
            var p = (3 + 6 + 8) / 2.0;
            var testArea = Math.Sqrt(p * (p - 3) * (p - 6) * (p - 8));

            Assert.AreEqual(testArea, calcArea);
        }

        [TestMethod()]
        public void CalculateRightAngledTriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            var calcArea = triangle.CalculateArea();
            var testArea = (3 * 4) / 2.0;

            Assert.AreEqual(testArea, calcArea);
        }

        [TestMethod()]
        public void RightAngledTriangleAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            var isRightAngledTriangle = triangle.CheckRightAngledTriangle();

            Assert.IsTrue(isRightAngledTriangle);
        }

        [TestMethod()]
        public void TryBadRightAngledTriangleAreaTest()
        {
            var triangle = new Triangle(3, 6, 8);
            var isRightAngledTriangle = triangle.CheckRightAngledTriangle();            

            Assert.IsFalse(isRightAngledTriangle);

            Shape s = new Circle(3);
        }
    }
}
