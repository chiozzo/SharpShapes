using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    public class Circle : Shape
    {
        public double radius { get; set; }
        double pi = 3.14;

        public override double calculateArea()
        {
            return pi * ( radius * radius );
        }

        public double calculateSphereVolume()
        {
            return (4/3) * pi * ( radius * radius * radius );
        }

        public double calculateCylinderVolume()
        {
            return this.calculateArea() * height;
        }
    }
}
