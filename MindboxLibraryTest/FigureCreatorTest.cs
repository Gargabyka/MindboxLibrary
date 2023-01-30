using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxLibrary;

namespace MindboxLibraryTest
{
    [TestClass]
    public class FigureCreatorTest
    {
        [TestMethod]
        public void CreateCircle()
        {
            //arrange
            var figureCreator = new FigureCreator();
            var value = new double[] { 5 };
            var figure = figureCreator.CreateFigure(value);

            //act
            var result = figure.GetType();

            //assert
            Assert.IsTrue(typeof(Circle) == result);
        }

        [TestMethod]
        public void CreateTriangle()
        {
            //arrange
            var figureCreator = new FigureCreator();
            var value = new double[] { 5, 6, 7 };
            var figure = figureCreator.CreateFigure(value);

            //act
            var result = figure.GetType();

            //assert
            Assert.IsTrue(typeof(Triangle) == result);
        }

        [TestMethod]
        public void NotValidInputValue()
        {
            //arrange
            var figureCreator = new FigureCreator();
            var value = new double[] { 5, 6, 7, 8 };
            var figure = figureCreator.CreateFigure(value);

            //act
            var result = figure.GetType();
            var checkValue = Math.PI * Math.Pow(5, 2);

            //assert
            Assert.IsTrue(typeof(Circle) == result);
            Assert.AreEqual(figure.Square, checkValue);
        }
    }
}
