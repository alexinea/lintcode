using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(0, 0)); //=>0
            Console.WriteLine(Add(1, 1)); //=>2
            Console.WriteLine(Add(2, 3)); //=>5
            Console.WriteLine(Add(453, 777)); //=> 1230
            Console.WriteLine(Add(-7,-7)); //=> -14
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            return ((x & y) << 1) + (x ^ y);
        }

    }
}
