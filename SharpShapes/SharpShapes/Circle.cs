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

        public override double calculateArea()
        {
            return Math.PI * ( radius * radius );
        }

        public double calculateSphereVolume()
        {
            return (4/3) * Math.PI * ( radius * radius * radius );
        }

        public double calculateCylinderVolume()
        {
            return this.calculateArea() * height;
        }
    }
}
