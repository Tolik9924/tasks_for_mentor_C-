using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterfacesOOP
{
    public class Builder : IDeveloper, IComparable
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

        public int CompareTo(object other) 
        {
            IDeveloper c = other as IDeveloper;
            string tool = c.Tool;
            return String.Compare(this._tool, tool);
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
