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
    public class MethodAll
    {
        private readonly IPeopleService peopleService;

        public MethodAll(IPeopleService peopleService)
        {
            Print.Title("ALL FUNCTION");
            this.peopleService = peopleService;
        }

        public void AllFunction()
        {
            var numbers = new int[]{ 5,7,4,9};
            var areAllNumbersGreaterThanZero = numbers.All(x => x > 0);

            Print.List(nameof(numbers), numbers);
            Print.Bool(nameof(areAllNumbersGreaterThanZero),areAllNumbersGreaterThanZero);

            var people = this.peopleService.GetPeople();
            
            Print.List(nameof(people), people);

            var allpeopleHaveNames = people.All(x => !string.IsNullOrEmpty(x.Name));
            Print.Bool(nameof(allpeopleHaveNames), allpeopleHaveNames);

            var allPeopleIsFromIsengard = people.All(x => x.Kingdom == Kingdoms.Isengard);
            Print.Bool(nameof(allPeopleIsFromIsengard),allPeopleIsFromIsengard);
        }
    }
}
