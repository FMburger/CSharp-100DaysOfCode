using System;
using System.IO;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath;
            Console.WriteLine("<歡迎使用>");
        start:
            Console.WriteLine("(1) 判斷目錄是否存在");
            Console.WriteLine("(2) 查詢目錄路中的所有資料夾");
            Console.WriteLine("(3) 查詢目錄中的所有資料夾及子資料夾");
            Console.WriteLine("(4) 判斷目錄是否存在");
            Console.Write("請選擇你想要使用的功能: ");
            int caseSwitch = Int32.Parse(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    Console.Write("請輸入你的檔案路徑: ");
                    rootPath = Console.ReadLine();

                    // 判斷目錄是否存在
                    bool directoryExists = Directory.Exists(rootPath);
                    if (directoryExists)
                    {
                        Console.WriteLine("The directory exists");
                    }
                    else
                    {
                        Console.WriteLine("The directory does not exist");
                    }

                    // 建立新的資料夾
                    string newPath = @"D:\Temp\newfolder";
                    Directory.CreateDirectory(newPath);
                    break;
                case 2:
                    Console.Write("請輸入你的檔案路徑: ");
                    rootPath = Console.ReadLine();

                    // 目錄中的所有資料夾
                    string[] dirs = Directory.GetDirectories(rootPath);
                    Console.WriteLine(dirs);
                    foreach (string dir in dirs)
                    {
                        Console.WriteLine(dir);
                    }

                    break;
                case 3:
                    Console.Write("請輸入你的檔案路徑: ");
                    rootPath = Console.ReadLine();

                    //目錄中的所有資料夾及子資料夾
                    string[] dirs2 = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
                    foreach (string dir in dirs2)
                    {
                        Console.WriteLine(dir);
                    }
                    break;
                case 4:
                    Console.Write("請輸入你的檔案路徑: ");
                    rootPath = Console.ReadLine();

                    // 目錄中的所有檔案
                    var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
                    foreach (string file in files)
                    {
                        //檔案完整路徑
                        Console.WriteLine(file);

                        //只有檔案名稱
                        Console.WriteLine(Path.GetFileName(file));

                        //不包含附檔名
                        Console.WriteLine(Path.GetFileNameWithoutExtension(file));

                        //只有檔案路徑
                        Console.WriteLine(Path.GetDirectoryName(file));

                        //檔案大小
                        var info = new FileInfo(file);
                        Console.WriteLine($"{ Path.GetFileName(file)}:{ info.Length } bytes");
                    }
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            Console.Write("是否要結束程式(Y or N): ");
            String exit = Console.ReadLine();
            if (exit != "Y")
            {
                goto start;
            }

            Console.ReadLine();

        }
    }
}
