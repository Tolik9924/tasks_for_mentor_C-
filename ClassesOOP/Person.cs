using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOOP
{
    public class Person
    {
        private string _name;
        private DateTime _birthYear;

        public string Name
        {
            get => _name;
        }

        public DateTime BirthYear
        {
            get => _birthYear;
        }

        public Person()
        {
            _name = "Default Name";
            _birthYear = DateTime.Now;
        }

        public Person(string name, DateTime birthYear)
        {
            _name = name;
            _birthYear = birthYear;
        }

        public int Age()
        {
            return DateTime.Now.Year - _birthYear.Year;
        }

        public void Input()
        {
            Console.WriteLine("Input your name.");
            _name = Console.ReadLine();
            Console.WriteLine("Input your birth year.");
            string dateTime = Console.ReadLine();
            _birthYear = DateTime.Parse(dateTime);
        }

        public void ChangeName(string name)
        {            
            _name = name;
        }

        public override string ToString()
        {
            return $"Name: {_name} Birth Year: {_birthYear.ToString("yyyy-MM-dd")}";
        }

        public string Output()
        {
            string result = ToString();
            return result;
        }

        public static bool operator ==(Person first, Person second)
        {
            return first._name == second._name;               
        }

        public static bool operator !=(Person first, Person second)
        {
            return first._name == second._name;                 
        }
    }
}
