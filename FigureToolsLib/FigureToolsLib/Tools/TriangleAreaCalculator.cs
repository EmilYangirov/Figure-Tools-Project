using FigureToolsLib.BaseTools.Base;
using FigureToolsLib.Contract;

namespace FigureToolsLib.BaseTools;

public class TriangleAreaCalculator : BaseTriangleTool<Triangle, double>
{
    public TriangleAreaCalculator(string toolType) : base(toolType)
    {
    }
    protected override double ProcessFigure(Triangle figure)
    {
        // Проверяем, являются ли входные данные корректными для построения треугольника
        if (!IsValidTriangle(figure.SideA, figure.SideB, figure.SideC))
            return default;

        // Вычисляем полупериметр
        double s = (figure.SideA + figure.SideB + figure.SideC) / 2;

        // Вычисляем площадь по формуле Герона
        double area = Math.Sqrt(s * (s - figure.SideA) * (s - figure.SideB) * (s - figure.SideC));

        return area;
    }   
}
