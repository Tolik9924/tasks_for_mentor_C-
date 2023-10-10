namespace AbstractOOP
{
    public class Program
    {
        static void Main(string[] args) 
        { 
            // TASK
            List<Person> persons = new List<Person>();
            persons.Add(new Teacher("Tom", 1000, "Math"));
            persons.Add(new Teacher("John", 2000, "English"));
            persons.Add(new Teacher("Mike", 3000, "Physics"));
            persons.Add(new Developer("Antony", 4000, "junior"));
            persons.Add(new Developer("Angelo", 5000, "middle"));
            persons.Add(new Developer("Franklin", 6000, "senior"));

            for (int i = 0; i < persons.Count; i++) 
            {
                persons[i].Print();                
            }

            Console.WriteLine("Input person name");
            string person = Console.ReadLine();

            for (int i = 0; i < persons.Count; i++)
            {
                if (person == persons[i].Name)
                {
                    persons[i].Print();                    
                }                
            }

            Console.WriteLine("Sort");
            persons.Sort();
            for (int i = 0;i < persons.Count; i++) 
            {
                Console.WriteLine(persons[i].Name);
            }
            
            List<Staff> staffs = new List<Staff>();

            for (int i = 0; (i < persons.Count); i++)
            {
                staffs.Add((Staff) persons[i]);
            }

            Console.WriteLine("Order by staff.");
            List<Staff> query = staffs.OrderBy(s => s.Salary).ToList();
            
            for (int i = 0; i < query.Count; i++)
            {
                Console.WriteLine($"Order by Staff Name: {query[i].Name} Salary: {query[i].Salary}");
            }

            // HOMEWORK
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square("square", 4));
            shapes.Add(new Square("square", 5));
            shapes.Add(new Square("square", 10));
            shapes.Add(new Square("square", 8));
            shapes.Add(new Square("square", 7));
            shapes.Add(new Circle("circle", 4));
            shapes.Add(new Circle("circle", 8));
            shapes.Add(new Circle("circle", 12));
            shapes.Add(new Circle("circle", 7));
            shapes.Add(new Circle("circle", 8));

            for (int i = 0; i < shapes.Count; i++) 
            {
                Console.WriteLine(
                    $"Name: {shapes[i].Name} " +
                    $" Perimeter: {shapes[i].Perimeter()} " +
                    $" Area: {shapes[i].Area()}"
                );
            }

            string maxPerimeterName = "";
            double max = 0;

            for (int i = 0; i < shapes.Count; i++) 
            { 
                if (shapes[i].Perimeter() > max)
                {
                    max = shapes[i].Perimeter();
                    maxPerimeterName = shapes[i].Name;
                }
            }

            Console.WriteLine($"Max Perimeter in Shape " +
                $"Name: {maxPerimeterName} " +
                $"Perimeter: {max}"
            );

            Console.WriteLine("Sort Area");
            shapes.Sort();

            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine($"Sort Area Shapes Name: {shapes[i].Name} Area: {shapes[i].Area()}");
            }

            // LINQ
            // TASKS
            List<int> numbers = new List<int>() { 1, 5, -3, 2, 1, 7, 8, -9, 23, 12 };

            for (int i = 0; i < numbers.Count; i++) 
            { 
                if (numbers[i] < 0 )
                {
                    Console.WriteLine("Negative Number: " + numbers[i]);
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    Console.WriteLine("Positive Number: " + numbers[i]);
                }
            }

            Console.WriteLine("Max: " + numbers.Max());
            Console.WriteLine("Min: " + numbers.Min());
            Console.WriteLine("Sum: " + numbers.Sum());

            for (int i = 0; i < numbers.Count ; i++)
            {
                if (numbers[i] > numbers.Sum() / numbers.Count)
                {
                    Console.WriteLine("First max number than average: " + numbers[i]);
                    break;
                }
            }

            numbers = numbers.OrderBy(number => number).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("Order Number: " + numbers[i]);
            }

            // HOMEWORK
            List<Shape> shapes1 = new List<Shape>();
            shapes1.Add(new Circle("circle1", 1));
            shapes1.Add(new Circle("circle2", 4));
            shapes1.Add(new Circle("circle3", 8));
            shapes1.Add(new Square("square1", 10));
            shapes1.Add(new Square("square2", 20));
            shapes1.Add(new Square("square3", 60));

            IEnumerable<Shape> matches = from shape in shapes1
                          where shape.Area() >= 10 && shape.Area() <= 100
                          select shape;

            foreach (Shape s in matches)
                Console.WriteLine("Name: {0} Area: {1}", s.Name, s.Area());

            IEnumerable<Shape> shapeA = from shape in shapes1
                                        where shape.Name.Contains("a")
                                        select shape;

            foreach (Shape s in shapeA)
                Console.WriteLine("Name: {0}", s.Name);            

            shapes1.RemoveAll((item) => item.Perimeter() < 5);

            Console.WriteLine("Perimeter less than 5");
            for (int i = 0; i < shapes1.Count; i++) 
            {
                Console.WriteLine($"Less 5 " +
                    $"Name: {shapes1[i].Name} " +
                    $"Perimeter: {shapes1[i].Perimeter()}");
            }

        }        
    }
}
