using ExternalFigureProject;
using FigureToolsLib;
using FigureToolsLib.BaseTools;
using FigureToolsLib.Contract;
using FigureToolsLib.Contract.Interfaces;

//предполагается регистрация сервисов через DI
var exec1 = new FigureAreaCalculator(ToolType.FigureAreaCalculator.ToString());
exec1.AddTool(new CircleAreaCalculator(ToolType.FigureAreaCalculator.ToString()));
exec1.AddTool(new TriangleAreaCalculator(ToolType.FigureAreaCalculator.ToString()));

var exec2 = new TriangleTypeDetermineService(ToolType.TriangleTypeDeterminant.ToString());
exec2.AddTool(new TriangleTypeDeterminant(ToolType.TriangleTypeDeterminant.ToString()));

var figure1 = new Circle() { Radius = 5 };
var figure2 = new Triangle() { SideA = 2, SideB = 4, SideC = 3 };
var figure3 = new Circle() { Radius = 10 };
var figure4 = new Triangle() { SideA = 3, SideB = 4, SideC = 5 };

ProcessFigureArea(figure1, exec1);
ProcessFigureArea(figure2, exec1);
ProcessFigureArea(figure3, exec1);
ProcessFigureArea(figure4, exec1);

IsTriangleRight(figure2, exec2);
IsTriangleRight(figure4, exec2);

Console.ReadKey();

void ProcessFigureArea<T>(T figure, FigureAreaCalculator toolService) where T : class, IFigure, new()
{
    var area = toolService.CalculateArea(figure);
    var areaText = (area == default) ? "Расчет невозможен" : area.ToString();
    var figureInfo = $"Фигура: {typeof(T)}, Площадь: {areaText}";
    Console.WriteLine(figureInfo);
}

void IsTriangleRight(Triangle triangle, TriangleTypeDetermineService toolService)
{
    var isTriangleRight = toolService.IsRightTriangle(triangle) ? "Да" : "Нет";
    var figureInfo = $"Фигура: {typeof(Triangle)}, Прямоугольный: {isTriangleRight}";
    Console.WriteLine(figureInfo);
}


