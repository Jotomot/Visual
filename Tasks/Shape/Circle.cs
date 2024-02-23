using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle : IShape
    {
        private const double PI = 3.14159265359;
        private decimal radius;
        public decimal Radius { get { return radius; } set { radius = value; } }

        public Circle(decimal radius)
        {
            Radius = radius;
        }
        public decimal CalculateArea() => (decimal)PI * (Radius * Radius);

        public decimal CalculatePerimeter()
        {
            return (decimal)PI * Radius * 2;
        }
    }
}
