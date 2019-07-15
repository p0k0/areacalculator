using calculator.primitive.visitors;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace calculator.primitive.implementation.factory.tests
{
    [TestClass]
    public class TriangleTest
    {
        private FigureFactory _figureFactoryfactory;

        public TriangleTest()
        {
            _figureFactoryfactory = new FigureFactory();
        }
        
        [TestMethod]
        public void Should_VisitorIsConfirmedBeTrue_When_TriangleAcceptVisitorTheoremBackPythagorean()
        {
            
            var a = 3d;
            
            var b = 4d;
            
            var c = 5d;
            var triangle = _figureFactoryfactory.CreateTriangle(a, b, c);
            var pythagoreanTheorem = new VisitorTheoremBackPythagorean(1e-2);
            triangle.Accept(pythagoreanTheorem);
            
            Assert.IsTrue(pythagoreanTheorem.IsConfirmed);
        }
        
        [TestMethod]
        public void Should_VisitorIsConfirmedBeFalse_When_TriangleAcceptVisitorTheoremBackPythagorean()
        {
            var a = 4d;
            var b = 4d;
            var c = 4d;
            var triangle = _figureFactoryfactory.CreateTriangle(a, b, c);
            var visitorTheorem = new VisitorTheoremBackPythagorean(1e-2);
            triangle.Accept(visitorTheorem);
            
            Assert.IsFalse(visitorTheorem.IsConfirmed);
        }
        
        [TestMethod]
        public void Should_VisitorIsConfirmedBeTrue_When_TriangleAcceptVisitorThoeremByInnerOuterRadius()
        {
            var a = 3d;
            var b = 4d;
            var c = 5d;
            var triangle = _figureFactoryfactory.CreateTriangle(a, b, c);
            var visitorTheorem = new VisitorTheoremByInnerOuterRadius(1e-2);
            triangle.Accept(visitorTheorem);
           
            Assert.IsTrue(visitorTheorem.IsConfirmed);
        }
    }
}