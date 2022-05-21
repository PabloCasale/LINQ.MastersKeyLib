using LINQ.MastersKeyLib.Printer;
using LINQ.MastersKeyLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.Methods
{
    public class MethodMinAndMax
    {
        private readonly IPeopleService peopleService;

        public MethodMinAndMax(IPeopleService peopleService)
        {
            Print.Title(nameof(MethodMinAndMax));
            this.peopleService = peopleService;
        }

        public void Execute()
        {
            var numbers = this.peopleService.Numbers();

            var people = this.peopleService.GetPeople();

            var maxHeight = people.Max(x => x.Height);
            var minHeight = people.Min(x => x.Height);

            Print.KeyValue(nameof(maxHeight), maxHeight);
            Print.KeyValue(nameof(minHeight), minHeight);

            var maxWeight = people.Max();
            Print.KeyValue(nameof(maxWeight), maxWeight);

            var averageNumber = numbers.Average();
            Print.KeyValue(nameof(averageNumber), averageNumber);

            var averageWeight = people.Average(x => x.Weight);
            Print.KeyValue(nameof(averageWeight), averageWeight);

            var sumOfNumbers = numbers.Sum();
            Print.KeyValue(nameof(sumOfNumbers), sumOfNumbers);

            var sumOfWeights = people.Sum(x => x.Weight);
            Print.KeyValue(nameof(sumOfWeights), sumOfWeights);

        }
    }
}
