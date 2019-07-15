using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace calculator.primitive.implementation.factory.tests
{
    [TestClass]
    public class FigureFactoryTest
    {
        private FigureFactory _figureFactoryfactory;

        public FigureFactoryTest()
        {
            _figureFactoryfactory = new FigureFactory();
        }
        
        [TestMethod]
        public void Should_CreateCircleInstance_When_CircleFactoryCreateCircle()
        {

            var result = _figureFactoryfactory.CreateCircle(It.IsAny<double>());
            
            Assert.IsInstanceOfType(result, typeof(Circle));
        }
        
        [TestMethod]
        public void Should_CreateTriangleInstance_When_TriangleFactoryCreateTriangle()
        {
            var result = _figureFactoryfactory.CreateTriangle(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<double>());
            
            Assert.IsInstanceOfType(result, typeof(Triangle));
        }
    }
}
