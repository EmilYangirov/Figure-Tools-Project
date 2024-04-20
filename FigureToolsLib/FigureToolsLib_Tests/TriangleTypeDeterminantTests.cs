using FigureToolsLib.BaseTools;
using FigureToolsLib.Contract;

namespace FigureToolsLib_Tests;
public class TriangleTypeDeterminantTests
{
    [Fact]
    public void Process_ValidTriangle_NonDefault()
    {
        var toolType = "tool";
        var strategy = new TriangleTypeDeterminant(toolType);
        var figure = new Triangle() { SideA = 3, SideB = 4, SideC = 5 };
        var result = strategy.Process(figure);
        bool expexted = default;
        Assert.NotEqual(expexted, result);
    }

    [Fact]
    public void Process_InvalidTriangle_Default()
    {
        var toolType = "tool";
        var strategy = new TriangleTypeDeterminant(toolType);
        var figure = new Triangle() { SideA = 1, SideB = 10, SideC = 12 };
        var result = strategy.Process(figure);
        bool expexted = default;
        Assert.Equal(expexted, result);
    }

    [Fact]
    public void Process_NonRightTriangle_False()
    {
        var toolType = "tool";
        var strategy = new TriangleTypeDeterminant(toolType);
        var figure = new Triangle() { SideA = 7, SideB = 10, SideC = 5 };
        var result = strategy.Process(figure);
        bool expexted = false;
        Assert.Equal(expexted, result);
    }

    [Fact]
    public void Process_RightTriangle_True()
    {
        var toolType = "tool";
        var strategy = new TriangleTypeDeterminant(toolType);
        var figure = new Triangle() { SideA = 3, SideB = 4, SideC = 5 };
        var result = strategy.Process(figure);
        bool expexted = true;
        Assert.Equal(expexted, result);
    }
}
