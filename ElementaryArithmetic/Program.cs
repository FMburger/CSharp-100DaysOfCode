using System;

namespace ElementaryArithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入第一個數:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("請輸入第二個數:");
            int y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Addition Operator 加法: " + (x + y));

            Console.WriteLine("Subtraction Operator 減法: " + (x - y));

            Console.WriteLine("Multiplication Operator 乘法: "+ (x * y));

            Console.WriteLine("Division Operator 除法: " + (x / y));

            Console.WriteLine("Modulo Operator 取餘數: " + (x % y));

            Console.WriteLine("Press Enter Key to Exit..");

            Console.ReadLine();
        }
    }
}
