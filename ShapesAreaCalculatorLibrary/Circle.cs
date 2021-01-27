using System;

namespace ShapesAreaCalculatorLibrary
{
    public class Circle : Shape, IAreaCalcuator
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            type = "Круг";

            this.Radius = radius;
        }

        public double GetArea()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
