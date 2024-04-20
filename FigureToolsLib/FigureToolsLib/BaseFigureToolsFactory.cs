using FigureToolsLib.BaseTools.Base;
using FigureToolsLib.Contract.Interfaces;
using FigureToolsLib.Interfaces;

namespace FigureToolsLib;

/// <summary>
/// Класс - фабрика стратегий для обработки фигур
/// </summary>
/// <typeparam name="TResult"></typeparam>
public abstract class BaseFigureToolsFactory<TResult> : IFigureToolsFactory<TResult>
{
    private Dictionary<Type, IFigureTool<TResult>> _strategies = new();
    private readonly string _toolType;

    public BaseFigureToolsFactory(string toolType)
    {
        _toolType = toolType;
    }
    public void AddTool<T>(BaseTool<T, TResult> strategy)
    {
        if (strategy.GetToolType() != _toolType)
            return;

        if (_strategies.ContainsKey(typeof(T)))
            return;

        _strategies.Add(typeof(T), strategy);
    }
    public IFigureTool<TResult>? GetTool<T>(T figure) where T : class, IFigure, new()
    {
        return _strategies.GetValueOrDefault(typeof(T));
    }

    public TResult? ExecuteToolProcessing<T>(T figure) where T : class, IFigure, new()
    {
        var tool = GetTool(figure);
        if (null == tool)
            return default;

        return tool.Process(figure);
    }
}
