using FigureToolsLib.BaseTools.Base;
using FigureToolsLib.Contract.Interfaces;

namespace FigureToolsLib.Interfaces;

public interface IFigureToolsFactory<TResult>
{
    /// <summary>
    /// Функция для получения стратегии обработки фигуры
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="figure"></param>
    /// <returns></returns>
    public IFigureTool<TResult>? GetTool<T>(T figure) where T : class, IFigure, new();
    /// <summary>
    /// Функция, результатом которой является результат обработки фигуры
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="figure"></param>
    /// <returns></returns>
    public TResult? ExecuteToolProcessing<T>(T figure) where T : class, IFigure, new();
    /// <summary>
    /// Метод для добавления новой стратегии обработки фигуры
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="strategy"></param>
    public void AddTool<T>(BaseTool<T, TResult> strategy);
}