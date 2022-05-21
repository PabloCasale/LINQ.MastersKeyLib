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
    public class MethodCount
    {
        private readonly IPeopleService peopleService;

        public MethodCount(IPeopleService peopleService)
        {
            Print.Title(nameof(MethodCount));
            this.peopleService = peopleService;
        }

        public void Execute()
        {
            var people = this.peopleService.GetPeople();

            var countOfPeopleFromGondor = people.Count(x => x.Kingdom == Kingdoms.Gondor);
            Print.KeyValue(nameof(countOfPeopleFromGondor), countOfPeopleFromGondor);

            var longCountOfNamedSaruman = people.LongCount(x => x.Name == "Saruman");
            Print.KeyValue(nameof(longCountOfNamedSaruman), longCountOfNamedSaruman);

            var allPeopleCount = people.Count();
            Print.KeyValue(nameof(allPeopleCount), allPeopleCount);

            
        }
    }
}
