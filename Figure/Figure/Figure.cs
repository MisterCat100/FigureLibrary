namespace Figure
{
    public interface IFigure
    {
        double CalculateArea();
    }

    public class Circle : IFigure
    {
        public readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }

    public class Triangle : IFigure
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;

        public Triangle(double side1, double side2, double side3)
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double CalculateArea()
        {
            double p = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(p * (p - _side1) * (p - _side2) * (p - _side3));
        }

        public bool IsRightTriangle()
        {
            return Math.Pow(_side1, 2) + Math.Pow(_side2, 2) == Math.Pow(_side3, 2) ||
                   Math.Pow(_side1, 2) + Math.Pow(_side3, 2) == Math.Pow(_side2, 2) ||
                   Math.Pow(_side2, 2) + Math.Pow(_side3, 2) == Math.Pow(_side1, 2);
        }
    }
}
