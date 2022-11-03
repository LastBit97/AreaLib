using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaLib.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleAreaTestMethod()
        {
            //Arrange
            double radius = 4;
            double expected = 50.2655;

            //Act
            Circle circle = new Circle(radius);
            double actual = circle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual, "Error");
        }
    }
}
