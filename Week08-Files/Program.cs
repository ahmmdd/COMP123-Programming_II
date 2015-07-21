using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week08_Files
{
    class Program
    {
        static void Main(string[] args)
        {   
            Boolean done = false;
            ConsoleKeyInfo choice;
            string path;
            string directoryName;
            string[] listOfFiles;
            string[] listOfFolders;
            string fileName;

            
            do
            {
                try
                {
                    path = Directory.GetCurrentDirectory();
                    Console.Clear();
                    Console.WriteLine("Current Path: " + path);
                    Console.WriteLine("********************************");
                    Console.WriteLine("* 1-Create Directory           *");
                    Console.WriteLine("* 2-Delete Directory           *");
                    Console.WriteLine("* 3-Create File                *");
                    Console.WriteLine("* 4-Delete File                *");
                    Console.WriteLine("* 5-List Directory             *");
                    Console.WriteLine("* 6-Set Current Directory      *");
                    Console.WriteLine("*                              *");
                    Console.WriteLine("* 0-Quit                       *");
                    Console.WriteLine("********************************");
                    Console.Write("\nYour Choice >");
                    choice = Console.ReadKey();

                    switch (choice.Key)
                    {
                        case ConsoleKey.D1:
                            Console.Write("\nEnter a folder name:");
                            directoryName = Console.ReadLine();
                            Directory.CreateDirectory(directoryName);
                            Console.Write("\nFolder "+directoryName+" created. Press Enter:");
                            Console.ReadLine();
                            break;
                        case ConsoleKey.D2:
                            break;
                        case ConsoleKey.D3:
                            Console.Write("\nEnter a File Name:");
                            fileName = Console.ReadLine();
                            if (File.Exists(fileName))
                            {
                                Console.WriteLine("File " + fileName + " was created " +
                                    File.GetCreationTime(fileName)+". Press Enter:");
                            }
                            else
                            {
                                File.Create(fileName);
                                Console.WriteLine("File created. Press Enter:");
                            }
                            Console.ReadLine();

                            break;
                        case ConsoleKey.D4:
                            break;
                        case ConsoleKey.D5:
                            Console.WriteLine("\nEnter a folder or hit Enter for the current folder:");
                            directoryName = Console.ReadLine();
                            if(directoryName == "") directoryName = path;

                            if(Directory.Exists(directoryName)) {
                                listOfFiles = Directory.GetFiles(directoryName);
                                listOfFolders = Directory.GetDirectories(directoryName);
                                for(int i=0; i<listOfFolders.Length; i++)
                                    Console.WriteLine(listOfFolders[i]);
                                for(int i=0; i<listOfFiles.Length; i++)
                                    Console.WriteLine(listOfFiles[i]);
                                Console.WriteLine("\nListing Complete. Press Enter");
                                Console.ReadLine();

                            } else
                            {
                                Console.WriteLine("\nDirectody does not exist. Press Enter:");
                                Console.ReadLine();
                            }

                            break;
                        case ConsoleKey.D6:
                            Console.Write("\nEnter a folder path:");
                            directoryName = Console.ReadLine();
                            Directory.SetCurrentDirectory(directoryName);
                            Console.Write("\nCurrent folder changed. Press Enter");
                            Console.ReadLine();
                            break;
                        case ConsoleKey.D0:
                            done = true;
                            Console.WriteLine("\nGood Bye!");
                            break;
                        default:
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Push Enter:");
                    Console.ReadLine();
                }

            } while (!done);
        }
    }
}
