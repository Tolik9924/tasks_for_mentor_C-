using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesOOP
{
    public class Programmer : IDeveloper, IComparable
    {
        private string _language;

        public Programmer(string language)
        {
            _language = language;
        }

        public string Tool
        {
            get => _language;
            set 
            { 
                _language = value;
            }
        }

        public int CompareTo(object other)
        {
            IDeveloper c = other as IDeveloper;
            string tool = c.Tool;
            return String.Compare(this._language, tool);
        }

        public string Create()
        {
            return $"This developer create language {_language}";
        }

        public string Destroy()
        {
            return $"This developer destroy language: {_language}";
        }
    }
}
