using System;

namespace NumberofGoodPairs
{
    public int NumIdenticalPairs(int[] nums)
    {
        int count = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[i] == nums[j] && i < j)
                {
                    count += 1;
                }
            }
        }
        return (count);
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("< Number of Good Pairs >");
        }
    }
}
