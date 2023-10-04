using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesOOP
{
    public class Bird : IFlyable
    {
        private string _name;
        private bool _canFly;

        public Bird(string name, bool canFly)
        {
            _name = name;
            _canFly = canFly;            
        }

        public string Fly()
        {
            return _canFly ? $"Bird {_name} Can Fly" : $"Bird {_name} can't fly"; 
        }
    }
}
