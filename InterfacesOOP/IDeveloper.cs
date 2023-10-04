using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesOOP
{
    public interface IDeveloper
    {
        public string Tool { get; set; }
        public string Create();
        public string Destroy();
    }
}
