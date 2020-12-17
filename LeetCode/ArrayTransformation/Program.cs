using System;

namespace ArrayTransformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("< ArrayTransformation >");
            int[] intArray = {2, 1, 2, 1, 1, 2, 2, 1};


            int number = -1;
            int[] newArray = intArray;
            //while (number < 0)
            //{
            //    foreach (var item in intArray)
            //    {
            //        Console.Write(item);
            //    }
            //    Console.WriteLine();
                //number = 0;
                for (int i = 1; i < intArray.Length - 1; i++)
                {
                Console.WriteLine(i);
                    if ((intArray[i] > intArray[i - 1]) && (intArray[i] > intArray[i + 1]))
                    {
                        newArray[i] = newArray[i] - 1;
                        number -= 1;
                        //Console.WriteLine(newArray[i]);
                    }
                    if ((intArray[i] < intArray[i - 1]) && (intArray[i] < intArray[i + 1]))
                    {
                        newArray[i] = newArray[i] + 1;
                        number -= 1;
                    }
                }
            //}
        }
    }
}
