using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
    class Rhombus : Shape
    {
        public double horizontalDiagonal { get; set; }
        public double verticalDiagonal { get; set; }

        public override double calculateArea()
        {
            return ( horizontalDiagonal * verticalDiagonal ) / 2;
        }

        // Fun Fact: a 3D Rhombus is called a Rhombohedron.
        public override double calculateVolume()
        {
            // V = a³ * (1-cos(α)) * √(1+2cos(α))
            return base.calculateVolume();
        }
    }
}
