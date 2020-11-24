using System;

namespace Multiplicationtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("< Multiplication Table >");
            Console.WriteLine();

            Console.Write("Please input your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write(" X".PadRight(4));
            
            for (int i = 1; i <= num; i++)
            {
                Console.Write(i.ToString("####").PadLeft(4));
            }
            Console.WriteLine();
            Console.Write(" ___");

            for (int i = 1; i <= num; i++)
            {
                Console.Write(" ___");
            }
            Console.WriteLine();
            Console.WriteLine();
            
            for (int row = 1; row <= num; row++)
            {
                Console.Write(row.ToString("###").PadLeft(3).PadRight(4));
                for (int col = 1; col <= num; col++)
                {
                    if (row <= col)
                        Console.Write((row * col).ToString("###").PadLeft(4));
                    else
                        Console.Write("".PadLeft(4));
                }
 
                Console.WriteLine();
            }
 
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
