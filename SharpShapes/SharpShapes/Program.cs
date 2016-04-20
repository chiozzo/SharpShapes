using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
  class Program
  {
    static void Main(string[] args)
    {
      Terminal UI = new Terminal();
      while (true)
      {
        Console.Write(UI.AskUserForShape());

        string shapeSelection = Console.ReadLine();
        Shape userShape = UI.CreateObjectFromUserInput(shapeSelection);
        Console.WriteLine(UI.confirmUserSelectedShape(shapeSelection));
        Console.Write(System.Environment.NewLine);
        Console.WriteLine(UI.AskUserForProperDimensions(shapeSelection));
        Console.Write("> ");
        string shapeDimensions = Console.ReadLine();
        Dictionary<string, double> dimensions = UI.parseShapeDimensions(userShape, shapeDimensions);
        Console.WriteLine(UI.printFormattedDimensions(userShape, dimensions));
        // calculate total volume of the shape

        Console.Read();
      }
    }
  }
}
