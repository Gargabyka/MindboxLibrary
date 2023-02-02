using MindboxLibrary;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var figureCreator = new FigureCreator();

            var decimalsList = new List<decimal[]>
            {
                new decimal[] { 5 },
                new decimal[] { 6, 7, 8 },
                new decimal[] { 3, 4, 5 },
                new decimal[] { 4, 5 },
                new decimal[] { 7 },
                new decimal[] { 8, 9, 10 }
            };

            foreach (var value in decimalsList)
            {
                var figure = figureCreator.CreateFigure(value);


                Console.WriteLine($"Тип фигуры: {figure.TypeFigure}. Площадь: {figure.Square}");
            }

            var circle = new Circle(5);
            Console.WriteLine($"{circle.Square}");

            var triangle = new Triangle(3, 4, 5);
            Console.WriteLine($"{triangle.Square}");

            Console.ReadKey();
        }
    }
}