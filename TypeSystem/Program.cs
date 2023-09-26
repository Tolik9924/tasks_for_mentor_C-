using System;
using System.Linq;
using System.Xml.Schema;

namespace TypeSystem
{
    public enum TestCaseStatus { 
        Pass, 
        Fail, 
        Blocked, 
        WP, 
        Unexecuted 
    }
    
    public struct RGB
    {
        public byte red;
        public byte green;
        public byte blue;
        public byte black;
        public byte white;

    }

    public enum HTTPError
    {
       HTTP401, 
       HTTP402, 
       HTTP403, 
       HTTP404,
    }

    public struct Dog
    {
        public string name;
        public string mark;
        public int age;
        public string ToString()
        {
            return $"Name: {name}, Mark: {mark} Age: {age}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // TASKS

            // TASK 1

            int month = 9;
            int day = 26;

            Console.WriteLine(GetDateString(month, day));

            // TASK 2

            double number = 3.456;

            Console.WriteLine(GetSumFromDoubleNumber(number));

            // TASK 3

            int h = 5;

            Console.WriteLine(RepresentTimeOfTheDay(h));

            // TASK 4
            
            TestCaseStatus test1Status = TestCaseStatus.Pass;

            Console.WriteLine("Test Case Status: " + test1Status);

            // TASK 5

            RGB color;
            color.black = 0000;
            color.white = 255;
            byte black = color.black;
            byte white = color.white;

            // HOMEWORK

            // Homework 1

            float firstNumber = 2.45F;
            float secondNumber = 3.45F;
            float thirdNumber = 10.45F;
            int firstNumberInRange = -5;
            int secondNumberInRange = 5;

            Console.WriteLine("Is it in range: " + AreInRage(
                firstNumber,
                secondNumber,
                thirdNumber,
                firstNumberInRange,
                secondNumberInRange
                ));

            // Homework 2
            int firstNumber1 = 1;
            int secondNumber1 = 2;
            int thirdNumber1 = 3;

            int[] numbers = { firstNumber1, secondNumber1, thirdNumber1 };


            Console.WriteLine("Minimum number is " + numbers.Min());
            Console.WriteLine("Maximum number is " + numbers.Max());

            // Homework 3
            HTTPError myError401 = HTTPError.HTTP401;
            Console.WriteLine(myError401);

            // Homework 4
            Dog myDog = new Dog();
            myDog.name = "dog";
            myDog.mark = "mark";
            myDog.age = 4;
            Console.WriteLine(myDog.ToString());
        }

        public static string GetDateString(int month, int day)
        {
            try
            {
                return new DateTime(DateTime.Now.Year, month, day).ToString("dd.MM");
            }
            catch (FormatException)
            {
                return "Error: Invalid date format. Please input a valid date in the format dd/mm/yyyy.";
            }
            catch (Exception ex)
            {
                return "An error occurred: " + ex.Message;
            }
        }

        public static int GetSumFromDoubleNumber(double number)
        {
            int sum = 0;
            int decimal_point_found = 0;

            string numberString = number.ToString();
            char[] charNumber = numberString.ToCharArray();
            int count = 0;
            int maxDoSum = 2;

            for (int i = 0; i < charNumber.Length; i++)
            {                                
                if (!Char.IsDigit(charNumber[i]))
                {                    
                    if (charNumber[i] == ',' && decimal_point_found == 0)
                    {
                        decimal_point_found = 1;
                        continue;
                    }
                    Console.WriteLine("ERROR: enter a valid number\n");
                    return 1;
                }

                if (decimal_point_found == 1 && count < maxDoSum)
                {
                    int convertNumber = charNumber[i] - '0';

                    sum += convertNumber;
                    count++;
                }
            }            

            return sum;
        }

        public static string RepresentTimeOfTheDay(int hour)
        {
            if (hour > 0 && hour <= 3)            
                return "Good Night";             
            else if (hour > 3 && hour <= 12)             
                return "Good Morning";             
            else if (hour == 12)            
                return "Good Noon";            
            else if (hour > 12 && hour <= 15)
                return "Good AfterNoon";
            else if (hour > 15 && hour < 20)
                return "Good Evening";
            else if (hour >= 20 && hour <= 24)
                return "Good Night";

            return "Input valid hour";
        }

        public static bool AreInRage(
            float firstNumber, 
            float secondNumber, 
            float thirdNumber,
            int firstNumberInRange,
            int secondNumberInRange
            )
        {
            List<float> numbers = new List<float>() { 
                firstNumber,
                secondNumber,
                thirdNumber
            };

            bool isInRange = true;

            for( int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < firstNumberInRange
                    || numbers[i] > secondNumberInRange)
                {
                    isInRange = false;
                    break;
                }                
            }

            return isInRange;
        }        
    }
}