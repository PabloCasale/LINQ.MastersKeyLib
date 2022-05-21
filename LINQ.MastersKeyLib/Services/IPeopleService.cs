using LINQ.MastersKeyLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.Services
{
    public interface IPeopleService
    {
        List<Person> GetPeople();
        int[] Numbers();
    }
}
