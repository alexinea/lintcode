using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitCounts(1, 12)); //=>5
            Console.ReadLine();
        }

        static int DigitCounts(int k, int n)
        {
            int counter = 0;
            string sk = "" + k;

            for (var i = 0; i <= n; i++)
            {
                string a = "" + i;
                int f = a.Length - a.Replace(sk, "").Length;
                counter += f;
            }

            return counter;
        }
    }
}
