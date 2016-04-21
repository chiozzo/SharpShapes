using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

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
  }
}
