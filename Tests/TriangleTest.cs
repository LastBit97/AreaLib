using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaLib.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TriangleAreaTestMethod()
        {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            //Act
            Triangle triangle = new Triangle(a, b, c);
            double actual = triangle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual, "Error");
        }

        [TestMethod]
        public void TriangleRectangularTestMethod()
        {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            bool expected = true;

            //Act
            Triangle triangle = new Triangle(a, b, c);
            bool actual = triangle.isRectangular();

            //Assert
            Assert.AreEqual(expected, actual, "Error");
        }
    }
}
