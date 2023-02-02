namespace MindboxLibrary
{
    public abstract class BaseFigure
    {
        /// <summary>
        /// Проверка входных параметров
        /// </summary>
        protected virtual bool IsCheckValue(decimal[] inputValue)
        {
            foreach (var value in inputValue)
            {
                if (value <= 0)
                    throw new ArgumentException("Сторона меньше, либо равна нулю");
            }

            return true;
        }
    }
}
