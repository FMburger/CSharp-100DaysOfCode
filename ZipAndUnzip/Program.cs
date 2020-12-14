using System;
using System.IO.Compression;

namespace ZipAndUnzip
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("< Zip and Unzip >");
            Console.Write("Please input your file directory: ");
            string filePath = Console.ReadLine();
            string zipFile = filePath + "test.zip";
            string fileExt = filePath + "test";

            Console.WriteLine("Zip or Unzip?");
            Console.WriteLine("1> Zip");
            Console.WriteLine("2> UnZip");
            string switchCase = Console.ReadLine();

            switch (switchCase)
            {
                case "1":
                    ZipFile.CreateFromDirectory(filePath, zipFile);
                    break;
                case "2":
                    ZipFile.ExtractToDirectory(zipFile, fileExt);
                    break;
                default:
                    break;
            }


            Console.WriteLine("Done!!");

            Console.ReadLine();

        }
    }
}
