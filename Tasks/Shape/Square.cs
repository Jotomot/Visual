using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Square : IShape
    {

        private decimal sideLenght;
        public decimal SideLenght {
            get { return sideLenght;  }
            set { sideLenght = value; } }

        public Square(decimal sideLenght)
        {
            this.sideLenght = sideLenght;
        }

        public decimal CalculateArea()
        {
            return (sideLenght * sideLenght);
        }

        public decimal CalculatePerimeter()
        {
            return (sideLenght * 4);
        }
    }
}
