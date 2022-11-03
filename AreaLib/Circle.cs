namespace AreaLib
{
    public class Circle : Shape
    {
        public double Radius { get; private set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea() => Math.Pow(Radius, 2) * Math.PI;
    }
}
