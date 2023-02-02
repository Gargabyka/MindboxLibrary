using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxLibrary;

namespace MindboxLibraryTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void SquareTest()
        {
            //arrange
            var value = new decimal[] { 6, 5, 5 };
            var triangle = new Triangle(value);

            //act
            var result = triangle.Square;

            //assert
            Assert.IsTrue(result is > 11 and < 13);
        }

        [TestMethod]
        public void IsRightTriangleTest()
        {
            //arrange
            var value = new decimal[] { 3, 4, 5 };
            var triangle = new Triangle(value);

            //act
            var result = triangle.IsRightTriangle;

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ExceptionTest()
        {
            var value = new decimal[] { -3, 4, 5 };

            Assert.ThrowsException<ArgumentException>(() => new Triangle(value));
        }
    }
}