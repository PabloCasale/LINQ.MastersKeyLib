using LINQ.MastersKeyLib.Comparers;
using LINQ.MastersKeyLib.Printer;
using LINQ.MastersKeyLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.Methods
{
    public class MethodOrderBy
    {
        private readonly IPeopleService peopleService;

        public MethodOrderBy(IPeopleService peopleService)
        {
            this.peopleService = peopleService;
            Print.Title(nameof(MethodOrderBy));
        }

        public void Execute()
        {
            var people = this.peopleService.GetPeople();

            var peopleOrderByName = people.OrderBy(x => x.Name).Select(y => y.Name);
            Print.List(nameof(peopleOrderByName), peopleOrderByName);

            var orderPeopleByIdDesc = people.OrderByDescending(x => x.Id);
            Print.ListNewLine(nameof(orderPeopleByIdDesc), orderPeopleByIdDesc);

            var orderByKingdomThenByname = people.OrderBy(x => x.Kingdom).ThenBy(x => x.Name);
            Print.ListNewLine(nameof(orderByKingdomThenByname), orderByKingdomThenByname);

            var orderPeoplebyKingdomWithComparer = people.OrderBy(x => x, new PersonByKingdomComparer());

            Print.ListNewLine(nameof(orderPeoplebyKingdomWithComparer), orderPeoplebyKingdomWithComparer);
        }
    }
}
