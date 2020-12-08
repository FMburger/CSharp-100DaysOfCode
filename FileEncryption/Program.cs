using System;
using Aspose.Pdf;
using System.IO;

namespace FileEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("<PDF Encryption>");
            Console.WriteLine("1. Emcrypt PDF");
            Console.WriteLine("2. Decrypt PDF");
            Console.Write("Encrypt PDF or Decrypt PDF: ");
            string caseSwitch = Console.ReadLine();

            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;

            switch (caseSwitch)
            {
                case "2":
                    Console.Write("Please input your password: ");
                    string userPassword2 = Console.ReadLine();
                    Document document2 = new Document(projectDirectory + "/Files/EncryptedPDF.pdf", userPassword2);
                    document2.Decrypt();
                    document2.Save("DecryptedPDF.pdf");
                    break;
                default:
                    Console.Write("Please input your password: ");
                    string userPassword = Console.ReadLine();
                    Document document = new Document(projectDirectory + "/Files/test.pdf");
                    document.Encrypt(userPassword, "ownerPassword", 0, CryptoAlgorithm.RC4x128);
                    document.Save(projectDirectory + "/Files/EncryptedPDF.pdf");
                    break;
            }
        }
    }
}
