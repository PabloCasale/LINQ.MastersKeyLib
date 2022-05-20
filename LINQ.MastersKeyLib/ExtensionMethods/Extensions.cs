using LINQ.MastersKeyLib.Printer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.ExtensionMethods
{
    public class Extensions
    {
        public Extensions()
        {
            Print.Title("Extensions");
        }

        public void Execute()
        {
            var words = new[] { "a", "bb", "ccc", "dddd" };
            var wordsLongerThan2Letters = words.Where(x => x.Length > 2);

            var multiLineString = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                                    Praesent vitae cursus tellus.Mauris vulputate erat eget cursus euismod.
                                    Integer ac leo eu neque laoreet accumsan.Aenean pretium, felis at posuere gravida, eros lorem porttitor sapien, sed egestas leo leo nec magna.
                                    Vestibulum bibendum nisl vel est dignissim, dapibus bibendum augue pellentesque.In dui ipsum, laoreet nec erat ac, fringilla eleifend odio.
                                    Praesent nec pharetra felis, ac varius magna. Quisque quam lacus, rutrum vestibulum varius pellentesque, aliquet sit amet lectus.
                                    Nunc id lacinia mi, vitae lacinia mi. Mauris lacus sem, aliquam ut sollicitudin ut, blandit eget magna.
                                    Nullam in arcu porta diam malesuada condimentum.";


            Print.List(nameof(wordsLongerThan2Letters), wordsLongerThan2Letters);
            Print.Write(nameof(multiLineString));
            Console.WriteLine(multiLineString.GetCountOfLines().ToString());
        }
    }
}
