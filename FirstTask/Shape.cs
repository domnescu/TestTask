namespace TestTask
{
    public abstract class Shape
    {
        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <param name="Sides">Известные стороны фигуры</param>
        /// <returns>Площадь фигуры</returns>
        public abstract double CalculateArea(params double[] Sides);

    }
}
