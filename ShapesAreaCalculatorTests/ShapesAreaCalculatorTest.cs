using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShapesAreaCalculatorLibrary.Tests
{
    [TestClass]
    public class ShapesAreaCalculatorTest
    {
        [TestMethod]
        public void CircleGetAreaTest()
        {
            double radius = 5;
            double expected = 2 * Math.PI * radius;
            Circle circle = new Circle(radius);
            double actual = circle.GetArea();

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void CircleNegtiveOrZeroRadiusGetAreaTest()
        {
            double radius = -5;
            double expected = 2 * Math.PI * radius;
            Circle circle = new Circle(radius);
            double actual = circle.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleGetArea_5and5and6_12Returned()
        {
            Triangle triangle = new Triangle(5, 5, 6);

            double expected = 12;
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleGetArea_3and0andNegative_IsNanReturned()
        {
            Triangle triangle = new Triangle(3, 0, -5);
            double expected = double.NaN;
            double actual = triangle.GetArea();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleIsRectangular_3and4and5_TrueReturned()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            bool expected = true;
            bool actual = triangle.IsRectangular();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleIsRectangular_10and24and26_TrueReturned()
        {
            Triangle triangle = new Triangle(10, 24, 26);
            bool expected = true;
            bool actual = triangle.IsRectangular();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleIsRectangular_4and4and6_FalseReturned()
        {
            Triangle triangle = new Triangle(4, 4, 6);
            bool expected = false;
            bool actual = triangle.IsRectangular();

            Assert.AreEqual(expected, actual);
        }
    }
}