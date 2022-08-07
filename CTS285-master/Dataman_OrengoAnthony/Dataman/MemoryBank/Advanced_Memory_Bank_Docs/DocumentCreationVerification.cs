using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanLibrary;
using System.IO;
namespace Dataman.Data_Bank
{
    public class DocumentCreationVerification
    {
        public static void VerifyCreatedDocument(ref string input,ConsoleKeyInfo keyboard, bool loop, ref string dir)
        {
            Console.Clear();
            //Display document creation instructions to user
            Console.WriteLine(StandardMessages.DisplayDocumentInstructions());
           
            Console.ReadLine();
            Console.Clear();
            do
            {
                //Display title to user
                Console.WriteLine(StandardMessages.DisplayDocumentCreationTitle());
                //Get document name from user
                Console.Write("Enter name of file: ");
                input = Console.ReadLine();

                //Verify the document is correctly named start -----------------------------------------------------------
                if (input.Contains(".txt"))
                {
                    Console.WriteLine("Invalid document name! You can not use .txt in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (input.Contains("<"))
                {
                    Console.WriteLine("Invalid document name! You can not use < in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (input.Contains(">"))
                {
                    Console.WriteLine("Invalid document name! You can not use > in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (input.Contains(":"))
                {
                    Console.WriteLine("Invalid document name! You can not use : in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (input.Contains(@""""))
                {
                    Console.WriteLine(@"Invalid document name! You can not use "" in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (input.Contains("/"))
                {
                    Console.WriteLine("Invalid document name! You can not use / in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (input.Contains(@"\"))
                {
                    Console.WriteLine(@"Invalid document name! You can not use \ in your file name!" +
                        "\n\nPress Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (input.Contains("|"))
                {
                    Console.WriteLine("Invalid document name! You can not use | in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (input.Contains("?"))
                {
                    Console.WriteLine("Invalid document name! You can not use ? in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (input.Contains("*"))
                {
                    Console.WriteLine("Invalid document name! You can not use * in your file name!\n\n" +
                        "Press Enter and Try Again!");
                    Console.ReadLine();
                    Console.Clear();
                }
                //Verify the document is correctly named end==================================================

                //Creates document if the name passes verification
                else
                {
                    try
                    {

                        using (StreamWriter outputFile = File.AppendText($@"{dir}\{input}.csv"))
                            
                        {
                            outputFile.Close();
                        }                  

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    Console.WriteLine("\n***File Created");
                    Console.Write("\nYour file is located in: " + $@"{dir}\DistanceDocuments\{input}.csv" +
                        "\n\nPress Enter to Continue...");
                    Console.ReadLine();
                    loop = true;
                }

            } while (loop == false);


        }

    }
}
