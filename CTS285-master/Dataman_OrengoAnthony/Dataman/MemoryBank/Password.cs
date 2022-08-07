using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormUI;
using System.IO;
using DatamanLibrary;

namespace Dataman.MemoryBank
{
    public class  Password
    {
        public static void ChangeAdminPassword(ref Administrator admin, ref string dir,string input)
        {
            Console.Clear();
            Console.Write("Enter new Admin Password --> ");
            input = Console.ReadLine();
            string file = dir + @"/AdminPassword.txt";
            using (StreamWriter output = File.CreateText(file))
            {
                output.Write(input);
            }

        }
    }
}
