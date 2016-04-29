using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"9 => {NthUglyNumber(9)} << 10");
            Console.WriteLine($"1500 => {NthUglyNumber(1500)} << 859963392");
            Console.WriteLine($"1692 => {NthUglyNumber(1692)} << xxx");
            Console.ReadLine();
        }

        static int NthUglyNumber(int n)
        {
            if (n == 0)
                return 0;

            int[] nums = new int[n];
            nums[0] = 1;
            int idx_2 = 0;
            int idx_3 = 0;
            int idx_5 = 0;
            int idx = 1;
            while (idx < n)
            {
                var min = GetMin(nums[idx_2] * 2, nums[idx_3] * 3, nums[idx_5] * 5);
                if (min == nums[idx_2] * 2)
                    ++idx_2;
                if (min == nums[idx_3] * 3)
                    ++idx_3;
                if (min == nums[idx_5] * 5)
                    ++idx_5;
                nums[idx++] = min;
            }
            return nums[n - 1];
        }

        static int GetMin(int a, int b, int c)
        {
            int temp = a < b ? a : b;
            return temp < c ? temp : c;
        }
    }
}
