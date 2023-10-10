using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfacesOOP
{
    public class Builder : IDeveloper
    {
        private string _tool;

        public Builder(string tool)
        {
            _tool = tool;
        }

        public string Tool
        {
            get => _tool;
            set
            {
                _tool = value;
            }
        }

        public int CompareTo(IDeveloper other) 
        {
            return this.Tool.CompareTo(other.Tool);
        }

        public string Create()
        {
            return $"This developer create language {_tool}";
        }

        public string Destroy()
        {
            return $"This developer destroy language: {_tool}";
        }
    }
}
