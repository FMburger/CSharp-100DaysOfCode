using Aspose.Words.Saving;
using Aspose.Words;


namespace FileConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataDir = "\\Documents\\C#\\myProject\\100DaysOfCode\\FileConversion\\Files\\";
            // Load the document from disk.
            Document doc = new Document(dataDir + "test.docx");

            // Set HtmlSaveOptions
            HtmlSaveOptions options = new HtmlSaveOptions();
            options.SaveFormat = SaveFormat.Html;

            // Save the document into HTML
            doc.Save(dataDir + "Document.html", options);
        }
    }
}
