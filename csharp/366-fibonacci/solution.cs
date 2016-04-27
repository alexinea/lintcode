using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fibonacci(1)); //==> 0
            Console.WriteLine(Fibonacci(2)); //==> 1
            Console.WriteLine(Fibonacci(3)); //==> 1
            Console.WriteLine(Fibonacci(4)); //==> 2
            Console.WriteLine(Fibonacci(10)); //==> 34
            Console.WriteLine(Fibonacci(47)); //==> 1836311903
            Console.ReadLine();
        }

        static long Fibonacci(int n)
        {
            if (n <= 0)
                throw new ArgumentOutOfRangeException(nameof(n));

            if (n == 1)
                return 0;

            long n1 = 1;
            long n2 = 1;
            long ret = 1;

            for (int i = 4; i <= n; i++)
            {
                ret = n1 + n2;
                n1 = n2;
                n2 = ret;
            }

            return ret;
        }

    }

}
