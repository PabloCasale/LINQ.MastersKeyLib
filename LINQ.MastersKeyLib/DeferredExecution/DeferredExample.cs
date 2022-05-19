using LINQ.MastersKeyLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.DeferredExecution
{
    public class DeferredExample
    {
        public void Execute()
        {
            Console.WriteLine("\nDEFERRED EXAMPLE:");

            var words = new List<string> { "a", "bbbb", "cc", "dddddd" };
            Console.WriteLine("Letters: " + string.Join(", ",words));
            var shortWords = words.Where(word => word.Length < 3); //query does not update
            //var shortWords = words.Where(word => word.Length < 3).ToList(); //will be updated on every call

            Console.WriteLine("First Iteration");
            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }

            words.Add("e");

            Console.WriteLine("Second Iteration");
            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }

            var people = new List<Person>
            {
                new Person{ Id = 1,Name = "Frodo", Kingdom = Enums.Kingdoms.TheShire, Height = 0.60},
                new Person{ Id = 2, Name = "Sam", Kingdom = Enums.Kingdoms.TheShire, Height = 0.58}
            };

            var personWithIdLessThan5 = people.Where(person => person.Id < 5);

            var firstfivepersons = people.Take(5);

            foreach (var person in personWithIdLessThan5)
            {
                Console.WriteLine("Person ID: " + person.Id);
            }

            foreach (var person in firstfivepersons)
            {
                Console.WriteLine("FirstFivePersons: " + person.ToString());
            }

            var animals = new List<string>()
            {
                "Duck", "Lion", "Dolphin", "Tiger"
            };

            var animalsWithD = animals.Where(animal =>
            {
                Console.WriteLine("Checking animal: " + animal);
                return animal.StartsWith('D');
            });

            foreach (var animal in animalsWithD)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("With Id < 5: " + string.Join(", ", personWithIdLessThan5));
            Console.WriteLine("First Five persons: " + string.Join(", ", firstfivepersons));


        }
    }
}
