using Microsoft.VisualStudio.TestTools.UnitTesting;
using SquareLib;
using System;

namespace SquareTest;

[TestClass]
public class UnitTest1
{
    Class1 cl = new Class1();
    [TestMethod]
    public void Test_SquareCircle()
    {
        double testVar = 10;
        var actual  = 3.14 * Math.Pow(testVar,2);

        var expected = cl.SquareCircle(testVar);
        var figure = new Figure(testVar);

        Assert.AreEqual(expected, actual);
        Assert.AreEqual(figure.Result, actual);
    }
    [TestMethod]
    public void Test_SquareTriangle()
    {
        double sideA = 10;
        double sideB = 10;
        double sideC = 10;

        double p = (sideA+sideB+sideC)/2;

        var actual = Math.Sqrt(p * (p-sideA) * (p-sideC) * (p-sideC));

        var expected = cl.SquareTriangle(sideA, sideB, sideC);
        var figure = new Figure(sideA, sideB, sideC);

        Assert.AreEqual(expected, actual);
        Assert.AreEqual(figure.Result, actual);
    }

    [TestMethod]
    public void Test_SquareQuadrilateral()
    {
        double sideA = 10;
        double sideB = 10;
        
        var actual = sideA * sideB;

        var expected = cl.SquareQuadrilateral(sideA, sideB);
        var figure = new Figure(sideA, sideB);

        Assert.AreEqual(expected, actual);
        Assert.AreEqual(figure.Result, actual);
    }

    
}