using LINQ.MastersKeyLib.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.EnumerablesMethodChainings
{
    public class Chainings
    {
        public Chainings()
        {
            Print.Title(nameof(Chainings));
        }
        public void Execute()
        {
            

            var numbers = new List<int> { 5,7,3,4,2,1,9,8,6};
            var numbersWith10 = numbers.Append(10);

            
            Print.List(nameof(numbers), numbers);
            Print.List(nameof(numbersWith10), numbersWith10);

            var orderedOddNumbers = numbers.Where(number => number % 2 == 1).OrderBy(number => number);
            Print.List(nameof(orderedOddNumbers), orderedOddNumbers);
        }
    }
}
