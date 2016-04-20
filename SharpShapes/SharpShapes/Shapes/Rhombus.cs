using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
  public class Rhombus : Shape
  {
    public double horizontalDiagonal { get; set; }
    public double verticalDiagonal { get; set; }

    public double calculateArea()
    {
      return ( horizontalDiagonal * verticalDiagonal ) / 2;
    }

    // Fun Fact: a 3D Rhombus is called a Rhombohedron.
    public double calculateVolume()
    {
      // V = a³ * (1-cos(α)) * √(1+2cos(α))
      throw new NotImplementedException();
    }
  }
}
