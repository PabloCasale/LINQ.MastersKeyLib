using LINQ.MastersKeyLib.Enums;
using LINQ.MastersKeyLib.Printer;
using LINQ.MastersKeyLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.Methods
{
    public class MethodWhere
    {
        private readonly IPeopleService peopleService;

        public MethodWhere(IPeopleService peopleService)
        {
            Print.Title(nameof(MethodWhere));
            this.peopleService = peopleService;
        }

        public void Execute()
        {
            var people = this.peopleService.GetPeople();
            var numbers = this.peopleService.Numbers();

            var peopleWithHeightGraterThan150 = people.Where(x => x.Height > 1.50);
            Print.ListNewLine(nameof(peopleWithHeightGraterThan150), peopleWithHeightGraterThan150);

            var peopleWithNamesStartsWithS = people.Where(x => x.Name != null && x.Name.StartsWith("S"));
            Print.ListNewLine(nameof(peopleWithNamesStartsWithS), peopleWithNamesStartsWithS);

            var specificPeople = people.Where(x =>
                                                (x.Height > 0.5 || x.Height < 2.0)
                                                && x.Kingdom == Kingdoms.Erebor
                                                && x.Weight > 50
                                                && x.Id >= 2
                                                );
            Print.ListNewLine(nameof(specificPeople), specificPeople);

            var lookUpIndexes = new[] { 1, 4, 8 };
            var peopleSelectedByIndexAndFromGondor = people.Where((x, y) =>
                                                            x.Kingdom == Kingdoms.Gondor
                                                            && lookUpIndexes.Contains(y)
                                                            );
            Print.ListNewLine(nameof(peopleSelectedByIndexAndFromGondor), peopleSelectedByIndexAndFromGondor);

            var countOfPeopleFromGondor = people.Count(x => x.Kingdom == Kingdoms.Gondor);
            Print.KeyValue(nameof(countOfPeopleFromGondor), countOfPeopleFromGondor);

            var countOfPeopleWhereKingdomIsGondor = people.Where(x => x.Kingdom == Kingdoms.Gondor).Count();
            Print.KeyValue(nameof(countOfPeopleWhereKingdomIsGondor), countOfPeopleWhereKingdomIsGondor);
        }
    }
}
