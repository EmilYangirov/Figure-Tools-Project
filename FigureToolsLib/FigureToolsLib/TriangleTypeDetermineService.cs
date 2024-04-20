using FigureToolsLib.Contract;
using FigureToolsLib.Interfaces;

namespace FigureToolsLib;

/// <summary>
/// Конкретная реализации фабрики
/// Определяет является ли фигура прямоугольной
/// </summary>
public class TriangleTypeDetermineService : BaseFigureToolsFactory<bool>, ITriangleTypeDeterminant
{
    public TriangleTypeDetermineService(string toolType) : base(toolType)
    {
    }

    public bool IsRightTriangle(Triangle figure)
    {
        return ExecuteToolProcessing(figure);
    }

    public bool IsRightTriangle(float sideA, float sideB, float sideC)
    {
        var triangle = new Triangle()
        {
            SideA = sideA,
            SideB = sideB,
            SideC = sideC,
        };

        return IsRightTriangle(triangle);
    }
}