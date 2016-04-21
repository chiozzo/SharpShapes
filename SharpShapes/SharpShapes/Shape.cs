using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
  public class Shape
  {
    public double calculateArea(double radius)
    {
      return Math.PI * ( radius * radius );
    }

    public double calculateArea(double height, double width)
    {
      return height * width;
    }

    public double calculateVolume(double radius, double depth)
    {
      return Math.PI * (radius * radius) * depth;
    }

    public double calculateVolume(double height, double width, double depth)
    {
      return height * width * depth;
    }
  }
}
