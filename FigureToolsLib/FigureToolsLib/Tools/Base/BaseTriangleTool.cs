namespace FigureToolsLib.BaseTools.Base;
public abstract class BaseTriangleTool<T, TResult> : BaseTool<T, TResult>
{
    public BaseTriangleTool(string toolType) : base(toolType)
    {
    }
    protected override abstract TResult ProcessFigure(T figure);

    protected bool IsValidTriangle(double side1, double side2, double side3)
    {
        // Проверяем условие существования треугольника:
        // сумма любых двух сторон должна быть больше третьей стороны
        if(side1 == 0 || side2 == 0 || side3 == 0)
            return false;

        return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
    }
}