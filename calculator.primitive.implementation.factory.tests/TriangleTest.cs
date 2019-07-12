using calculator.primitive.implementation.factory.figure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace calculator.primitive.implementation.factory.tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void Should_TriangleHasRightAngleReturnTrue_When_TriangleHasRightAngle()
        {
            var factory = new TriangleFactory();
            var a = 3d;
            var b = 4d;
            var c = 5d;
            var triangle = factory.CreateTriangle(a, b, c) as Triangle<double>;
            
            Assert.IsTrue(triangle.HasRightAngle());
        }
        
        [TestMethod]
        public void Should_TriangleHasRightAngleReturnFalse_When_TriangleNotHasRightAngle()
        {
            var factory = new TriangleFactory();
            var a = 4d;
            var b = 4d;
            var c = 4d;
            var triangle = factory.CreateTriangle(a, b, c) as Triangle<double>;
            
            Assert.IsFalse(triangle.HasRightAngle());
        }
    }
}