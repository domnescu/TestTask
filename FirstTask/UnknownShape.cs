using TestTask.Exceptions;

namespace TestTask
{
    class UnknownShape : Shape
    {
        public override double CalculateArea(params double[] Sides)
        {
            Shape shape;
            switch (Sides.Length)
            {
                case 1:
                    shape = new Circle();
                    return shape.CalculateArea(Sides);
                case 3:
                    shape = new Triangle();
                    return shape.CalculateArea(Sides);
                default:
                    throw new ImpossibleToCalculateAreaException("Невозможно определить фигуру");
            }
        }
    }
}
