using GeomentryHelper.Models;
using NUnit.Framework;
using System;

namespace GeometryHelperTests
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        [TestCase(5, 5, 5, 10.825318)]
        [TestCase(473882, 217118, 618182, 43406514005.147575)]
        public void GetArea_MultipleSides_ReturnedArea(double sideA, double sideB, double sideC, double expected)
        {
            //arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            //act
            double result = triangle.GetArea();

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(3, 4, 5, true)]
        [TestCase(12, 13, 5, true)]
        [TestCase(10, 12, 12, false)]
        public void IsRightTriangle_MultipleSides_ReturnedIsRightTriangle(double sideA, double sideB, double sideC, bool expected)
        {
            //arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            //act
            bool result = triangle.IsRightTriangle();

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Ctor_Side10Side5Side5_ReturnedArgumentException()
        {
            //arrange
            double sideA = 10;
            double sideB = 5;
            double sideC = 5;

            //act
            var ex = Assert.Throws<ArgumentException>(()=> new Triangle(sideA, sideB, sideC));

            //assert
            Assert.AreEqual("Фигура не является треугольником!", ex.Message);
        }
    }
}