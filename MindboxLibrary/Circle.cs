using MindboxLibrary.Extension;

namespace MindboxLibrary
{
    /// <summary>
    /// Фигура: круг
    /// </summary>
    public sealed class Circle : BaseFigure, IFigure
    {
        private readonly decimal _radius;

        public Circle(decimal radius)
        {
            if(IsCheckValue(new decimal[] {radius}))
            {
                _radius = radius;
            }
        }

        public Circle(decimal[] inputValue)
        {
            var radius = inputValue[0];

            if(IsCheckValue(inputValue))
            {
                _radius = radius;
            }
        }


        public decimal Square
        {
            get
            {
                decimal square;
                try
                {
                    square = MathDecimal.PI * _radius * _radius;
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
    }
}
