using System;

namespace ToLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your input: ");
            string str = Console.ReadLine();

            Console.WriteLine(str.ToLower());
        }
    }
}
