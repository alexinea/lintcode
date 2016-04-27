using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TrailingZeros(13)); //=>2
            Console.WriteLine(TrailingZeros(20)); //=>4
            Console.WriteLine(TrailingZeros(105)); //=>25
            Console.WriteLine(TrailingZeros(1001171717)); //=>250292920
            Console.ReadLine();
        }

        static long TrailingZeros(long n)
        {
            long counter = 0;
            long i = 1;

            while (true)
            {
                i *= 5;
                counter += n / i;
                if (i > n)
                    break;
            }

            return counter;
        }
    }
}
