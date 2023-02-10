using System;

namespace GeomentryHelper.Models
{
    public class Circle : IAreaCalculation
    {
        public double Radius { get; private set; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус окружности не может иметь отрицательное или нулевое значение!");

            Radius = radius;
        }

        public double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 6);
        }
    }
}
