using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.ExtensionMethods
{
    public static class StringExtensions
    {
        public static int GetCountOfLines(this string input)
        {
            return input.Split("\n").Length;
        }
    }
}
