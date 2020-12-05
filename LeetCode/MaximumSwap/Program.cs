using System;

namespace MaximumSwap
{
    class Program
    {
        public int MaximumSwap(int num)
        {
            string s = Convert.ToString(num);
            char[] ch = s.ToCharArray();

            if (ch.Length > 1)
            {
                for (int i = 0; i < ch.Length - 1; i++)
                {

                    if (ch[i] != '9')
                    {
                        int n = i;
                        for (int j = i + 1; j < ch.Length; j++)
                        {
                            if (ch[i] < ch[j] && ch[j] >= ch[n])
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

                            goto end;
                        }
                    }
                }
                end:
                string s2 = new string(ch);
                int parsed = Convert.ToInt32(s2);
                return parsed;

            }
            else
            {
                return num;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Write("Please input your number: ");
            int num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(p.MaximumSwap(num));
        }
    }
}
