using FigureToolsLib.Contract.Interfaces;

namespace FigureToolsLib.Interfaces;

public interface IFigureTool<TResult>
{
    /// <summary>
    /// Функция, результатом которой является результат обработки фигуры
    /// </summary>
    /// <param name="figure"></param>
    /// <returns></returns>
    public TResult? Process(IFigure figure);
    /// <summary>
    /// Функция, которая возвращает тип инструмента 
    /// </summary>
    /// <returns></returns>
    public string GetToolType();
}