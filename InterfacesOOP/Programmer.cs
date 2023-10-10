using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesOOP
{
    public class Programmer : IDeveloper
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

        public int CompareTo(IDeveloper other)
        {            
            return this.Tool.CompareTo(other.Tool);
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
