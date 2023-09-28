using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOOP
{
    public class Car
    {
        private string _color;
        private double _price;
        private string _companyName;
        private bool _isEnteredData = false;

        public Car()
        {
            
        }

        public Car(string color, double price, string companyName)
        {
            _color = color;
            _price = price;
            _companyName = companyName;
        }

        public string Color
        {
            get => _color; 
            set => _color = value;
        }

        public void Input()
        {
            Console.WriteLine("Input color of car.");
            _color = Console.ReadLine();
            Console.WriteLine("Input price of car.");
            _price = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input company name of car.");
            _companyName = Console.ReadLine();
            _isEnteredData = true;
        }

        public string Print()
        {
            string result = ToString();
            if (_isEnteredData) 
            {                
                return result;
            }

            return "Input Data Please";
        }

        public void ChangePrice(double price) 
        {
            _price = _price - (_price * price ) / 100;
        }

        public static bool operator == (Car first, Car second)
        {
            return first._companyName == second._companyName 
                && first._price == second._price;
        }

        public static bool operator !=(Car first, Car second)
        {
            return first._companyName == second._companyName
                && first._price == second._price;
        }

        public override string ToString()
        {
            return $"Color: {_color} Price: {_price} Company Name: {_companyName}";
        }
    }
}
