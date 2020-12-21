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
            Console.WriteLine("1> DOCX to HTML");
            Console.WriteLine("2> EPUB to PDF");
            Console.Write("Please select a function: ");
            string fn = Console.ReadLine();
            Console.Write("Please input your file name: ");
            string fileName = Console.ReadLine();


            switch (fn)
            {
                case "1":
                    // Load the document from disk.
                    Document doc = new Document(dataDir + fileName);
                    Console.WriteLine(doc);

                    // Set HtmlSaveOptions
                    HtmlSaveOptions options = new HtmlSaveOptions();
                    options.SaveFormat = SaveFormat.Html;

                    // Save the document into HTML
                    doc.Save(dataDir + "Output.html", options);
                    break;
                case "2":
                    // Load the document from disk.
                    var epub = System.IO.File.OpenRead(dataDir + fileName);
                    Aspose.Html.Saving.PdfSaveOptions pdfOption = new Aspose.Html.Saving.PdfSaveOptions();
                    Aspose.Html.Converters.Converter.ConvertEPUB(epub, pdfOption, dataDir + "EPUBtoPDF.pdf");
                    break;
                default:
                    break;
            }
            
        }
    }
}
