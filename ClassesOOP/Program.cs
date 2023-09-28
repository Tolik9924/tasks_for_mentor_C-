using System.Drawing;

namespace ClassesOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task
            Color c1 = Color.FromKnownColor(KnownColor.LightSeaGreen);
            Console.WriteLine("Task");
            Car car = new Car();
            Car car1 = new Car(c1, 200, "bmv");
            car.Input();
            car.ChangePrice(10);
            car.ColorCar = Color.FromKnownColor(KnownColor.White);
            Console.WriteLine(car.Print());
            if (car == car1)
            {
                Console.WriteLine("Same name and price.");
            }
            Console.WriteLine(car1.ToString());

            // Homework
            List<Person> personsList = new List<Person>();
            personsList.Add(new Person());
            personsList.Add(new Person("Tom", new DateTime(2008, 5, 1)));
            personsList.Add(new Person("John", new DateTime(2008, 5, 1)));
            personsList.Add(new Person("Tom", new DateTime(2008, 5, 1)));
            personsList.Add(new Person("John", new DateTime(2008, 5, 1)));

            List<string> samePerson = new List<string>();

            

            for (int i = 0; i < personsList.Count; i++) 
            {                
                for (int j = 0; j < personsList.Count; j++) 
                {
                    if (personsList[i] == personsList[j]
                        && i != j
                        && !samePerson.Contains(personsList[i].Name)
                       )
                    {
                        samePerson.Add(personsList[i].Name);
                        Console.WriteLine("These person has same name.");
                    }
                }                
            }

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

            Person[] persons = {
                new Person("Tom", new DateTime(2008, 5, 1)),
                new Person("John", new DateTime(1998, 5, 1)),
                new Person("John", new DateTime(1998, 5, 1))
            };
        }
    }
}
