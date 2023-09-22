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
            Console.WriteLine(ShowThreeFirstLetters(word));

            // TASK 4
            int firstNumber = 4;
            int secondNumber = 5;

            Console.WriteLine(CheckingPositiveNumbers(firstNumber, secondNumber));

            // HOMEWORK
            // 1

            int side = 5;

            Console.WriteLine(ShowAreaAndPerimeterOfSquare(side));

            // 2
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            char[] subsName = name.ToCharArray();
            subsName[0] = Char.ToUpper(subsName[0]);
            name = new string(subsName);
            Console.WriteLine("How old are you, {0}?", name);
            int age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("You are {0}. Your age is {1}", name, age);

            // 3
            double radius = 4.3;

            Console.WriteLine(ShowLengthAreaVolumeOfCircle(radius));
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

        public static string ShowThreeFirstLetters(string word)
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

        public static string ShowAreaAndPerimeterOfSquare(int side)
        {
            int area = side * side;
            int perimeter = side * 4;

            return $"Area: {area}, Perimeter: {perimeter}";
        }

        public static string ShowLengthAreaVolumeOfCircle(double radius)
        {
            double pi = Math.PI;
            double length = 2 * pi * radius;
            double area = pi * radius;
            double volume = 4 / 3 * pi * radius * radius * radius;
            return $"Length: {length}, Area: {area}, Volume: {volume}";
        }
    }
}
