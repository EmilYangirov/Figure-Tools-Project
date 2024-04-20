using FigureToolsLib.BaseTools;
using FigureToolsLib.Contract;
using FigureToolsLib_Tests.TestAbstractClassRealizations;

namespace FigureToolsLib_Tests;
public class CircleAreaCalculatorTests
{
    [Fact]
    public void Process_10_78()
    {
        var toolType = "tool";
        var strategy = new CircleAreaCalculator(toolType);
        var figure = new Circle() { Radius = 5 };
        var result = strategy.Process(figure);
        var expexted = 5*5*Math.PI;
        Assert.Equal(expexted, result);
    }
}