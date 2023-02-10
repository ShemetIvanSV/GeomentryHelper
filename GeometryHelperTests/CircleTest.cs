using GeomentryHelper.Models;
using NUnit.Framework;
using System;

namespace GeometryHelperTests
{
    [TestFixture]
    public class CircleTest
    {
        [Test]
        [TestCase(10, 314.159265)]
        [TestCase(500, 785398.163397)]
        public void GetArea_Radius_ReturnedArea(double radius, double expected)
        {
            //arrange
            var circle = new Circle(radius);

            //act
            double result = circle.GetArea();

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(0)]
        [TestCase(-10)]
        public void Ctor_MultipleRadius_ReturnedArgumentException(double radius)
        {
            //act
            var ex = Assert.Throws<ArgumentException>(() => new Circle(radius));

            //assert
            Assert.AreEqual("Радиус окружности не может иметь отрицательное или нулевое значение!", ex.Message);
        }
    }
}
