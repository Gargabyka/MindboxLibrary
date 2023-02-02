using MindboxLibrary.Extension;

namespace MindboxLibrary
{
    /// <summary>
    /// Фигура: треугольник
    /// </summary>
    public class Triangle: BaseFigure, IFigure
    {
        private readonly decimal _firstSide;
        private readonly decimal _secondSide;
        private readonly decimal _thirdSide;

        public Triangle(decimal firstSide, decimal secondSide, decimal thirdSide)
        {
            var inputValue = new[] { firstSide, secondSide, thirdSide };

            if (base.IsCheckValue(inputValue))
            {
                _firstSide = inputValue[0];
                _secondSide = inputValue[1];
                _thirdSide = inputValue[2];
            }
        }

        public Triangle(decimal[] inputValue)
        {

            if (base.IsCheckValue(inputValue))
            {
                _firstSide = inputValue[0];
                _secondSide = inputValue[1];
                _thirdSide = inputValue[2];
            }

        }

        public decimal Square
        {
            get
            {
                decimal square;
                try
                {
                    var perimeter = (_firstSide + _secondSide + _thirdSide) / 2;
                    square = MathDecimal.Sqrt(perimeter * (perimeter - _firstSide) * (perimeter - _secondSide) *
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
                return MathDecimal.Pow(_firstSide, 2) == MathDecimal.Pow(_secondSide, 2) + MathDecimal.Pow(_thirdSide, 2) ||
                       MathDecimal.Pow(_secondSide, 2) == MathDecimal.Pow(_firstSide, 2) + MathDecimal.Pow(_thirdSide, 2) ||
                            MathDecimal.Pow(_thirdSide, 2) == MathDecimal.Pow(_firstSide, 2) + MathDecimal.Pow(_secondSide, 2);
            }
        }
    }
}
