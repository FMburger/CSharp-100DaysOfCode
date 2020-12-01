using System;

namespace FindTheDuplicateNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input a number: ");
            string str = Console.ReadLine();
            // Convert string to char array
            char[] arr = new char[str.Length];

            // Convert chart array to int array
            for (int i = 0; i < str.Length; i++)
            {
                arr[i] = str[i];
            }
            int[] Aint = Array.ConvertAll(arr, c => (int)Char.GetNumericValue(c));

            // Sorting array
            Array.Sort(Aint);

            int n = 0;
            for (int i = 0; i < Aint.Length; i++)
            {
                // Find the duplicate number
                if (Aint[i] == Aint[i + 1])
                {
                    n = Aint[i];
                    break;
                }
            }
            Console.WriteLine(n);
        }
    }
}
