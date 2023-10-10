using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOOP
{
    public class Square : Shape
    {
        private int side;

        public Square(string name, int side)
            : base(name)
        {
            this.side = side;
        }        

        public override double Area()
        {
            return side * 2;
        }

        public override double Perimeter()
        {
            return side * 4;
        }     
    }
}
