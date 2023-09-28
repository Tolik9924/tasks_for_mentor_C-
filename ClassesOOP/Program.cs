namespace ClassesOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task
            Console.WriteLine("Task");
            Car car = new Car();
            Car car1 = new Car("green", 200, "bmv");
            car.Input();
            car.ChangePrice(2);
            car.Color = "blue";            
            Console.WriteLine(car.Print());
            if (car == car1)
            {
                Console.WriteLine("Same name and price.");
            }
            Console.WriteLine(car1.ToString());

            // Homework
            Person person = new Person();
            Person person2 = new Person("Tom", new DateTime(2008, 5, 1));
            Person person3 = new Person("John", new DateTime(1998, 5, 1));
            Person person4 = new Person("John", new DateTime(1998, 5, 1));
            person.Input();
            Console.WriteLine("Person 1 Age: " + person.Age());
            Console.WriteLine("Person 1 Age: " + person.Output());
            int ageOfPerson2 = person2.Age();
            if (ageOfPerson2 < 16) 
            {
                person2.ChangeName("Very Young");
            }
            Console.WriteLine("Person 2 Age: " + person2.Output());
            if (person3 == person4) 
            {
                Console.WriteLine("These person has same name.");
            }
        }
    }
}