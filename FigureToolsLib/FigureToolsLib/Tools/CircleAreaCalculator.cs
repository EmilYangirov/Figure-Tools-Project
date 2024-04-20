using FigureToolsLib.BaseTools.Base;
using FigureToolsLib.Contract;

namespace FigureToolsLib.BaseTools;

public class CircleAreaCalculator : BaseTool<Circle, double>
{
    public CircleAreaCalculator(string toolType) : base(toolType)
    {
    }
    protected override double ProcessFigure(Circle figure)
    {
        return Math.PI * Math.Pow(figure.Radius, 2);
    }
}
