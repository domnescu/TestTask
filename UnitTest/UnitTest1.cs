using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask;

namespace UnitTest
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void CircleArea_10_result314_1592653589793()
        {
            double r = 10;
            double expected = 314.1592653589793;

            Circle circle = new Circle();
            double result = circle.CalculateArea(r);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TriangleArea_3and4and5_result6()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            Triangle triangle = new Triangle();
            double result = triangle.CalculateArea(a,b,c);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void RectangularTriangleTest_3and4and5_resutTrue()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;

            Triangle triangle = new Triangle();
            bool result = triangle.IsRectangle(a, b, c);

            Assert.AreEqual(expected, result);
        }
    }
}
