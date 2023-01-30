namespace MindboxLibrary
{
    public interface IFigure
    {
        /// <summary>
        /// Тип фигуры
        /// </summary>
        public string TypeFigure => this.GetType().Name;

        /// <summary>
        /// Площадь
        /// </summary>
        public double Square { get; }

        /// <summary>
        /// Признак прямоугольного треугольника
        /// </summary>
        public bool? IsRightTriangle { get; }
    }
}
