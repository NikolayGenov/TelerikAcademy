using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrayProject
{
    class TestBitArray
    {
        static void Main(string[] args)
        {
            BitArray64 testOne = new BitArray64(423423523);
            BitArray64 testTwo = new BitArray64(1);
            BitArray64 testThree = new BitArray64(9);

            Console.WriteLine(testOne == testTwo);

            Console.WriteLine(testTwo.Equals(testThree));
        }
    }
}