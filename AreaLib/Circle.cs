namespace AreaLib
{
    public class Circle : Shape
    {
        public double Radius { get; private set; } = 1;
        public Circle(double radius)
        {
            if (radius > 0) Radius = radius;
        }

        public override double GetArea() => Math.Round(Math.Pow(Radius, 2) * Math.PI, 4);
    }
}
