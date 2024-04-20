using FigureToolsLib;
public class ConcreteFactory : BaseFigureToolsFactory<double>
{
    public ConcreteFactory(string toolType) : base(toolType)
    {
    }
}