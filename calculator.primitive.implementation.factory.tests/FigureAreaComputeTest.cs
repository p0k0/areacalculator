using System;
using AutoFixture;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace calculator.primitive.implementation.factory.tests
{
    [TestClass]
    public class FigureAreaComputeTest
    {
        private Fixture _fixture;
        
        private FigureFactory _figureFactoryfactory;
        
        public FigureAreaComputeTest()
        {
            _fixture = new Fixture();
            _fixture.Customizations.Add(new RandomRangedNumberGenerator());
            _figureFactoryfactory = new FigureFactory();
        }
        
        [DataTestMethod]
        [DataRow(1e-3)]
        [DataRow(1e-5)]
        public void Should_ReturnSameAreaWithGivenPrecision_When_CircleGetAreaInvoked(double precision)
        {
            var radius = _fixture.Create<double>();
            var circle = _figureFactoryfactory.CreateCircle(radius);
            var expected = radius * radius * Math.PI;
            var result = circle.GetArea();
            var diff = expected - result;
            diff = diff * Math.Sign(diff);
            
            Assert.IsTrue( diff <= precision);
        }
        
        [DataTestMethod]
        [DataRow(1e-3)]
        [DataRow(1e-5)]
        public void Should_ReturnSameAreaWithGivenPrecision_When_TriangleGetAreaInvoked(double precision)
        {
            var a = _fixture.Create<double>();
            var b = _fixture.Create<double>();
            var c = (a + b) * 0.7; // a + b < c
            var p = (a + b + c) / 2d;
            var triangle = _figureFactoryfactory.CreateTriangle(a, b, c);
            var expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            var result = triangle.GetArea();
            var diff = expected - result;
            diff = diff * diff;
            
            Assert.IsTrue( diff <= precision);
        }
    }
}