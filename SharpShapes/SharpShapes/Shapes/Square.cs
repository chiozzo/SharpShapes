using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
  public class Square : ITwoDimensional
  {
    public double height { get; set; }
    public double width { get; set; }

    public double calculateArea()
    {
      return this.height * this.width;
    }
  }
}
