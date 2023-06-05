using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testTask_mindBox.Interfaces;

namespace testTask_mindBox
{
    public class Circle : IArea
    {
        private double circleRadius { get; }

        public Circle(double radius)
        {
            this.circleRadius = radius;
        }

        public double getArea()
        {
            return Math.PI * Math.Pow(circleRadius, 2);
        }
    }
}
