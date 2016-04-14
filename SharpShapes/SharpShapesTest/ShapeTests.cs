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
        testCircle.radius = radius;
        double actual = testCircle.calculateArea();
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
        testCylinder.radius = radius;
        foreach (double depth in testDepths)
        {
          testCylinder.depth = depth;
          double actual = testCylinder.calculateVolume();
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
        testSquare.height = height;
        foreach (double width in testWidths)
        {
          testSquare.width = width;
          double actual = testSquare.calculateArea();
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
        testCube.height = height;
        foreach (double width in testWidths)
        {
          testCube.width = width;
          foreach (double depth in testDepths)
          {
            testCube.depth = depth;
            double actual = testCube.calculateVolume();
            double expected = height * width * depth;
            Assert.AreEqual(actual, expected);
          }
        }
      }
    }
  }
}
