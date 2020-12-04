using System;

namespace MaximumSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a number: ");
            string s = Console.ReadLine();
            char[] ch = s.ToCharArray();
            for (int i = 0; i < ch.Length - 1; i++)
            {
                if (ch[i] == '9')
                {
                    continue;
                }
                else
                {
                    int n = i;
                    for (int j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[n] < ch[j])
                        {
                            n = j;
                        }
                    }
                    if (n != i)
                    {
                        char[] ch1 = new char[1];
                        ch1[0] = ch[i];
                        ch[i] = ch[n];
                        ch[n] = ch1[0];

                    }
                }
            }
            string s2 = new string(ch);
            Console.WriteLine(s2);
        }
    }
}
