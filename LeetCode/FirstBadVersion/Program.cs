using System;

namespace FirstBadVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("< First bad version >");
            Console.Write("Please input your number: ");
            int number = Int32.Parse(Console.ReadLine());
            int start = 1, end = number;
            while (start < end)
            {
                int mid = start + (end - start) / 2;
                if (!IsBadVersion(mid)) start = mid + 1;
                else end = mid;
            }
            return start;
        }
    }
}
