using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpShapes;

namespace SharpShapesTest
{
  [TestClass]
  public class TerminalTests
  {
    [TestMethod]
    public void TestAskUserForShapeSelection()
    {
      Terminal testInterface = new Terminal();

      string actual = testInterface.AskUserForShape();
      string expected = "Select a shape:";
      expected += Environment.NewLine;
      expected += "1. Circle";
      expected += Environment.NewLine;
      expected += "2. Square";
      expected += Environment.NewLine;
      expected += "3. Rhombus";
      expected += Environment.NewLine;
      expected += "4. Cube";
      expected += Environment.NewLine;
      expected += "5. Cylinder";
      expected += Environment.NewLine;
      expected += "> ";

      Assert.AreEqual(actual, expected);
    }

    [TestMethod]
    public void TestObjectCreatedFromUserInput()
    {
      Terminal testInterface = new Terminal();

      string userSelectedShape = "Circle";
      Shape actual = testInterface.CreateObjectFromUserInput(userSelectedShape);
      Assert.IsInstanceOfType(actual, typeof(Circle));

      userSelectedShape = "Square";
      actual = testInterface.CreateObjectFromUserInput(userSelectedShape);
      Assert.IsInstanceOfType(actual, typeof(Square));

      userSelectedShape = "Rhombus";
      actual = testInterface.CreateObjectFromUserInput(userSelectedShape);
      Assert.IsInstanceOfType(actual, typeof(Rhombus));

      userSelectedShape = "Cube";
      actual = testInterface.CreateObjectFromUserInput(userSelectedShape);
      Assert.IsInstanceOfType(actual, typeof(Cube));

      userSelectedShape = "Cylinder";
      actual = testInterface.CreateObjectFromUserInput(userSelectedShape);
      Assert.IsInstanceOfType(actual, typeof(Cylinder));
    }
  }
}
