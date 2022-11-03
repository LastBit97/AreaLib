namespace AreaLib
{
    public class Triangle : Shape
    {
        public double ASide { get; private set; } = 1;
        public double BSide { get; private set; } = 1;
        public double CSide { get; private set; } = 1;
        public Triangle(double aSide, double bSide, double cSide)
        {
            if (aSide > 0) ASide = aSide;
            if (bSide > 0) BSide = bSide;
            if (cSide > 0) CSide = cSide;
        }

        public double GetPerimeter()
        {
            return ASide + BSide + CSide;
        }

        public override double GetArea()
        {
            var p = GetPerimeter() / 2;
            return Math.Sqrt(p * (p - ASide) * (p - BSide) * (p - CSide));
        }

        public bool isRectangular()
        {
            return Math.Pow(ASide, 2) + Math.Pow(BSide, 2) == Math.Pow(CSide, 2) ||
                   Math.Pow(ASide, 2) + Math.Pow(CSide, 2) == Math.Pow(BSide, 2) ||
                   Math.Pow(CSide, 2) + Math.Pow(BSide, 2) == Math.Pow(ASide, 2);
        }
    }
}
