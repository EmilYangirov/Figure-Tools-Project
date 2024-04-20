using FigureToolsLib.BaseTools.Base;

namespace FigureToolsLib_Tests.TestAbstractClassRealizations;
public class ConcreteStrategy : BaseTool<ConcreteFigure, double>
{
    public ConcreteStrategy(string toolType) : base(toolType)
    {
    }

    protected override double ProcessFigure(ConcreteFigure figure)
    {
        return 10;
    }
}