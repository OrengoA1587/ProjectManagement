using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatamanLibrary;
using System.IO;
namespace Dataman.Data_Bank
{
    public class DataBankDocument
    {

        public static void DataBankMenu()//Main databank menu
        {
            
            Console.Clear();
            ConsoleKeyInfo keyboard = new ConsoleKeyInfo(); //Create keyboard class
            //Set sentinel for loop
            bool dataBankMenuLoop = false, childMenuLoop = false, adminMenuLoop = false;           
            int count = 0;

            #region Main DataBank Menu
            do
            {
                Console.WriteLine(StandardMessages.DisplayDataBankMainMenu());//Display databank menu
                keyboard = Console.ReadKey();
                switch (keyboard.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        //Verify admin with password
                        adminMenuLoop = false;//reset admin loop 
                        //VerifyAdminPassword.PasswordVerification(ref  admin,ref adminMenuLoop, ref count);
                        if(adminMenuLoop == true)
                        {
                            Console.WriteLine("Press Enter.....");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            #region Data Bank Admin Menu
                            do
                            {

                                Console.WriteLine(StandardMessages.DisplayAdminDataBankMainMenu());//Display databank menu
                                keyboard = Console.ReadKey();//Get input from user 
                                switch (keyboard.Key)//Controls the flow of the menu
                                {
                                    case ConsoleKey.D1:
                                    case ConsoleKey.NumPad1:
                                        ChooseDataSetToWrite(dataBankMenuLoop, keyboard);//Choose dataset to write to 
                                        break;
                                    case ConsoleKey.Escape:
                                        adminMenuLoop = true;//Ends loop and returns to main menu
                                        break;

                                    default:
                                        Console.WriteLine(StandardMessages.DisplayInvalidOption());//Displays invalid option
                                        Console.Clear();
                                        break;
                                }
                            } while (adminMenuLoop == false);
                            #endregion
                        }
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        #region Data Bank Child Menu
                        do
                        {                           
                            Console.WriteLine(StandardMessages.DisplayChildDataBankMainMenu());//Display databank menu
                            keyboard = Console.ReadKey();//Get input from user 
                            switch (keyboard.Key)//Controls the flow of the menu
                            {
                                case ConsoleKey.D1:
                                case ConsoleKey.NumPad1:
                                    ChooseDataSetToRead(dataBankMenuLoop, keyboard);//Choose dataset to write to 
                                    break;
                                case ConsoleKey.Escape:
                                    childMenuLoop = true;//Ends loop and returns to main menu
                                    break;

                                default:
                                    Console.WriteLine(StandardMessages.DisplayInvalidOption());//Displays invalid option
                                    Console.Clear();
                                    break;
                            }
                        } while (childMenuLoop == false);
                        #endregion
                        break;
                    case ConsoleKey.Escape:
                        break;
                    default:
                        Console.WriteLine(StandardMessages.DisplayInvalidOption());
                        Console.ReadLine();
                        break;
                }
            } while (dataBankMenuLoop == false);
            #endregion

        }//End of DataBankMenu----------------------------------------------------------------------------------------

