using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOOP
{
    public class Car
    {
        private Color _color = new Color();
        private double _price;
        public const string CompanyName = "BMW";
        private bool _isEnteredData = false;
        private string _name;

        public Car()
        {
            
        }

        public Car(Color color, double price, string name)
        {
            _color = color;
            _price = price;    
            _name = name;
        }

        public Color ColorCar
        {
            get => _color; 
            set => _color = value;
        }

        public void Input()
        {
            Console.WriteLine("Input color of car.");
            _color = Color.FromName(Console.ReadLine());
            Console.WriteLine("Input price of car.");
            _price = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input name of car.");
            _name = Console.ReadLine();
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
            return first._name == second._name 
                && first._price == second._price;
        }

        public static bool operator !=(Car first, Car second)
        {
            return first._name == second._name
                && first._price == second._price;
        }

        public override string ToString()
        {
            return $"Company Name: {CompanyName} " +
                $"Color: {_color} " +
                $"Price: {_price} " +
                $"Company: {_name}";
        }        
    }
}
