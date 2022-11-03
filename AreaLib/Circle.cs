using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
