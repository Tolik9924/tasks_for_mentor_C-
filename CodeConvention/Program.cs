namespace CodeConvention
{
    class Program
    {
        static void Main(string[] args)
        {
            // TASKS

            // TASK 1

            int a = 12;
            int b = 2;
            List<string> operators = new List<string>() { "+", "-", "*", "/" };

            foreach (string op in operators)
            {
                Console.WriteLine(CalculateTwoNumbers(a, b, op));
            }

            // TASK 2
            Console.WriteLine("How are you");
            string howAreYou = Console.ReadLine();
            Console.WriteLine("You are {0}", howAreYou);

            // TASK 3
            string word = "Hello";
            Console.WriteLine(ShowThreeFirsrLetters(word));

            // TASK 4
            int firstNumber = 4;
            int secondNumber = 5;

            Console.WriteLine(CheckingPositiveNumbers(firstNumber, secondNumber));
        }

        public static int CalculateTwoNumbers(int a, int b, string operation)
        {
            int result = 0;
            switch (operation)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    try
                    {
                        result = a / b;
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }
            return result;
        }

        public static string ShowThreeFirsrLetters(string word)
        {
            char[] subs = word.ToCharArray();
            return $"You enter {subs[0]}, {subs[1]}, {subs[2]}";
        }

        public static bool CheckingPositiveNumbers(int firstNumber, int secondNumber)
        {
            if (firstNumber > 0 && secondNumber > 0)
            {
                return true;
            }

            return false;
        }
    }
}
