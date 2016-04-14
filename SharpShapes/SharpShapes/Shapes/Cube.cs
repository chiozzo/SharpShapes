using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
  public class Cube : Square, IThreeDimensional
  {
    public double depth { get; set; }

    public double calculateVolume()
    {
      return this.height * this.width * this.depth;
    }
  }
}
