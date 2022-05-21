using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.MastersKeyLib.Printer
{
    public static class Print
    {
        public static void Title(string title)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Write(string value)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(value);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void WriteLine(string value)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void KeyValue(string key, object value)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(key + ": ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value.ToString());
        }

        public static void ValueInt(int value)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Bool(string name, bool result)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(name + ": ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(result);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void List<T>(string name, IEnumerable<T> values)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(name + ": ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(string.Join(", ",values));
            
        }

        public static void ListNewLine<T>(string name, IEnumerable<T> values)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(name + ": ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(string.Join("\n", values));

        }
    }
}
