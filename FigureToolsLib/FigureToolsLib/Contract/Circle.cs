using FigureToolsLib.Contract.Interfaces;

namespace FigureToolsLib.Contract;

/// <summary>
/// Сущность-контракт для фигуры круга (DTO). В зависимости 
/// от задачи имеет смысл вынести эти классы в другие
/// проекты или библиотеки
/// </summary>
public class Circle : IFigure
{
    public float Radius { get; set; }
}