using FigureToolsLib.Contract.Interfaces;

namespace FigureToolsLib.Contract;

/// <summary>
///Сущность-контракт для фигуры треугольника(DTO). В зависимости
/// от задачи имеет смысл вынести эти классы в другие
/// проекты или библиотеки
/// </summary>
public class Triangle : IFigure
{
    public float SideA { get; set; }
    public float SideB { get; set; }
    public float SideC { get; set; }
}