using System;
using System.Text;

namespace NumberOf1Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input your number: ");
            uint n = Convert.ToUInt32(Console.ReadLine()); // n = 11
            string s = Convert.ToString(n, 2);             // s = '1011'     
            char[] ch = s.ToCharArray();                   // ch = [1,0,1,1]
            int num = 0;

            foreach (char c in ch)
            {
                if (c == '1')
                {
                    num = num + 1;
                }
            }
            Console.WriteLine(num);
        }
    }
}
