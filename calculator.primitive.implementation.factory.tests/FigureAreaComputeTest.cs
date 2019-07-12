using System;
using AutoFixture;
using calculator.primitive.implementation.factory.figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace calculator.primitive.implementation.factory.tests
{
    [TestClass]
    public class FigureAreaComputeTest
    {
        private Fixture _fixture;
        private Random _random;
        
        public FigureAreaComputeTest()
        {
            _fixture = new Fixture();
            _fixture.Customizations.Add(new RandomRangedNumberGenerator());
            _random = new Random(DateTime.UtcNow.Millisecond);
        }
        
        [DataTestMethod]
        [DataRow(1e-3)]
        [DataRow(1e-5)]
        public void Should_ReturnSameAreaWithGivenPrecision_When_CircleGetAreaInvoked(double precision)
        {
            var factory = new CircleFigureFactory();
            var radius = _fixture.Create<double>();
            var circle = factory.CreateCircle(radius);
            var expected = radius * radius * Math.PI;
            var result = circle.GetArea();
            var diff = expected - result;
            diff = diff * Math.Sign(diff);
            
            Assert.IsTrue( diff <= precision);
        }
        
        [DataTestMethod]
        [DataRow(1e-3)]
        [DataRow(1e-5)]
        public void Should_ReturnSameAreaWithGivenPrecision_When_EllipseGetAreaInvoked(double precision)
        {
            
            var factory = new EllipseFactory();
            var a = _fixture.Create<double>();
            var b = _fixture.Create<double>();
            var ellipse = factory.CreateEllipse(a, b);
            var expected = a * b * Math.PI;
            var result = ellipse.GetArea();
            var diff = expected - result;
            diff = diff * Math.Sign(diff);
            
            Assert.IsTrue( diff <= precision);
        }
        
        [DataTestMethod]
        [DataRow(1e-3)]
        [DataRow(1e-5)]
        public void Should_ReturnSameAreaWithGivenPrecision_When_TriangleGetAreaInvoked(double precision)
        {
            var factory = new TriangleFactory();
            var a = _fixture.Create<double>();
            var b = _fixture.Create<double>();
            var c = (a + b) * (_random.Next(1, 1000) / 1000d); // a + b < c
            var p = (a + b + c) / 2d;
            var triangle = factory.CreateTriangle(a, b, c);
            var expected = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            var result = triangle.GetArea();
            var diff = expected - result;
            diff = diff * Math.Sign(diff);
            
            Assert.IsTrue( diff <= precision);
        }
    }
}