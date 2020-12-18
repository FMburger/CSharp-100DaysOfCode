using System;

namespace ArrayTransformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("< ArrayTransformation >");
            int[] arr = {2, 1, 2, 1, 1 };

            // 判斷是否需要建立新的 Array
            int number = -1;
            while (number < 0)
            {
                // 將 arr 的值 Clone 給 newArray
                var newArray = (int[])arr.Clone();
                number = 0;

                // 判斷 newArray 中是否有需要變更的數字
                for (int i = 1; i < arr.Length - 1; i++)
                {
                    if ((newArray[i] < newArray[i - 1]) && (newArray[i] < newArray[i + 1]))
                    {
                        arr[i] = arr[i] + 1;
                        number -= 1;
                    }
                    if ((newArray[i] > newArray[i - 1]) && (newArray[i] > newArray[i + 1]))
                    {
                        arr[i] = arr[i] - 1;
                        number -= 1;
                    }
                }
            }
            // 印出 arr
            foreach (var item in arr)
            {
                Console.Write(item);
            }
            Console.WriteLine("");
        }
    }
}
