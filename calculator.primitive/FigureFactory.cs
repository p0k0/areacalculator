using System;

namespace calculator.primitive
{
    public class FigureFactory
    {
        public Circle CreateCircle(double radius)
        {
            return new Circle(radius);
        }
        
        public Triangle CreateTriangle(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }
    }
}