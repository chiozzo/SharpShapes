using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
  public class Cylinder : Circle, IThreeDimensional
  {
    public double depth { get; set; }

    public double calculateVolume()
    {
      return this.calculateArea() * depth;
    }
  }
}
