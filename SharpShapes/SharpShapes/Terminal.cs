using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpShapes
{
  public class Terminal
  {
    public string AskUserForShape()
    {
      string shapes = "Select a shape:";
      shapes += Environment.NewLine;
      shapes += "1. Circle";
      shapes += Environment.NewLine;
      shapes += "2. Square";
      shapes += Environment.NewLine;
      shapes += "3. Rhombus";
      shapes += Environment.NewLine;
      shapes += "4. Cube";
      shapes += Environment.NewLine;
      shapes += "5. Cylinder";
      shapes += Environment.NewLine;
      shapes += "> ";

      return shapes;
    }

    public Shape CreateObjectFromUserInput(string shapeType)
    {
      shapeType = shapeType.ToLower();
      Shape shape;
      switch (shapeType)
      {
        case "circle": shape = new Circle();
          break;
        case "square": shape = new Square();
          break;
        case "rhombus": shape = new Rhombus();
          break;
        case "cube": shape = new Cube();
          break;
        case "cylinder": shape = new Cylinder();
          break;
        default: throw new ArgumentException();
      }
      return shape;
    }

    public string confirmUserSelectedShape(string shapeSelection)
    {
      shapeSelection = shapeSelection.ToLower();
      return "You chose a " + shapeSelection + "." + System.Environment.NewLine;
    }

    public string AskUserForProperDimensions(string shapeSelection)
    {
      shapeSelection = shapeSelection.ToLower();
      string dimensionsToAskFor = "Please give me the ";
      switch (shapeSelection)
      {
        case "circle": dimensionsToAskFor += "radius ";
          break;
        case "square": dimensionsToAskFor += "height and width ";
          dimensionsToAskFor += "(i.e. 5x7) ";
          break;
        case "rhombus": dimensionsToAskFor += "vertical height and horizontal width ";
          dimensionsToAskFor += "(i.e. 5x7) ";
          break;
        case "cube": dimensionsToAskFor += "height, width, and depth ";
          dimensionsToAskFor += "(i.e. 5x7x9) ";
          break;
        case "cylinder": dimensionsToAskFor += "radius and depth ";
          dimensionsToAskFor += "(i.e. 5x7) ";
          break;
        default: throw new ArgumentException();
      }
      dimensionsToAskFor += "of the " + shapeSelection + ".";
      return dimensionsToAskFor;
    }

    public Dictionary<string, double> parseShapeDimensions(Shape userShape, string shapeDimensions)
    {
      Dictionary<string, double> dimensions = new Dictionary<string, double>();
      shapeDimensions = shapeDimensions.Replace(" ", "");
      string[] dimensionsArray = shapeDimensions.Split('x');
      int countOfDimensions = dimensionsArray.Length;
      if (countOfDimensions < 1)
      {
        throw new ArgumentException("You didn't provide me any dimensions");
      }

      if (userShape is Circle)
      {
        dimensions.Add("radius", Convert.ToDouble(dimensionsArray[0]));
      }
      else if (userShape is Square || userShape is Rhombus)
      {
        dimensions.Add("height", Convert.ToDouble(dimensionsArray[0]));
        dimensions.Add("width", Convert.ToDouble(dimensionsArray[1]));
      }


      if (userShape is Cylinder)
      {
        dimensions.Add("depth", Convert.ToDouble(dimensionsArray[1]));
      }
      else if (userShape is Cube)
      {
        dimensions.Add("depth", Convert.ToDouble(dimensionsArray[2]));
      }

      return dimensions;
    }

    public string printFormattedDimensions(Shape userShape, Dictionary<string, double> shapeDimensions)
    {
      string dimensionString = "";
      if (userShape is Circle)
      {
        dimensionString += "The radius is : " + shapeDimensions["radius"];
      }
      else if (userShape is Square || userShape is Rhombus)
      {
        dimensionString += "The ";
        if (userShape is Rhombus)
        {
          dimensionString += "vertical ";
        }
        dimensionString += "height is : " + shapeDimensions["height"];
        dimensionString += System.Environment.NewLine;
        dimensionString += "The ";
        if (userShape is Rhombus)
        {
          dimensionString += "horizontal ";
        }
        dimensionString += "width is : " + shapeDimensions["width"];
      }

      if (userShape is Cylinder || userShape is Cube)
      {
        dimensionString += Environment.NewLine;
        dimensionString += "The depth is : " + shapeDimensions["depth"];
      }
      return dimensionString;
    }

    public double calculateShapesAreaOrVolume(Shape userShape, Dictionary<string, double> shapeDimensions)
    {
      if (userShape is Circle)
      {
        return userShape.calculateArea(shapeDimensions["radius"]);
      }
      else if (userShape is Square || userShape is Rhombus)
      {
        return userShape.calculateArea(shapeDimensions["height"], shapeDimensions["width"]);
      }
      else if (userShape is Cylinder)
      {
        return userShape.calculateVolume(shapeDimensions["radius"], shapeDimensions["depth"]);
      }
      else if (userShape is Cube)
      {
        return userShape.calculateVolume(shapeDimensions["height"], shapeDimensions["width"], shapeDimensions["depth"]);
      }
      throw new Exception();
    }

    public string printAreaOrVolumeTotal(Shape userShape, string shapeSelection, double areaOrVolume)
    {
      string areaOrVolumeString = "The ";
      if (userShape is Circle || userShape is Square || userShape is Rhombus)
      {
        areaOrVolumeString += "area ";
      }
      else if (userShape is Cylinder || userShape is Cube)
      {
        areaOrVolumeString += "volume ";
      }
      areaOrVolumeString += "of your " + shapeSelection.ToLower() + " is ";
      areaOrVolumeString += areaOrVolume;
      return areaOrVolumeString;

    }
  }
}
