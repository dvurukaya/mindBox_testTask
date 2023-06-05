using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testTask_mindBox.Interfaces;

namespace testTask_mindBox
{
    public class Triangle : IArea
    {
        private double side_A { get; }
        private double side_B { get; }
        private double side_C { get; }

        public Triangle(double side_A, double side_B, double side_C)
        {
            this.side_A = side_A;
            this.side_B = side_B;
            this.side_C = side_C;
        }

        public double getArea() 
        {
            if (isTriangleReal() == false) return 0;
            double perimeter = (side_A + side_B + side_C) / 2;
            return Math.Sqrt(perimeter * (perimeter - side_A) * (perimeter - side_B) * (perimeter - side_C));
        }

        public bool isTriangleReal()
        {
            return side_A + side_B > side_C && side_B + side_C > side_A && side_C + side_A > side_B;
        }

        public bool isTriangleRightAngled()
        {
            return Math.Pow(side_A, 2) + Math.Pow(side_B, 2) == Math.Pow(side_C, 2);
        }
    }
}
