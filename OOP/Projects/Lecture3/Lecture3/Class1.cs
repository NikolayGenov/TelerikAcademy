using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture3
{
    public class Class1
    {
        static void Main()
        {
            var p = new { X = 3, Y = 5 };
            var q = new { X = 3, Y = 5 };
            Console.WriteLine(p == q); // false
            Console.WriteLine(p.Equals(q)); // true
 
        }
    }
}
