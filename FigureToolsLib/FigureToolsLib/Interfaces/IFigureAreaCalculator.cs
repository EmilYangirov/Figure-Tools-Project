using FigureToolsLib.Contract.Interfaces;

namespace FigureToolsLib.Interfaces;

public interface IFigureAreaCalculator
{
    /// <summary>
    /// Возвращает результат расчета площади фигуры
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="figure"></param>
    /// <returns></returns>
    public double CalculateArea<T>(T figure) where T : class, IFigure, new();
}