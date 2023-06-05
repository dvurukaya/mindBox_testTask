using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using testTask_mindBox.Interfaces;
using testTask_mindBox;

namespace testTask_mindBox_tests
{
    [TestClass]
    public class areaTests
    {
        [TestMethod]
        public void createCircle()
        {
            //Arrange
            IArea circleArea = new Circle(4);
            var answer = Math.PI * Math.Pow(4, 2);

            //Act
            var result = circleArea.getArea();

            //Assert
            Assert.AreEqual(answer, result, "must be equal 50.265482");
        }

        [TestMethod]
        public void createTriangle_ok()
        {
            //Arrange
            IArea triangleArea = new Triangle(4, 5, 7);
            var answer = Math.Sqrt(96);

            //Act
            var result = triangleArea.getArea();

            //Assert
            Assert.AreEqual(answer, result, "must be equal to 9,797958971...");
        }

        [TestMethod]
        public void createTrianle_wrong()
        {
            //Arrange
            IArea triangleArea = new Triangle(4, 5, 9);

            //Act
            var result = triangleArea.getArea();

            //Assert
            Assert.AreEqual(0, result, "must be equal 0");
        }

        [TestMethod]
        public void createTriangle_rightAngled()
        {
            //Arrange
            Triangle triangleRightAngled = new Triangle(3, 4, 5);

            //Act
            var result = triangleRightAngled.isTriangleRightAngled();

            //Assert
            Assert.AreEqual(true, result, "must be equal 'true'");
        }
    }
}
