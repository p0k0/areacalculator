using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace calculator.primitive.implementation.factory.tests
{
    [TestClass]
    public class TriangleTest
    {
        private FigureFactory _figureFactoryfactory;
        private double _tolerance = 1e-5;

        public TriangleTest()
        {
            _figureFactoryfactory = new FigureFactory();
        }
        
        [TestMethod]
        public void Should_TriangleHasRightAngleReturnTrue_When_TriangleHasRightAngle()
        {
            var a = 3d;
            var b = 4d;
            var c = 5d;
            var triangle = _figureFactoryfactory.CreateTriangle(a, b, c);
            var visitorTheorem = new PythagoreanTheorem(1e-2);
            triangle.Accept(visitorTheorem);
            
            Assert.IsTrue(visitorTheorem.IsConfirmed);
        }
        
        [TestMethod]
        public void Should_TriangleHasRightAngleReturnFalse_When_TriangleNotHasRightAngle()
        {
            var a = 4d;
            var b = 4d;
            var c = 4d;
            var triangle = _figureFactoryfactory.CreateTriangle(a, b, c);
            var visitorTheorem = new PythagoreanTheorem(1e-2);
            triangle.Accept(visitorTheorem);
            
            Assert.IsFalse(visitorTheorem.IsConfirmed);
        }
    }
}