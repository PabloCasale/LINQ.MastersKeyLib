using LINQ.MastersKeyLib.Models;
using LINQ.MastersKeyLib.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.DeferredExecution
{
    public class DeferredExample
    {
        public DeferredExample()
        {
            Print.Title(nameof(DeferredExample));
        }
        public void Execute()
        {

            var words = new List<string> { "a", "bbbb", "cc", "dddddd" };
            Print.List(nameof(words), words);

            var shortWords = words.Where(word => word.Length < 3); //query does not update
            //var shortWords = words.Where(word => word.Length < 3).ToList(); //will be updated on every call

            Print.WriteLine("First Iteration");
            foreach (var word in shortWords)
            {
                Console.WriteLine(word);
            }

            words.Add("e");

            Print.WriteLine("Second Iteration");
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

            Print.List(nameof(personWithIdLessThan5), personWithIdLessThan5);
            Print.List(nameof(firstfivepersons), firstfivepersons);


        }
    }
}
