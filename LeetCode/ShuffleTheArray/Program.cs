using System;

namespace ShuffleTheArray
{
    class Program
    {
        public int[] Shuffle(int[] nums, int n)
        {

            if (nums.Length == 0)
                return nums;

            int[] newArray = new int[2 * n];
            int index1 = 0, index2 = n;

            for (int i = 0; i < 2 * n; i++)
            {
                if (i % 2 == 0)
                    newArray[i] = nums[index1++];
                else
                    newArray[i] = nums[index2++];
            }

            return newArray;
        }
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 9, 8 };
            int n = 3;

        }
    }
}
