using FigureToolsLib_Tests.TestAbstractClassRealizations;

namespace FigureToolsLib_Tests;

public class BaseStrategyTests
{
    [Fact]
    public void Process_ConcreteFigure_10()
    {
        var toolType = "tool";
        var strategy = new ConcreteStrategy(toolType);
        var figure = new ConcreteFigure();
        var result = strategy.Process(figure);
        double expected = 10;
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Process_SameFigure_InvalidCastException()
    {
        var toolType = "tool";
        var strategy = new ConcreteStrategy(toolType);
        var figure = new SameFigure();
        Assert.Throws<InvalidCastException>(() => strategy.Process(figure));
    }

    [Fact]
    public void GetToolType_GetToolType_tool()
    {
        var toolType = "tool";
        var strategy = new ConcreteStrategy(toolType);
        var expected = "tool";
        Assert.Equal(expected, strategy.GetToolType());
    }
}