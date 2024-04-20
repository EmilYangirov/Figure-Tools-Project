using FigureToolsLib.BaseTools.Base;

namespace FigureToolsLib_Tests.TestAbstractClassRealizations;
public class SameStrategy : BaseTool<ConcreteFigure, double>
{
    public SameStrategy(string toolType) : base(toolType)
    {
    }

    protected override double ProcessFigure(ConcreteFigure figure)
    {
        return 10;
    }
}