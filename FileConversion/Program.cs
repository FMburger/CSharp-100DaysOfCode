using System;
using Aspose.Words.Saving;
using Aspose.Words;



namespace FileConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<File Conversion>");
            Console.Write("Please input your file directory: ");
            string dataDir = Console.ReadLine();

            Console.Write("Please input your file name: ");
            string fileName = Console.ReadLine();

            // Load the document from disk.
            Document doc = new Document(dataDir + fileName);
            Console.WriteLine(doc);

            // Set HtmlSaveOptions
            HtmlSaveOptions options = new HtmlSaveOptions();
            options.SaveFormat = SaveFormat.Html;

            // Save the document into HTML
            doc.Save(dataDir + "Output.html", options);
        }
    }
}
