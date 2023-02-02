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
        public decimal Square { get; }
    }
}
