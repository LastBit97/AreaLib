using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaLib
{
    public class Triangle : Shape
    {
        public double ASide { get; private set; }
        public double BSide { get; private set; }
        public double CSide { get; private set; }
        public Triangle(double aSide, double bSide, double cSide)
        {
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
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
