using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;
using System.Collections.Generic;

namespace SharpShapesTest
{
  [TestClass]
  public class ShapeTests
  {
    static double[] testRadii = new double[] { 5, 7.654, 1234, 7890 };
    static double[] testHeights = testRadii;
    static double[] testWidths = testRadii;
    static double[] testDepths = testRadii;

    [TestMethod]
    public void TestCircleArea()
    {
      Circle testCircle = new Circle();
      foreach (double radius in testRadii)
      {
        double actual = testCircle.calculateArea(radius);
        double expected = Math.PI * ( radius * radius );
        Assert.AreEqual(actual, expected);
      }
    }

    [TestMethod]
    public void TestCylinderVolume()
    {
      Cylinder testCylinder = new Cylinder();
      foreach (double radius in testRadii)
      {
        foreach (double depth in testDepths)
        {
          double actual = testCylinder.calculateVolume(radius, depth);
          double expected = Math.PI * ( radius * radius ) * depth;
          Assert.AreEqual(actual, expected);
        }
      }
    }

    [TestMethod]
    public void TestSquareArea()
    {
      Square testSquare = new Square();
      foreach (double height in testHeights)
      {
        foreach (double width in testWidths)
        {
          double actual = testSquare.calculateArea(height, width);
          double expected = height * width;
          Assert.AreEqual(actual, expected);
        }
      }
    }

    [TestMethod]
    public void TestCubeVolume()
    {
      Cube testCube = new Cube();
      foreach (double height in testHeights)
      {
        foreach (double width in testWidths)
        {
          foreach (double depth in testDepths)
          {
            double actual = testCube.calculateVolume(height, width, depth);
            double expected = height * width * depth;
            Assert.AreEqual(actual, expected);
          }
        }
      }
    }

    Shape[] shapeCreatedArray = { new Circle(), new Square(), new Rhombus(), new Cube(), new Cylinder() };

    [TestMethod]
    public void TestWillCreateCorrectShapeFromUserInput()
    {
      string[] shapeRequestedArray = { "circle", "square", "rhombus", "cube", "cylinder" };

      Terminal UI = new Terminal();
      for (int i = 0; i < shapeRequestedArray.Length; i++)
      {
        Assert.IsInstanceOfType(UI.CreateObjectFromUserInput(shapeRequestedArray[i]), shapeCreatedArray[i].GetType());
      }
    }

    [TestMethod]
    public void TestWillParseDimensionsBasedOnShape()
    {
      Dictionary<string, double> circleDimensions =  new Dictionary<string, double>()
      {
        { "radius", 5 }
      };
      Dictionary<string, double> squareDimensions = new Dictionary<string, double>()
      {
        { "height", 5 },
        { "width", 2.5 }
      };
      Dictionary<string, double> rhombusDimensions = new Dictionary<string, double>()
      {
        { "height", 3.4 },
        { "width", 7.9 }
      };
      Dictionary<string, double> cubeDimensions = new Dictionary<string, double>()
      {
        { "height", 234 },
        { "width", 546 },
        { "depth", 869 }
      };
      Dictionary<string, double> cylinderDimensions = new Dictionary<string, double>()
      {
        { "radius", 12 },
        { "depth", 9.9 }
      };
      string[] shapeRequestedDimensions = { "5", "5x2.5", "3.4x7.9", "234x546x869", "12x9.9" };
      Dictionary<string, double>[] shapeParsedDimensions = { circleDimensions, squareDimensions, rhombusDimensions, cubeDimensions, cylinderDimensions };

      Terminal UI = new Terminal();
      for (int i = 0; i < shapeRequestedDimensions.Length; i++)
      {
        Dictionary<string, double> actual = UI.parseShapeDimensions(shapeCreatedArray[i], shapeRequestedDimensions[i]);

      }
    }
  }
}
