using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesArea;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapesUnitTests
{
    [TestClass]
    public class ShapeTest
    {
        [TestMethod()]
        public void ShapeCalculateAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            var cirle = new Circle(3);

            var shapes = new List<Shape>() { triangle, cirle };
            var areas = shapes.Select(s => s.CalculateArea()).ToArray();

            var testAreaTriangle = (3 * 4) / 2.0;
            var testAreaCircle = Math.Pow(3, 2) * Math.PI;
            var testAreas = new double[2] { testAreaTriangle, testAreaCircle };

            CollectionAssert.AreEqual(areas, testAreas);
        }
    }
}
