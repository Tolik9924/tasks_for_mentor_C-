using System;
using System.Xml.Linq;

namespace Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // TASKS

            // Task 1
            int firstNumber = 3;
            int secondNumber = 10;

            Console.WriteLine(DivideWithoutRemainders(
                firstNumber,
                secondNumber,
                3)
            );

            // Task 2
            string text = "some text";

            ShowEachCharacter(text);

            // Task 3
            string drink = "juice";

            Console.WriteLine(ShowPriceOfDrink(drink));

            // Task 4
            string number = "1 2 -3 4 7";

            Console.WriteLine(ShowAveragePositiveNumbers(number));

            // Task 5
            int year = 2019;

            Console.WriteLine("Is Leap Year: " + IsLeapYear(year));

            // Task 6
            int number1 = 365;

            Console.WriteLine(SumOfIntNumber(number1));

            // Task 7
            int number2 = 153;

            Console.WriteLine("Contain Odd Digit: " + ContainOddDigit(number2));

            // HOMEWORK

            // Homework 1
            string word = "Hello";

            Console.WriteLine("Count of vowells: " + ShowCountOfVowels(word));

            // Homework 2
            int month = 4;

            Console.WriteLine("Days: " + ShowCountOfDaysInThisMonth(month, year));

            // Homework 3
            string numbers = "1 2 3 -4 5 6 7 8 9 10";

            Console.WriteLine("Result: " + SumOrProduct(numbers));
        }

        public static int DivideWithoutRemainders(
            int firstNumber,
            int secondNumber,
            int divide
            )
        {

            int count = 0;

            if (firstNumber < secondNumber)
            {
                for (int i = firstNumber; i < secondNumber; i++)
                {
                    if (i % divide == 0)
                    {
                        count++;
                    }
                }
                return count;
            }

            Console.WriteLine("First number must be less than second.");
            return count;
        }

        public static void ShowEachCharacter(string text)
        {
            string textReplace = text.Replace(" ", "");

            for (int i = 0; i < textReplace.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(textReplace[i]);
                }                
            }
        }

        public static string ShowPriceOfDrink(string drink)
        {
            int price = 0;

            switch (drink)
            {
                case "coffe":
                    price = 4;
                    return $"Drink: {drink} Price: {price}$";
                case "tea":
                    price = 2;
                    return $"Drink: {drink} Price: {price}$";
                case "juice":
                    price = 5;
                    return $"Drink: {drink} Price: {price}$";
                case "water":
                    price = 1;
                    return $"Drink: {drink} Price: {price}$";
                default:
                    return "This drink is not in our list.";
            }
        }

        public static double ShowAveragePositiveNumbers(string numbers)
        {
            string[] numbersStr = numbers.Split(" ");
            List<int> nAverageList = new List<int>();
            double average = 0;

            for (int i = 0; i < numbersStr.Length; i++)
            {
                if (Convert.ToInt32(numbersStr[i]) < 0)
                {
                    average = nAverageList.Average();
                    break;
                }

                nAverageList.Add(Convert.ToInt32(numbersStr[i]));
            }

            return average;
        }

        public static bool IsLeapYear(int year)
        {
            if (DateTime.IsLeapYear(year))
            {
                return true;
            }

            return false;
        }

        public static int SumOfIntNumber(int num)
        {
            string numStr = num.ToString();
            int sum = 0;
            int number = 0;

            for (int i = 0; i < numStr.Length; i++)
            {
                number = numStr[i] - '0';
                sum += number;
            }

            return sum;
        }

        public static bool ContainOddDigit(int num)
        {
            bool isOdd = true;
            string numStr = num.ToString();
            int number = 0;

            for (int i = 0; i < numStr.Length; i++)
            {
                number = numStr[i] - '0';                
                if (number % 2 == 0)
                {
                    isOdd = false;
                    break;
                }
            }

            return isOdd;
        }

        public static int ShowCountOfVowels(string word)
        {
            int sum = 0;
            List<char> letters = new List<char>() { 'a', 'o', 'i', 'e' };

            for (int i = 0; i < word.Length; i++) 
            { 
                for (int j = 0; j < letters.Count; j++)
                {
                    if (letters[j] == word[i]) 
                    { 
                        sum++; 
                    }
                }
            }

            return sum;
        }

        public static int ShowCountOfDaysInThisMonth(int month, int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;                    
                case 2:
                    if (DateTime.IsLeapYear(year))
                    {
                        return 29;
                    }
                    return 28;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;                    
                default:
                    Console.Write("invalid Month number.\nPlease try again ....\n");
                    break;
            }
                return 0;
        }

        public static int SumOrProduct(string numbers)
        {
            string[] numStr = numbers.Split(" ");
            int sum = 0;
            int product = 1;
            int number = 0;
            bool isSum = true;            
            for (int i = 0; i < numStr.Length; i++)
            {
                number = Convert.ToInt32(numStr[i]);                

                if (number < 0)
                {
                    i = 4;
                    isSum = false;                    
                }

                if (!isSum && i >= 5)
                {
                    product *= number;
                }

                if (i == 5 && isSum)
                {
                    break;
                }

                if (isSum)
                {
                    sum += number;
                }                
            }
            return isSum ? sum : product;
        }
    }
}