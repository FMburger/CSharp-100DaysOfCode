using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {2, 7, 11, 13};
            int target = 9;
            Console.WriteLine(string.Join(",", Program.TwoSum(nums, target)));

        }
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (nums[j] + nums[i] == target)
                    {
                        int[] num = { j, i };
                        return num;
                    }
                }

            }
            return null;
        }
    }
}
