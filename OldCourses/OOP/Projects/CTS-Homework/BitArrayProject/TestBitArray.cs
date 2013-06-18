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
            BitArray64 testOne = new BitArray64(16777225);
            BitArray64 testTwo = new BitArray64(1);
            BitArray64 testThree = new BitArray64(9);

            //Print all the number
            Console.WriteLine("testOne = {0}, testTwo = {1}, testThree = {2}\n", testOne, testTwo, testThree);
           

            //Comapre first two and second two
            Console.WriteLine("testOne == testTwo ? {0}", testOne == testTwo);

            Console.WriteLine("testTwo equals testThree ? {0}\n", testTwo.Equals(testThree));

            //Making the number  9 -> 1001
            testTwo[3] = 1;
            //Change, print and check again
            Console.WriteLine("testOne = {0}, testTwo = {1}, testThree = {2}", testOne, testTwo, testThree);
            Console.WriteLine("testTwo equals testThree ? {0}\n", testTwo.Equals(testThree));

            //Making the 24th bit 0, print and compare if NOT EQUAL
            testOne[24] = 0;
            Console.WriteLine("testOne = {0}, testTwo = {1}, testThree = {2}", testOne, testTwo, testThree);
            Console.WriteLine("testOne != (NOT EQUAL) testTwo ? {0}", testOne != testTwo);
        }
    }
}