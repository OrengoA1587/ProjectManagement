using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DatamanLibrary;
namespace Dataman.Data_Bank
{
    public class VerifyDocumentExistence
    {
        public static void VerifyDocument(ref string file, string input, ConsoleKeyInfo keyboard, bool problemLoop, ref string directory)
        {
            Console.Clear();

            Console.Write("Input file name --> ");
            input = Console.ReadLine();
            file = directory + $@"\{input}.csv";
            if (File.Exists(file))
            {
                Console.WriteLine($"File: {file} has successfully been uploaded\n\nPress Enter...");
                Console.ReadLine();
                
            }
            else
            {
                Console.WriteLine("File does not Exist! Default Document will be used!");
                file = directory + $@"\Default.csv";
                Console.ReadLine();
            }
        }
    }
}
