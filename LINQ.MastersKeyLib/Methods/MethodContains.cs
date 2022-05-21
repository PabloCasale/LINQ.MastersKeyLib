using LINQ.MastersKeyLib.Comparers;
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
    public class MethodContains
    {
        private readonly IPeopleService peopleService;

        public MethodContains(IPeopleService peopleService)
        {
            Print.Title(nameof(MethodContains));
            this.peopleService = peopleService;
        }

        public void Execute()
        {
            var people = this.peopleService.GetPeople();

            bool isgandalfPresent = people.Select(x => x.Name).Contains("Gandalf");
            Print.Bool(nameof(isgandalfPresent), isgandalfPresent);

            var person = new Person { Id = 14, Name = "Eomer", Kingdom = Enums.Kingdoms.Rohan, Height = 1.98 };
            bool isPresentComparerById = people.Contains(person, new PersonComparerById());
            Print.Bool(nameof(isPresentComparerById), isPresentComparerById);

            var aragorn = people[0];
            bool isAragornPresent = people.Contains(aragorn);
            Print.Bool(nameof(isAragornPresent), isAragornPresent);
        }
    }
}
