using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanLibrary;
using System.IO;
namespace Dataman.Data_Bank
{
    public class VerifyAdminPassword
    {
        public static void PasswordVerification(ref Administrator admin, ref string dir, ref bool loop, ref int count)
        {
            Console.Clear();

            string input = "";
            string file = dir + @"\AdminPassword.txt";

            using (StreamReader read = File.OpenText(file))
            {
                file = read.ReadToEnd();
                admin.Password = file;
            }

            // Console.WriteLine(admin.Password);
            if (count > 3 || admin.AdminLock == true)
            {
                admin.AdminLock = true;
                loop = true;
                Console.WriteLine("You are locked out from Admin mode!\nRestart the device or Press Enter!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This program is currently in testing mode..\nThe Admin password is 12345.\n" +
                    @"The Admin password document is also located in the text file (Drive Location):\Dataman_OrengoAnthony\Dataman\bin\Debug\AdminPassword.txt");
                Console.Write("Enter Admin Password --> ");
                Console.ForegroundColor = ConsoleColor.Red;
                input = Console.ReadLine();
                if (input == admin.Password)
                {
                    Console.Clear();
                    loop = false;
                }
                else if (input != admin.Password)
                {     
                    loop = true;
                    count++;
                    Console.WriteLine("Invalid Admin Code!");                    
                }
                Console.ForegroundColor = ConsoleColor.White;
            }            
        }

        
    }
}
