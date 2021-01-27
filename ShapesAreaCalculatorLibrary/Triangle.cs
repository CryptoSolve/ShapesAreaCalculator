using System;

namespace ShapesAreaCalculatorLibrary
{
    public class Triangle : Shape, IAreaCalcuator
    {
        public double A => sides[0];
        public double B => sides[1];
        public double C => sides[2];
        private double[] sides;

        public Triangle(double a, double b, double c)
        {
            type = "Треугольник";
            this.sides = new double[] { a, b, c };
            Array.Sort(sides);

            for (int i = 0; i < sides.Length; i++)
            {
                if (sides[i] <= 0)
                {
                    Console.WriteLine("Треугольник с заданными параметрами не может существовать");
                    return;
                }
            }
            if (sides[2] < sides[1] + sides[0])
            {
                Console.WriteLine("Треугольник с заданными параметрами не может существовать");
                return;
            }
        }

        public double GetArea()
        {
            double p = (A + B + C) / 2;

            double S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return S;
        }

        public bool IsRectangular()
        {
            bool result = false;
            try
            {
                for (int i = 0; i < sides.Length; i++)
                {
                    int j = i % sides.Length;
                    if (sides[j] * sides[j] + sides[j + 1] * sides[j + 1] == sides[j + 2] * sides[j + 2])
                    {
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            {
            }

            return result;
        }
    }
}
