using System;

namespace TestTask
{
    public class Circle : Shape
    {
        public override double CalculateArea(params double[] Sides)
        {
            return Math.PI * Sides[0] * Sides[0];
        }
    }
}
