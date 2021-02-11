using System;

namespace ShapesArea
{
    public class Triangle : Shape
    {
        public double LeftSide { get; }
        public double RigthSide { get; }
        public double BaseSide { get; }

        public Triangle(double firstSide, double secondSide, double baseSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || baseSide <= 0)
                throw new ArgumentOutOfRangeException("Side of the triangle can not be below or equal 0");

            LeftSide = firstSide;
            RigthSide = secondSide;
            BaseSide = baseSide;
        }
        public override double CalculateArea()
        {
            var p = CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - LeftSide) * (p - RigthSide) * (p - BaseSide));
        }

        public override double CalculatePerimeter()
        {
            return LeftSide + RigthSide + BaseSide;
        }

        public bool CheckRightAngledTriangle()
        {
            var firstVariant = Math.Pow(LeftSide, 2) + Math.Pow(RigthSide, 2) == Math.Pow(BaseSide, 2);
            var secondVariant = Math.Pow(LeftSide, 2) + Math.Pow(BaseSide, 2) == Math.Pow(RigthSide, 2);
            var thirdVariant = Math.Pow(RigthSide, 2) + Math.Pow(BaseSide, 2) == Math.Pow(LeftSide, 2);

            return firstVariant || secondVariant || thirdVariant;
        }
    }
}
