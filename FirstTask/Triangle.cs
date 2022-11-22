using System;
using TestTask.Exceptions;

namespace TestTask
{
    public class Triangle : Shape
    {
        public override double CalculateArea(params double[] Sides)
        {
            if (IsPossibleTriangle(Sides))
            {
                double p = (Sides[0] + Sides[1] + Sides[2]) / 2;
                return Math.Sqrt(p * (p - Sides[0]) * (p - Sides[1]) * (p - Sides[2]));
            }
            else
            {
                throw new ImpossibleToCalculateAreaException("Невозможно подсчитать площадь треугольника");
            }
        }
        /// <summary>
        /// Проверка возможности существования такого треугольника
        /// </summary>
        /// <param name="Sides">Известные стороны треугольника</param>
        /// <returns>true - если треугольник может существовать</returns>
        private bool IsPossibleTriangle(params double[] Sides)
        {
            if (Sides[0] > (Sides[1] + Sides[2]) || Sides[1] > (Sides[0] + Sides[2]) || Sides[2] > (Sides[1] + Sides[0]) ||
                Sides[0] < 0 || Sides[1] < 0 || Sides[2] < 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// Проверка на прямоугольность треугольника
        /// </summary>
        /// <param name="Sides">Известные стороны треугольника</param>
        /// <returns>true - если треугольник прямоугольный</returns>
        public bool IsRectangle(params double[] Sides)
        {
            if (Math.Pow(Sides[0], 2) == Math.Pow(Sides[1], 2) + Math.Pow(Sides[2], 2) ||
                Math.Pow(Sides[1], 2) == Math.Pow(Sides[0], 2) + Math.Pow(Sides[2], 2) ||
                Math.Pow(Sides[2], 2) == Math.Pow(Sides[1], 2) + Math.Pow(Sides[0], 2))
                return true;
            else 
                return false;
        }

    }
}
