using FigureToolsLib;
using System.Reflection.Metadata.Ecma335;

public class ConcreteFactory : BaseFigureToolsFactory<double>
{
    public ConcreteFactory(string toolType) : base(toolType)
    {
    }

    public int GetToolsCount() => _strategies.Count;
}