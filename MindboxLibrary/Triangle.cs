namespace MindboxLibrary
{
    /// <summary>
    /// Фигура: треугольник
    /// </summary>
    public class Triangle: IFigure
    {
        private readonly double _firstSide;
        private readonly double _secondSide;
        private readonly double _thirdSide;

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            var inputValue = new double[] { firstSide, secondSide, thirdSide };

            if (IsCheckValue(inputValue))
            {
                _firstSide = inputValue[0];
                _secondSide = inputValue[1];
                _thirdSide = inputValue[2];
            }
        }

        public Triangle(double[] inputValue)
        {

            if (IsCheckValue(inputValue))
            {
                _firstSide = inputValue[0];
                _secondSide = inputValue[1];
                _thirdSide = inputValue[2];
            }

        }

        public double Square
        {
            get
            {
                double square;
                try
                {
                    var perimeter = (_firstSide + _secondSide + _thirdSide) / 2;
                    square = Math.Sqrt(perimeter * (perimeter - _firstSide) * (perimeter - _secondSide) *
                                           (perimeter - _thirdSide));

                    return square;
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new ArgumentOutOfRangeException(nameof(square), "Площадь превышает допустимое значение");
                }
                catch (Exception e)
                {
                    throw new Exception($"Произошла ошибка при подсчете площади; {e.InnerException}");
                }
            }
        }

        /// <summary>
        /// Признак прямоугольного треугольника
        /// </summary>
        public bool? IsRightTriangle
        {
            get
            {
                return Math.Pow(_firstSide, 2) == Math.Pow(_secondSide, 2) + Math.Pow(_thirdSide, 2) ||
                            Math.Pow(_secondSide, 2) == Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2) ||
                            Math.Pow(_thirdSide, 2) == Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2);
            }
        }

        /// <summary>
        /// Проверка входных параметров
        /// </summary>
        private bool IsCheckValue(double[] valueDoubleList)
        {
            foreach (var valueList in valueDoubleList)
            {
                if (valueList <= 0 || !double.IsNormal(valueList))
                    throw new ArgumentException("Введено некорректное значение или сторона меньше, либо равна нулю");
            }

            return true;
        } 
    }
}
