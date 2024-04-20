using FigureToolsLib.Contract.Interfaces;
using FigureToolsLib.Interfaces;

namespace FigureToolsLib.BaseTools.Base;

/// <summary>
/// Базовый класс инструмента для обработки фигуры
/// </summary>
/// <typeparam name="T"></typeparam>
/// <typeparam name="TResult"></typeparam>
public abstract class BaseTool<T, TResult> : IFigureTool<TResult>
{
    private readonly string _toolType;
    public BaseTool(string toolType)
    {
        _toolType = toolType;
    }

    public string GetToolType() => _toolType;
    public TResult? Process(IFigure figure)
    {
        var concreteFigure = (T)figure;
        if (concreteFigure == null)
            return default;

        return ProcessFigure(concreteFigure);
    }

    protected abstract TResult ProcessFigure(T figure);

}