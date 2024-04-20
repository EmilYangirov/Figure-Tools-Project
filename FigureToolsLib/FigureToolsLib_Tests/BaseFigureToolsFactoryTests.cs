using FigureToolsLib_Tests.TestAbstractClassRealizations;

namespace FigureToolsLib_Tests
{
    public class BaseFigureToolsFactoryTests
    {
        [Fact]
        public void ExecuteToolProcessing_ConcreteFigure_WithoutStrategy_DefaultValue()
        {
            var toolType = "tool";
            var factory = new ConcreteFactory(toolType);
            var figure = new ConcreteFigure();
            var result = factory.ExecuteToolProcessing(figure);
            double expected = default;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ExecuteToolProcessing_ConcreteFigure_ConcreteStrategy_10()
        {
            var toolType = "tool";
            var factory = new ConcreteFactory(toolType);
            var strategy = new ConcreteStrategy(toolType);
            var figure = new ConcreteFigure();

            factory.AddTool(strategy);
            var result = factory.ExecuteToolProcessing(figure);
            double defaultValue = default;
            double expected = 10;
            Assert.NotEqual(result, defaultValue);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GetTool_ExistedTool_Tool()
        {
            var toolType = "tool";
            var factory = new ConcreteFactory(toolType);
            var strategy = new ConcreteStrategy(toolType);
            var figure = new ConcreteFigure();

            factory.AddTool(strategy);

            Assert.NotNull(factory.GetTool(figure));
            Assert.Equal(strategy, factory.GetTool(figure));
        }

        [Fact]
        public void GetTool_NotExistedTool_Null()
        {
            var toolType = "tool";
            var factory = new ConcreteFactory(toolType);
            var figure = new ConcreteFigure();

            Assert.Null(factory.GetTool(figure));
        }

        [Fact]
        public void AddTool_CorrectTool_ToolAdded()
        {
            var toolType = "tool";
            var factory = new ConcreteFactory(toolType);
            var strategy = new ConcreteStrategy(toolType);

            var strategiesStartCount = factory.GetToolsCount();
            var expectedStartCount = 0;

            Assert.Equal(expectedStartCount, strategiesStartCount);

            factory.AddTool(strategy);
            var strategiesEndCount = factory.GetToolsCount();
            var expectedEndCount = 1;

            Assert.Equal(expectedEndCount, strategiesEndCount);
        }

        [Fact]
        public void AddTool_IcorrectTool_ToolNotAdded()
        {
            var toolType = "tool";
            var icnorrectToolType = "incorrectTool";
            var factory = new ConcreteFactory(toolType);
            var strategy = new ConcreteStrategy(icnorrectToolType);

            var strategiesStartCount = factory.GetToolsCount();
            var expectedStartCount = 0;

            Assert.Equal(expectedStartCount, strategiesStartCount);

            factory.AddTool(strategy);
            var strategiesEndCount = factory.GetToolsCount();
            var expectedEndCount = 0;

            Assert.Equal(expectedEndCount, strategiesEndCount);
        }

        [Fact]
        public void AddTool_SameTool_ToolNotAdded()
        {
            var toolType = "tool";
            var factory = new ConcreteFactory(toolType);
            var strategy1 = new ConcreteStrategy(toolType);
            var strategy2 = new SameStrategy(toolType);

            var strategiesStartCount = factory.GetToolsCount();
            var expectedStartCount = 0;

            Assert.Equal(expectedStartCount, strategiesStartCount);

            factory.AddTool(strategy1);
            var strategiesSecondCount = factory.GetToolsCount();
            var expectedSecondCount = 1;

            Assert.Equal(expectedSecondCount, strategiesSecondCount);

            factory.AddTool(strategy2);
            var strategiesEndCount = factory.GetToolsCount();
            var expectedEndCount = 1;

            Assert.Equal(expectedEndCount, strategiesEndCount);
        }
    }
}