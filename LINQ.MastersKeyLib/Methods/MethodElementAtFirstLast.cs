using LINQ.MastersKeyLib.Printer;
using LINQ.MastersKeyLib.Services;

namespace LINQ.MastersKeyLib.Methods
{
    public class MethodElementAtFirstLast
    {
        private readonly IPeopleService peopleService;

        public MethodElementAtFirstLast(IPeopleService peopleService)
        {
            Print.Title(nameof(MethodElementAtFirstLast));
            this.peopleService = peopleService;
        }

        public void Execute()
        {
            var people = this.peopleService.GetPeople();

            var firstElement = people.ElementAt(0);
            Print.KeyValue(nameof(firstElement), firstElement.ToString());

            var nonExisistingElement = people.ElementAtOrDefault(100);
            Print.WriteLine(nameof(nonExisistingElement) + ": " + nonExisistingElement);


            var firstPerson = people.First();
            Print.KeyValue(nameof(firstPerson), firstPerson);

            var lastperson = people.Last();
            Print.KeyValue(nameof(lastperson), lastperson);

            //var lastPersonHeavierThan100 = people.Last(x => x.Weight > 200);
            // 'Last()' no person with value higher than expected will throw an error, use LastOrDefault

            var lastPersonHeavierThan100 = people.LastOrDefault(x => x.Weight > 200);
            Print.WriteLine(nameof(lastPersonHeavierThan100) + ": " +lastPersonHeavierThan100);

            var lastPersonHeavier = people.OrderBy(people => people.Weight).Last();
            Print.KeyValue(nameof(lastPersonHeavier), lastPersonHeavier);

            //Will work only if there's one instance of the element, if the element occurrences is 0 or > 1 throws an error 
            var peopleSingle = people.Single(x => x.Kingdom == Enums.Kingdoms.Mordor);
            Print.KeyValue(nameof(peopleSingle), peopleSingle);

            //It will work if the parameter exists only one time, if null doesn't throw error, if number of occurrences is > 0, will throw error
            var peopleSingleOrDefault = people.SingleOrDefault(x => x.Height == 0.5);
            Console.WriteLine(nameof(peopleSingleOrDefault) + ": " + peopleSingleOrDefault);
        }
    }
}
