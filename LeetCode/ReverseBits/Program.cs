using System;

namespace ReverseBits
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please input a unsigned integer: ");
            uint u = Convert.ToUInt32(Console.ReadLine());
            string binary = Convert.ToString(u, 2);
            char[] ch = binary.PadLeft(32, '0').ToCharArray();
            char[] c = new char[1];
            for (int i = 0; i < 16; i++)
            {
                c[0] = ch[i];
                ch[i] = ch[31 - i];
                ch[31 - i] = c[0];
            }
            string s = new string(ch);
            Console.WriteLine(Convert.ToInt32(s, 2));
        }
    }
}
