﻿using LINQ.MastersKeyLib.Enums;
using LINQ.MastersKeyLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.Methods
{
    public class MethodAny
    {
        public MethodAny()
        {
            Console.WriteLine(Environment.NewLine + "ANY EXAMPLE");
        }
        public void AnyFunction()
        {
            var numbers = new[] { 1, 5, 9, 2, 4, 0 };

            bool isAnyLargerThan5 = numbers.Any(x => x > 5);
            Console.WriteLine(isAnyLargerThan5);

            var people = new[]
            {
                new Person(1, "Gimli", Kingdoms.Moria,0.75),
                new Person(2, "Aragorn", Kingdoms.Gondor, 1.88),
                new Person(3, "Legolas", Kingdoms.Rivendel, 1.79),
                new Person(4, "Sauron", Kingdoms.Mordor, 2.10),
                new Person(5, "Saruman", Kingdoms.Isengard, 1.90),
                new Person(6, "Frodo", Kingdoms.TheShire, 0.50)
            };

            var isAnyFromIsengard = people.Any(person => person.Kingdom == Kingdoms.Isengard);
            Console.WriteLine(nameof(isAnyFromIsengard) + ": " + isAnyFromIsengard);

            var isAnyFromGondorAndTall = people.Any(person => person.Kingdom == Kingdoms.Gondor && person.Height >= 1.50);
            Console.WriteLine(nameof(isAnyFromGondorAndTall) + " " + isAnyFromGondorAndTall);

        }
    }
}
