using FigureToolsLib.BaseTools.Base;
using FigureToolsLib.Contract;

namespace FigureToolsLib.BaseTools;

public class TriangleTypeDeterminant : BaseTriangleTool<Triangle, bool>
{
    public TriangleTypeDeterminant(string toolType) : base(toolType)
    {
    }
    protected override bool ProcessFigure(Triangle figure)
    {
        if (!IsValidTriangle(figure.SideA, figure.SideB, figure.SideC))
            return false;

        // Проверяем теорему Пифагора
        return Math.Pow(figure.SideA, 2) + Math.Pow(figure.SideB, 2) == Math.Pow(figure.SideC, 2) ||
               Math.Pow(figure.SideB, 2) + Math.Pow(figure.SideC, 2) == Math.Pow(figure.SideA, 2) ||
               Math.Pow(figure.SideA, 2) + Math.Pow(figure.SideC, 2) == Math.Pow(figure.SideB, 2);
    }
}
