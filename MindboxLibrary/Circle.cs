namespace MindboxLibrary
{
    /// <summary>
    /// Фигура: круг
    /// </summary>
    public class Circle : IFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус меньше нуля");
            if (!double.IsNormal(radius))
                throw new ArgumentException("Указан неверный радиус");

            _radius = radius;
        }

        public Circle(double[] inputValue)
        {
            var radius = inputValue[0];

            if (radius <= 0)
                throw new ArgumentException("Радиус меньше нуля");
            if (!double.IsNormal(radius))
                throw new ArgumentException("Указан неверный радиус");

            _radius = radius;
        }


        public double Square
        {
            get
            {
                double square;
                try
                {
                    square = Math.PI * Math.Pow(_radius, 2);
                    return square;
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new ArgumentOutOfRangeException(nameof(square), "Площадь превышает допустимое значение");
                }
                catch (Exception)
                {
                    throw new Exception("Произошла ошибка при подсчете площади");
                }
            }
        }

        public bool? IsRightTriangle { get; } = null;
    }
}
