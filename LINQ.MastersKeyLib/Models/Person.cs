using LINQ.MastersKeyLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.Models
{
    public class Person : IComparable<Person>
    {

        public int Id { get; set; }
        public string? Name { get; set; }
        public Kingdoms Kingdom { get; set; }

        public double Height { get; set; }
        public int Weight { get; set; }

        public int CompareTo(Person other)
        {
            return Weight.CompareTo(other.Weight);
        }

        public override string ToString()
        {
            return $"ID: {Id} - Name: {Name} - Kingdom: {Kingdom} - Height: {Height} - Weight: {Weight}";
        }
    }
}
