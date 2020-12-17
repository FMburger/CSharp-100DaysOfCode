using System;
using System.Linq;

namespace RunningSumof1dArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("< Runing Sum of 1d Array >");
            Console.Write("Please input your number: ");
            string str = Console.ReadLine();
            string[] stringArray = new[] { str };
            int[] nums = stringArray.Select(x => int.Parse(x)).ToArray();

            int sum = 0;
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                result[i] = sum;
            }

            Console.WriteLine(nums);


        }
    }
}
