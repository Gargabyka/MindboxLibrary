namespace MindboxLibrary
{
    /// <summary>
    /// Класс для создания фигур в Compile Time 
    /// </summary>
    public class FigureCreator
    {
        public IFigure CreateFigure(double[] inputValue)
        {
            switch (inputValue.Length)
            {
                case 1:
                    return new Circle(inputValue);
                case 3:
                    return new Triangle(inputValue);
                default:
                    return new Circle(inputValue);
            }
        }
    }
}
