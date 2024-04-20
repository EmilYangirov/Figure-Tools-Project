using FigureToolsLib.BaseTools;
using FigureToolsLib.Contract;
using FigureToolsLib_Tests.TestAbstractClassRealizations;

namespace FigureToolsLib_Tests;
public class TriangleAreaCalculatorTests
{
    [Fact]
    public void Process_ValidTriangle_NonDefault()
    {
        var toolType = "tool";
        var strategy = new TriangleAreaCalculator(toolType);
        var figure = new Triangle() { SideA = 7, SideB = 10, SideC = 5 };
        var result = strategy.Process(figure);
        double expexted = default;
        Assert.NotEqual(expexted, result);
    }

    [Fact]
    public void Process_InvalidTriangle_Default()
    {
        var toolType = "tool";
        var strategy = new TriangleAreaCalculator(toolType);
        var figure = new Triangle() { SideA = 1, SideB = 10, SideC = 12 };
        var result = strategy.Process(figure);
        double expexted = default;
        Assert.Equal(expexted, result);
    }

    [Fact]
    public void Process_ZeroSideTriangle_Default()
    {
        var toolType = "tool";
        var strategy = new TriangleAreaCalculator(toolType);
        var figure = new Triangle() { SideA = 0, SideB = 10, SideC = 12 };
        var result = strategy.Process(figure);
        double expexted = default;
        Assert.Equal(expexted, result);
    }

    [Fact]
    public void Process_Input_3_4_5_Result_6()
    {
        var toolType = "tool";
        var strategy = new TriangleAreaCalculator(toolType);
        var figure = new Triangle() { SideA = 3, SideB = 4, SideC = 5 };
        var result = strategy.Process(figure);
        double expexted = 6;
        Assert.Equal(expexted, result);
    }
}