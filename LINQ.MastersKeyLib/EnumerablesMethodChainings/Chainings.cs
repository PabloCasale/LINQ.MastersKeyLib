using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.EnumerablesMethodChainings
{
    public class Chainings
    {
        public void Execute()
        {
            Console.WriteLine("LINQ CHAININGS");

            var numbers = new List<int> { 5,7,3,4,2,1,9,8,6};
            var numbersWith10 = numbers.Append(10);

            Console.WriteLine("Numbers: " + string.Join(", ", numbers));
            Console.WriteLine("Numbers with 10: " + string.Join(", ", numbersWith10));

            var orderedOddNumbers = numbers.Where(number => number % 2 == 1).OrderBy(number => number);
            Console.WriteLine("Ordered Odd Numbers: " + string.Join(", ", orderedOddNumbers));
        }
    }
}
