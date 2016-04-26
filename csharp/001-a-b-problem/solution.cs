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
            Console.WriteLine(Add(-7, -7)); //=> -14
            Console.WriteLine(Add(-1, 1)); //=> 0
            Console.ReadLine();
        }

        static int Add(int x, int y)
        {
            var a = x ^ y;
            var b = x & y;

            while (b != 0)
            {
                var m = a;
                var n = b << 1;
                a = m ^ n;
                b = m & n;
            }

            return a;
        }

    }
}
