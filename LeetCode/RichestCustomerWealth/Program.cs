using System;

namespace RichestCustomerWealth
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] accounts = new int[,]{ {1, 2, 3 },{3, 2, 1 }, { 8, 2, 1 } };
            int max = 0;
            for (int i = 0; i < accounts.GetLength(0); i++)
            {
                int number = 0;
                for (int j = 0; j < accounts.GetLength(1); j++)
                {

                    number += accounts[i, j];
                }
                if (max < number)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);
        }
    }
}
