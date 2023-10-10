using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOOP
{
    public class Circle : Shape
    {

        private int radius;
        public Circle(string name, int radius)
            : base(name)
        {
            this.radius = radius;
        }        

        public override double Area()
        {
            return Math.PI * radius * 2;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
