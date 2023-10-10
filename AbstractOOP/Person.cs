using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractOOP
{
    public class Person : IComparable<Person>
    {
        private string name;

        public Person(string name)
        {
            this.name = name;
        }

        public virtual int CompareTo(Person other)
        {
            return String.Compare(Name, other.Name);
        }

        virtual public string Name { get { return name; } }
        virtual public void Print()
        {
            Console.WriteLine("Name: {0}", this.name);
        }        
    }
}
