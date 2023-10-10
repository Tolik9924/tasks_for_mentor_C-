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
        }
    }
}
