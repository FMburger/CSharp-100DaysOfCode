using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] s = { 'h', 'e', 'l', 'l', 'o' };
            //Array.Reverse(s);
            char[] c = new char[1];
            for (int i = 0; i < (s.Length) / 2; i++)
            {
                c[0] = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = c[0];
            }
            Console.WriteLine(s);
        }
    }
}
