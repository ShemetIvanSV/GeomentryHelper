using System;

namespace GeomentryHelper.Models
{
    public class Triangle : IAreaCalculation
    {
        public double SideA { get; private set; }

        public double SideB { get; private set; }

        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!ValidateTriangle(sideA, sideB, sideC))
            {
                throw new ArgumentException("Фигура не является треугольником!");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        private bool ValidateTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
                return false;
            else if (sideA == 0 || sideB == 0 || sideC == 0)
                return false;
            else
                return true;
        }

        public double GetArea()
        {
            double perimeter = (SideA + SideB + SideC) / 2;
            var area = Math.Sqrt(perimeter * (perimeter - SideA) * (perimeter - SideB) * (perimeter - SideC));
            return Math.Round(area, 6);
        }

        public bool IsRightTriangle()
        {
            return ((Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2)) || 
                   (Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2)) ||
                   (Math.Pow(SideC, 2) + Math.Pow(SideB, 2) == Math.Pow(SideA, 2)));
        }
    }
}
