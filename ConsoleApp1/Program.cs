using MindboxLibrary;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var figureCreator = new FigureCreator();

            var doubleList = new List<double[]>
            {
                new double[] { 5 },
                new double[] { 6, 7, 8 },
                new double[] { 3, 4, 5 },
                new double[] { 4, 5 },
                new double[] { 7 },
                new double[] { 8, 9, 10 }
            };

            foreach (var value in doubleList)
            {
                var figure = figureCreator.CreateFigure(value);

                var isRightTriangle = figure.IsRightTriangle.HasValue
                    ? $"Равносторонний треугольник: {figure.IsRightTriangle}"
                    : string.Empty;

                Console.WriteLine($"Тип фигуры: {figure.TypeFigure}. Площадь: {figure.Square}. {isRightTriangle}");
            }

            Console.ReadKey();
        }
    }
}