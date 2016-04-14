using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
  public class Circle
  {
    public double radius { get; set; }

    public double calculateArea()
    {
      return Math.PI * ( radius * radius );
    }
  }
}
