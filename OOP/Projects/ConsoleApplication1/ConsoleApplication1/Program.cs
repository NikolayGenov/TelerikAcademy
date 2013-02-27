using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new { X = 3, Y = 5 };
            var q = new { X = 3, Y = 5 };
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine(q.GetHashCode());
            Console.WriteLine(p == q); // false
            Console.WriteLine(p.Equals(q)); // true

        }
    }
}
