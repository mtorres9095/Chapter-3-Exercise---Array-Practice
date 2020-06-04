using System;

namespace Chapter_3_Exercise___Array_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 2, 3, 5, 8 };
            for (int i = 0; i < nums.Length; i++)
            {
                int numero = nums[i];
                if (numero % 2 != 0)
                {
                    // Console.WriteLine(nums[i1]);
                    Console.WriteLine(nums[i]);
                }

            }
        }
    }
}
