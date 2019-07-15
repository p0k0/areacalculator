using System;
using calculator.primitive.implementation.factory.figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace calculator.primitive.implementation.factory.tests
{
    [TestClass]
    public class FigureFactoryTest
    {
        [TestMethod]
        public void Should_CreateCircleInstance_When_CircleFactoryCreateCircle()
        {
            var factory = new CircleFigureFactory();

            var result = factory.CreateCircle(It.IsAny<double>());
            
            Assert.IsInstanceOfType(result, typeof(Circle<double>));
        }
        
        [TestMethod]
        public void Should_CreateEllipseInstance_When_EllipseFactoryCreateEllipse()
        {
            var factory = new EllipseFactory();

            var result = factory.CreateEllipse(It.IsAny<double>(), It.IsAny<double>());
            
            Assert.IsInstanceOfType(result, typeof(Ellipse<double>));
        }
        
        [TestMethod]
        public void Should_CreateTriangleInstance_When_TriangleFactoryCreateTriangle()
        {
            var factory = new TriangleFactory();

            var result = factory.CreateTriangle(It.IsAny<double>(), It.IsAny<double>(), It.IsAny<double>());
            
            Assert.IsInstanceOfType(result, typeof(Triangle<double>));
        }
        
        [TestMethod]
        public void Should_ThrowNotImplementedException_When_TriangleFactoryCreateCircle()
        {
            var factory = new TriangleFactory();

            Assert.ThrowsException<NotImplementedException>(() => factory.CreateCircle(It.IsAny<double>()));
        }
        
        [TestMethod]
        public void Should_ThrowNotImplementedException_When_TriangleFactoryCreateEllipse()
        {
            var factory = new TriangleFactory();

            Assert.ThrowsException<NotImplementedException>(() => factory.CreateEllipse(It.IsAny<double>(), It.IsAny<double>()));
        }
    }
}
