using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractOOP
{
    public class Staff : Person, IComparable
    {
        private int salary;

        public Staff(string name, int salary) : base(name)
        {
            this.salary = salary;
        }

        virtual public int Salary { get { return salary; } }

        override public string Name 
        { 
            get
            {
                return base.Name + " Staff";
            }
        }

        public int CompareTo(object other)
        {
            Staff person = other as Staff;
                     
            return String.Compare(Name, person.Name);                        
        }

        public override void Print()
        {
            Console.WriteLine("Person {0} has salary: ${1}", Name, this.salary);
        }
    }
}
