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
        // ask user to select a shape
        Console.Write(UI.AskUserForShape());
        string shapeSelection = Console.ReadLine();
        Console.WriteLine(UI.confirmUserSelectedShape(shapeSelection));

        // create the shape object based on the user input
        Shape userShape = UI.CreateObjectFromUserInput(shapeSelection);

        // ask user to dimensions of selected shape
        Console.WriteLine(UI.AskUserForProperDimensions(shapeSelection));
        Console.Write("> ");
        string shapeDimensions = Console.ReadLine();

        // parse the shape dimensions
        Dictionary<string, double> dimensions = UI.parseShapeDimensions(userShape, shapeDimensions);
        Console.WriteLine(UI.printFormattedDimensions(userShape, dimensions));
        
        // calculate total volume of the shape
        double totalAreaOrVolume = UI.calculateShapesAreaOrVolume(userShape, dimensions);
        Console.WriteLine(UI.printAreaOrVolumeTotal(userShape, shapeSelection, totalAreaOrVolume));
        Console.Read();
      }
    }
  }
}
