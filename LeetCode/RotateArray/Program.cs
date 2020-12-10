using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<RotateArray>");
            Console.WriteLine("int[] nums = { 1, 2, 5, 9, 4, 11, 6 }");
            Console.WriteLine("int k = 3");
            int[] nums = { 1, 2, 5, 9, 4, 11, 6 };
            int k = 3;
            // Check if k is zero
            if (k == 0) return;

            k %= nums.Length;

            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length - k);

        }
    }
}
