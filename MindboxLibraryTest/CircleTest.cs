using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxLibrary;
using MindboxLibrary.Extension;

namespace MindboxLibraryTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void SquareTest()
        {
            //arrange
            var circle = new Circle(5);
            var checkValue = MathDecimal.PI * MathDecimal.Pow(5, 2);

            //act
            var result = circle.Square;

            //assert
            Assert.AreEqual(checkValue, result);
        }


        [TestMethod]
        public void ExceptionTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(-3));
        }
    }
}
