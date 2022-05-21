using LINQ.MastersKeyLib.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.Comparers
{
    public class PersonComparerById : IEqualityComparer<Person>
    {
        public bool Equals(Person? x, Person? y)
        {
            if(x == null || y == null) { return false; }
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Person obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
