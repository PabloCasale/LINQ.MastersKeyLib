using LINQ.MastersKeyLib.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.Comparers
{
    public class PersonByKingdomComparer : IComparer<Person>
    {
        public int Compare(Person? x, Person? y) => x.Kingdom.CompareTo(y.Kingdom);
    }
}
