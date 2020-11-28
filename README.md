# 挑戰連續 100 天 C# 編程

### Day1. 管理資料夾和檔案
##### 第一天, 今天參考 Tim Corey 的影片 [Working With The File System in C# - Managing Folders and Files](https://www.youtube.com/watch?v=9mUuJIKq40M), 學習如何對檔案進行存取。主要使用到 System.IO 的 Directory 類別。

### Day2. 上傳檔案並將檔案存至 SQL Server

##### 今天參考的是這篇 [How to Upload Files and Save in Database in ASP.NET Core MVC](https://tutexchange.com/how-to-upload-files-and-save-in-database-in-asp-net-core-mvc/), 文章寫得非常詳細, 只要按照他的步驟就能夠成功將檔案存入資料庫中。


### Day3. Signature pad (1)

##### 參考網路文章建立簽名板, 因為程式中有些地方還需要進行除錯。

##### Reference: [Register Account with Digital Signature in ASP.NET Core MVC](https://www.youtube.com/watch?v=NUrpve7hXuM)


### Day4. Elementary Arithmetic

##### 簡易四則運算


### Day5. DBConnection

##### SQL Server 連線測試程式。

##### Reference: 
1. [Beginners guide to accessing SQL Server through C#](https://www.codeproject.com/Articles/4416/Beginners-guide-to-accessing-SQL-Server-through-C))
2. [How to check MySQL connection state in C#](https://stackoverflow.com/questions/20785220/how-to-check-mysql-connection-state-in-c-sharp/20785451)


### Day6. Multiplication table
參考網路資料後加入了標題以及輸入功能

##### Reference: [Multiplication tables](https://rosettacode.org/wiki/Multiplication_tables)

### Day7. Digital Clock
##### Step by Step
* Download DS-Digital font
* Create Windows Form app
* Change background
* Add Labels
* Add button
* Change font
* Coding
##### Code
    private void timer1_Tick(object sender, EventArgs e)
    {
        <!-- Formatting times -->
        label1.Text = DateTime.Now.ToString("dddd");
        label2.Text = DateTime.Now.ToString("HH:mm");
        label5.Text = DateTime.Now.ToString("tt");
        label4.Text = DateTime.Now.ToString("yyyy");
        label3.Text = DateTime.Now.ToString("ss");
        label6.Text = DateTime.Now.ToString("MMM:dd");

    }
    private void Form1_Load(object sender, EventArgs e)
    {
        <!-- start a timer -->
        timer1.Start();
    }
    private void button1_Click(object sender, EventArgs e)
    {
        <!-- Exit the application -->
        Application.Exit();
    }

##### Referencee: [Make Digital Clock using C# Visual studio basics](https://www.youtube.com/watch?v=OFQxQndIFrQ)

### Day8. Windows Form CRUD Operations (1)
今日參考 Youtube 上的教學影片建立 Windows Form App, 主要功能是對於 SQL Server 的資料進行 CRUD Operations, 未完的部分明天繼續


##### .Net Core Template:
*Windows Form App*

##### Step by Step

##### Features

##### Code

##### References:  
1. [C# and SQL Server Perform SMART CRUD Operations with SEARCH (Edited Version Part 1/2)](https://www.youtube.com/watch?v=mw4TmD2AMtA)
2. [C# and SQL Server Perform SMART CRUD Operations with SEARCH (Edited Version Part 2/2)](https://www.youtube.com/watch?v=iqT0e09JCXQ)

### Day9. Windows Form CRUD Operations (2)
延續昨天未完的部分

### Day10. [LeetCode-191] Number of 1 Bits

##### Step by Step
1. Convert uint to string
2. Convert string to char array
3. Foreach char array and count the number of 1s

##### Code:
     public int HammingWeight(uint n) {
        string s = Convert.ToString(n, 2); // Convert uint ot string
        char[] ch = s.ToCharArray();       // Convert string to char array
        int num = 0;              
        foreach (char c in ch)             // Foreach char array and count the number of 1s
        {
            if(c == '1')
            {
                num = num + 1;
            }
        }
        return num;
    }