        public static void ChooseDataSetToWrite(bool dataBankMenuLoop, ConsoleKeyInfo keyboard)
        {
            Console.Clear();//Clears current screen
            #region Variables,Classes, and Objects
            //Declare Variables,Classes, and Objects
            string input = "";
            string file = "";
            
            int amount = 0;            
            bool problemLoop = false;            
            
            //Get directory path for files
            string directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            #endregion

            #region Choose Dataset
            //Get input from user            
            do
            {
                Console.WriteLine(StandardMessages.DisplayCreateDataSetMenu());
                keyboard = Console.ReadKey();
                //Control flow of the Data Bank menu
                switch (keyboard.Key)
                {
                    //Create/Add to dataset files
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        file = directory + $@"\DataSetOne.csv";
                        Console.Clear();//Clears current screen
                        WriteToDocument.WriteToDataSetOneDoc(ref file,input,keyboard,problemLoop);
                        dataBankMenuLoop = true;

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        file = directory + $@"\DataSetTwo.csv";
                        Console.Clear();//Clears current screen
                        WriteToDocument.WriteToDataSetTwoDoc(ref file, input, keyboard, problemLoop);
                        dataBankMenuLoop = true;
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        file = directory + $@"\DataSetThree.csv";
                        Console.Clear();//Clears current screen
                        WriteToDocument.WriteToDataSetThreeDoc(ref file, input, keyboard, problemLoop);
                        dataBankMenuLoop = true;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        file = directory + $@"\DataSetFour.csv";
                        Console.Clear();//Clears current screen
                        WriteToDocument.WriteToDataSetFourDoc(ref file, input, keyboard, problemLoop);
                        dataBankMenuLoop = true;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        file = directory + $@"\DataSetFive.csv";
                        Console.Clear();//Clears current screen
                        WriteToDocument.WriteToDataSetFiveDoc(ref file, input, keyboard, problemLoop);
                        dataBankMenuLoop = true;
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        DocumentCreationVerification.VerifyCreatedDocument(ref input,keyboard,problemLoop,ref directory);
                        file = directory + $@"\{input}.csv";
                        Console.Clear();//Clears current screen
                        WriteToDocument.CreateDataSet(ref file, input, keyboard, problemLoop);
                        Console.Clear();//Clears current screen
                        
                        dataBankMenuLoop = true;
                        break;
                    //Exits menu
                    case ConsoleKey.Escape:
                        dataBankMenuLoop = true;
                        break;
                    default:
                        Console.WriteLine(StandardMessages.DisplayInvalidOption());
                        break;
                }
            } while (dataBankMenuLoop == false);
            Console.Clear();
                #endregion
                          
        }
        public static void ChooseDataSetToRead(bool dataBankMenuLoop, ConsoleKeyInfo keyboard)
        {
            Console.Clear();//Clears current screen
            #region Variables,Classes, and Objects
            //Declare Variables,Classes, and Objects
            string input = "";
            string dataSetName = "";
            string file = "";
            int setNum = 0;
            int amount = 0;
            bool problemLoop = false;

            //Get directory path for files
            string directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            #endregion

            #region Choose Dataset
            //Get input from user            
            do
            {
                Console.WriteLine(StandardMessages.DisplaySelectDataSetMenu());
                keyboard = Console.ReadKey();
                //Control flow of the Data Bank menu
                switch (keyboard.Key)
                {
                    //Create/Add to dataset files
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        file = directory + $@"\DataSetOne.csv";
                        setNum = 1;
                        ReadFromDocument.StartDataBankTest(ref file, input, keyboard, problemLoop, ref setNum, ref dataSetName);
                        dataBankMenuLoop = true;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        setNum = 2;
                        file = directory + $@"\DataSetTwo.csv";
                        ReadFromDocument.StartDataBankTest(ref file, input, keyboard, problemLoop, ref setNum, ref dataSetName);
                        dataBankMenuLoop = true;
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        setNum = 3;
                        file = directory + $@"\DataSetThree.csv";
                        ReadFromDocument.StartDataBankTest(ref file, input, keyboard, problemLoop, ref setNum, ref dataSetName);
                        dataBankMenuLoop = true;
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        setNum = 4;
                        file = directory + $@"\DataSetFour.csv";
                        ReadFromDocument.StartDataBankTest(ref file, input, keyboard, problemLoop, ref setNum, ref dataSetName);
                        dataBankMenuLoop = true;
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        setNum = 5;
                        file = directory + $@"\DataSetFive.csv";
                        ReadFromDocument.StartDataBankTest(ref file, input, keyboard, problemLoop, ref setNum, ref dataSetName);
                        dataBankMenuLoop = true;
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        //Input File Name
                        VerifyDocumentExistence.VerifyDocument(ref file, input, keyboard, problemLoop, ref directory);
                        //Read document
                        setNum = 00;
                        dataSetName = "Custom";
                        ReadFromDocument.StartDataBankTest(ref file, input, keyboard, problemLoop, ref setNum, ref dataSetName);
                        dataBankMenuLoop = true;
                        break;
                    //Exits menu
                    case ConsoleKey.Escape:
                        dataBankMenuLoop = true;
                        break;
                    default:
                        Console.WriteLine(StandardMessages.DisplayInvalidOption());
                        break;
                }
            } while (dataBankMenuLoop == false);
            Console.Clear();
            #endregion

        }
    }
}
