using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOOP
{
    public abstract class Shape
    {
        private string name;

        public Shape(string name)
        {
            this.name = name;
        }

        virtual public string Name
        {
            get { 
                return name; 
            }

            set { 
                name = value; 
            }
        }
        
        public abstract double Area();

        public abstract double Perimeter();
    }
}
