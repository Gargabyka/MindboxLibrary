namespace MindboxLibrary.Extension
{
    public static class MathDecimal
    {
        public const decimal PI = 3.14159265358979323846M;

        /// <summary>
        /// Возведение в степень
        /// </summary>>
        /// <returns></returns>
        public static decimal Pow(decimal value, int pow)
        {
            decimal result = 1;

            if (pow > 0)
            {
                for (int i = 1; i <= pow; ++i)
                {
                    result *= value;
                }
            }
            else if (pow < 0)
            {
                for (int i = -1; i >= pow; --i)
                {
                    result /= value;
                }
            }

            return result;
        }

        /// <summary>
        /// Вычисление квадратного корня
        /// </summary>
        public static decimal Sqrt(decimal value)
        {
            decimal g = value;
            while (true)
            {
                decimal t = (value / g + g) / 2;
                if (Math.Abs(g - t) < 1E-10M)
                {
                    return g;
                }
                g = t;
            }
        }
    }
}
