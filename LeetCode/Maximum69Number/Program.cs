using System;

namespace Maximum69Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a number: ");
            int num = Int32.Parse(Console.ReadLine());
            char[] arr = num.ToString().ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '6')
                {
                    Console.WriteLine(arr[i]);
                    arr[i] = '9';
                    break;
                }
            }
            string str = new string(arr);
            int x = Int32.Parse(str);
            Console.WriteLine(x);
        }
    }
}
