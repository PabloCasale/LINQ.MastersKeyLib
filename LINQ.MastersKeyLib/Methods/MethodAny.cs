using LINQ.MastersKeyLib.Enums;
using LINQ.MastersKeyLib.Models;
using LINQ.MastersKeyLib.Printer;
using LINQ.MastersKeyLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.Methods
{
    public class MethodAny
    {
        private readonly IPeopleService peopleService;

        public MethodAny(IPeopleService peopleService)
        {
            Print.Title(nameof(MethodAny));
            this.peopleService = peopleService;
        }
        public void AnyFunction()
        {
            var numbers = new[] { 1, 5, 9, 2, 4, 0 };
            Print.List(nameof(numbers), numbers);


            bool isAnyLargerThan5 = numbers.Any(x => x > 5);
            Print.Bool(nameof(isAnyLargerThan5), isAnyLargerThan5);

            var people = this.peopleService.GetPeople();

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            var isAnyFromIsengard = people.Any(person => person.Kingdom == Kingdoms.Isengard);
            Print.Bool(nameof(isAnyFromIsengard), isAnyFromIsengard);

            var isAnyFromGondorAndTall = people.Any(person => person.Kingdom == Kingdoms.Gondor && person.Height >= 1.50);
            Print.Bool(nameof(isAnyFromGondorAndTall), isAnyFromGondorAndTall);

        }
    }
}
