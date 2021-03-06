using LINQ.MastersKeyLib.Enums;
using LINQ.MastersKeyLib.Models;
using LINQ.MastersKeyLib.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.RepositoryService
{
    public class PeopleService : IPeopleService
    {
        readonly List<Person> people = new List<Person>()
        {
            new Person{Id = 1, Name = "Aragorn", Kingdom = Kingdoms.Gondor, Height = 1.88, Weight = 88},
            new Person{Id = 2, Name = "Legolas", Kingdom = Kingdoms.Rivendell, Height = 1.75, Weight = 75},
            new Person{Id = 3, Name = "Gimli", Kingdom = Kingdoms.Erebor, Height = 1.00, Weight = 60},
            new Person{Id = 4, Name = "Sauron", Kingdom = Kingdoms.Mordor, Height = 2.20, Weight = 120},
            new Person{Id = 5, Name = "Saruman", Kingdom = Kingdoms.Isengard, Height = 1.94, Weight = 90},
            new Person{Id = 6, Name = "Frodo", Kingdom = Kingdoms.Shire, Height = 0.60, Weight = 54},
            new Person{Id = 7, Name = "Sam", Kingdom = Kingdoms.Shire, Height = 0.55, Weight = 58},
            new Person{Id = 8, Name = "Gandalf", Kingdom = Kingdoms.Erebor, Height = 1.90, Weight = 96},
            new Person{Id = 9, Name = "Boromir", Kingdom = Kingdoms.Gondor, Height = 1.86, Weight = 90},
            new Person{Id = 10, Name = "Faramir", Kingdom = Kingdoms.Gondor, Height = 1.76, Weight = 84},
            new Person{Id = 11, Name = "Eowyn", Kingdom = Kingdoms.Rohan, Height = 1.66, Weight = 72},
            new Person{Id = 12, Name = "Theoden", Kingdom = Kingdoms.Rohan, Height = 1.90, Weight = 80},
        };

        

        public List<Person> GetPeople()
        {
            return people;
        }

        int[] numbers = { 1, 85, 45, 205, 645, 54, 12, 45, 21, 2, 9, 70, 67 };
        public int[] Numbers()
        {
            return this.numbers;
        }
    }
}
