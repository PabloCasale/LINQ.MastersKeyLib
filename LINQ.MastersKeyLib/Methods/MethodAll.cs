using LINQ.MastersKeyLib.Enums;
using LINQ.MastersKeyLib.Models;
using LINQ.MastersKeyLib.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.Methods
{
    public class MethodAll
    {
        public MethodAll()
        {
            Print.Title("ALL FUNCTION");
        }

        public void AllFunction()
        {
            var numbers = new int[]{ 5,7,4,9};
            var areAllNumbersGreaterThanZero = numbers.All(x => x > 0);

            Print.List(nameof(numbers), numbers);
            Print.Bool(nameof(areAllNumbersGreaterThanZero),areAllNumbersGreaterThanZero);

            var people = new List<Person>
            {
                new Person{Id = 1, Name = "Aragorn", Kingdom = Kingdoms.Gondor, Height = 1.88},
                new Person{Id = 2, Name = "Legolas", Kingdom = Kingdoms.Rivendel, Height = 1.75},
                new Person{Id = 3, Name = "Gimli", Kingdom = Kingdoms.Moria, Height = 1.00},
                new Person{Id = 4, Name = "Sauron", Kingdom = Kingdoms.Mordor, Height = 2.20},
                new Person{Id = 5, Name = "Saruman", Kingdom = Kingdoms.Isengard, Height = 1.94}
            };
            
            Print.List(nameof(people), people);

            var allpeopleHaveNames = people.All(x => !string.IsNullOrEmpty(x.Name));
            Print.Bool(nameof(allpeopleHaveNames), allpeopleHaveNames);

            var allPeopleIsFromIsengard = people.All(x => x.Kingdom == Kingdoms.Isengard);
            Print.Bool(nameof(allPeopleIsFromIsengard),allPeopleIsFromIsengard);
        }
    }
}
