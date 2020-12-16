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

            for (int i =1; 1 < nums.Length;  i++)
            {
                nums[i] += nums[i-1];
            }

            Console.WriteLine("{0}", string.Join(", ", nums));


        }
    }
}
