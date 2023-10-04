using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesOOP
{
    public class Plane : IFlyable
    {
        private string _name;
        private bool _highFly;

        public Plane(string name, bool highFly)
        {
            _name = name;
            _highFly = highFly;
        }
        public string Fly()
        {
            return _highFly 
                ? $"Plane {_name} can high fly." 
                : $"Plane {_name} can't high fly.";
        }
    }
}
