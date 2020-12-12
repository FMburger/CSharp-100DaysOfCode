using System;

namespace SingleNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<Single Number>");
            Console.WriteLine("1> Single Number 1");
            Console.WriteLine("1> Single Number 2");
            Console.Write("Please input a number: ");
            int caseNumber = Int32.Parse(Console.ReadLine());

            switch (caseNumber)
            {
                case 1:
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
                        if (i == (Aint.Length - 1))
                        {
                            n = Aint[i];
                            break;
                        }
                        else
                        {
                            // Find the single number
                            if (Aint[i] != Aint[i + 1] & ((i + 1) % 2) == 1)
                            {
                                n = Aint[i];
                                break;
                            }
                        }
                    }
                    Console.WriteLine(n);
                    break;
                case 2:
                    Console.Write("Please input a number: ");
                    string str2 = Console.ReadLine();
                    // Convert string to char array
                    char[] arr2 = new char[str2.Length];

                    // Convert chart array to int array
                    for (int i = 0; i < str2.Length; i++)
                    {
                        arr2[i] = str2[i];
                    }
                    int[] Aint2 = Array.ConvertAll(arr2, c => (int)Char.GetNumericValue(c));

                    // Sorting array
                    Array.Sort(Aint2);

                    int n2 = 0;
                    for (int i = 0; i < Aint2.Length; i+=3)
                    {
                        if (i == (Aint2.Length - 1))
                        {
                            n = Aint2[i];
                            break;
                        }
                        else
                        {
                            // Find the single number
                            if (Aint2[i] != Aint2[i + 1])
                            {
                                n2 = Aint2[i];
                                break;
                            }
                        }
                    }
                    Console.WriteLine(n2);
                    break;
                default:
                    break;
            }
        }
    }
}
