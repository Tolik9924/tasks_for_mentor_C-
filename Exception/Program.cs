using System;

namespace ExceptionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 2;            

            Console.WriteLine(Div(a, b));
            Console.WriteLine("Input 10 numbers: ");


            string numbersStr = Console.ReadLine();
            int start = 1;
            int end = 20;
            Console.WriteLine("Is in range: " + ReadNumber(start, end, numbersStr));
        }

        public static double Div(int a, int b)
        {
            int result = 0;

            try
            {
                result = a / b;
            }            
            catch (DivideByZeroException ex)
            {
                throw new DivideByZeroException("Don't divide by zero.");
            }
            catch (FormatException ex)
            {
                throw new ArgumentException("Numbers must int type.");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        public static bool ReadNumber(
            int start, 
            int end, 
            string numberStr
            )
        {
            bool isReadNumber = true;
            String[] strList = numberStr.Split(' ');
            
            if (strList.Length < 10 || strList.Length > 10)
            {
                throw new Exception($"Numbers must be in range {start} to {end}");
            }

            for (int i = 0; i < strList.Length; i++)
            {
                if (int.Parse(strList[i]) !< start || int.Parse(strList[i]) !> end)
                {
                    throw new IndexOutOfRangeException($"Number: {strList[i]} is not in range.");
                }
                
            }

            return isReadNumber;
        }
    }
}