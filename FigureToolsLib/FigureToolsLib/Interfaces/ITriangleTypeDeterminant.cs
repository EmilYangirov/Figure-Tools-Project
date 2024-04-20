using FigureToolsLib.Contract;

namespace FigureToolsLib.Interfaces;

public interface ITriangleTypeDeterminant
{
    /// <summary>
    /// Функция, определяющая является ли треугольник прямоугольным
    /// </summary>
    /// <param name="figure"></param>
    /// <returns></returns>
    public bool IsRightTriangle(Triangle figure);
    /// <summary>
    /// Функция, определяющая является ли треугольник прямоугольным
    /// </summary>
    /// <param name="sideA"></param>
    /// <param name="sideB"></param>
    /// <param name="sideC"></param>
    /// <returns></returns>
    public bool IsRightTriangle(float sideA, float sideB, float sideC);
}