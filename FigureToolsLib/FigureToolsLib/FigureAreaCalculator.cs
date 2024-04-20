using FigureToolsLib.Contract.Interfaces;
using FigureToolsLib.Interfaces;

namespace FigureToolsLib;

/// <summary>
/// конкретная реализация фабрики
/// Считает площадь фигуры
/// </summary>
public class FigureAreaCalculator : BaseFigureToolsFactory<double>, IFigureAreaCalculator
{
    public FigureAreaCalculator(string toolType) : base(toolType)
    {
    }
    public double CalculateArea<T>(T figure) where T : class, IFigure, new()
    {
        return ExecuteToolProcessing(figure);
    }
}