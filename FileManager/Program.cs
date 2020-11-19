using System;
using System.IO;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath;
            Console.WriteLine("請輸入你的檔案路徑: "); 
            rootPath = Console.ReadLine();
            
            // 目錄中的所有資料夾
            // string[] dirs = Directory.GetDirectories(rootPath);
 
            // 目錄中的所有資料夾及子資料夾
            // string[] dirs = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories); 
            // foreach(string dir in dirs)
            // {
            //     Console.WriteLine(dir);
            // }

            // 目錄中的所有檔案
            // var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            // foreach(string file in files)
            // {
            //     //檔案完整路徑
            //     // Console.WriteLine(file);

            //     //只有檔案名稱
            //     Console.WriteLine(Path.GetFileName(file));

            //     //不包含附檔名
            //     Console.WriteLine(Path.GetFileNameWithoutExtension(file));

            //     //只有檔案路徑
            //     Console.WriteLine(Path.GetDirectoryName(file));

            //     //檔案大小
            //     var info = new FileInfo(file);
            //     Console.WriteLine($"{ Path.GetFileName(file)}:{ info.Length } bytes");
            // }

            // 判斷目錄是否存在
            bool directoryExists = Directory.Exists(@"D:\Temp");
            if (directoryExists)
            {
                Console.WriteLine("The directory exists");
            }else
            {
                Console.WriteLine("The directory does not exist");
            }

            // 建立新的資料夾
            string newPath = @"D:\Temp\newfolder";
            Directory.CreateDirectory(newPath);

            Console.ReadLine();

        }
    }
}
