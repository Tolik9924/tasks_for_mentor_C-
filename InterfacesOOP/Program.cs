namespace InterfacesOOP
{
    public class Program
    {
        static void Main(string[] args) 
        {
            // Task 5.1
            List<IFlyable> flyables = new List<IFlyable>();
            flyables.Add(new Bird("Penguin", false));
            flyables.Add(new Bird("Papugaya", true));
            flyables.Add(new Plane("High Plane", true));
            flyables.Add(new Plane("Low Plane", false));

            for (int i = 0; i < flyables.Count; i++)
            {
                Console.WriteLine(flyables[i].Fly());
            }

            // Task 5.1
            List<int> numbers = new List<int>() { 1, 2, 3, -10, 5, 23, 7, 8, 9, -10 };

            // find and print all positions of element -10 in this collection.
            Console.WriteLine("Find and print all positions of element -10 in this collection.");
            for (int i = 0; i < numbers.Count;i++) 
            { 
                if (numbers[i] == -10)
                {
                    Console.WriteLine("Positions element: " + i);
                }
            }

            // Remove from collection elements, which are greater then 20
            Console.WriteLine("Remove from collection elements, which are greater then 20");

            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 20)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("Number in List: " + numbers[i]);
            }

            // Insert elements 1,-3,-4 in positions 2, 8, 5. Print new collection.
            Console.WriteLine("Insert elements 1,-3,-4 in positions 2, 8, 5. Print new collection.");
            numbers.Insert(2, 1);
            numbers.Insert(8, -3);
            numbers.Insert(5, -4);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("Number in List: " + numbers[i]);
            }

            // Sort and print collection.
            Console.WriteLine("Sort and print collection.");
            numbers.Sort();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("Number in List: " + numbers[i]);
            }

            // Homework
            List<IDeveloper> developers = new List<IDeveloper>();
            developers.Add(new Programmer("C#"));
            developers.Add(new Programmer("Javascipt"));
            developers.Add(new Builder("Hammer"));
            developers.Add(new Builder("Builder Tool"));

            IDeveloper developer = new Programmer("Java");
            string instrument = developer.Tool;
            Console.WriteLine("Instrument: " + instrument);

            developers.Sort();

            for(int i = 0; i < developers.Count; i++) 
            {
                Console.WriteLine(developers[i].Create());
                Console.WriteLine(developers[i].Destroy());
            }

            // Dictionary
            Dictionary<uint, string> dict = new Dictionary<uint, string>();
            dict.Add(1, "Tom");
            dict.Add(2, "John");
            dict.Add(3, "Andrew");
            dict.Add(4, "Mike");
            dict.Add(5, "Angelo");
            dict.Add(6, "Anna");
            dict.Add(7, "Michelle");
            Console.WriteLine("Input name ID: ");
            string idString = Console.ReadLine();
            uint id = uint.Parse(idString);
            if (dict.ContainsKey(id))
            {
                Console.WriteLine("Person: " + dict[id]);
            }
            else
            {
                Console.WriteLine("Is not user with this id");
            }
        }
    }
}
