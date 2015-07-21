using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Week09_Serializing
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean done = false;
            ConsoleKeyInfo choice;
            string fileName = "customer.dat";
            Customer customer;
            int custId;
            string custName;

            BinaryFormatter bFormatter = new BinaryFormatter();
            FileStream custFile;

            do
            {
                Console.Clear();
                Console.WriteLine("1-Save Customer Data");
                Console.WriteLine("2-Read Customer Data");
                Console.WriteLine("\n0-Quit");
                Console.Write("\nYour choice >");
                choice = Console.ReadKey();
                try
                {
                    switch (choice.Key)
                    {
                        case ConsoleKey.D1:
                            if (File.Exists(fileName))
                            {
                                custFile = new FileStream(fileName,
                                    FileMode.Append, FileAccess.Write);
                            }
                            else
                            {
                                custFile = new FileStream(fileName,
                                    FileMode.Create, FileAccess.Write);
                            }
                            Console.Write("\nCustomer ID:");
                            custId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("\nCustomer Name:");
                            custName = Console.ReadLine();
                            customer = new Customer(custId, custName);

                            // serialize
                            bFormatter.Serialize(custFile, customer);
                            Console.WriteLine("Customer Saved. Press Enter:");
                            Console.ReadLine();
                            custFile.Close();

                            break;
                        case ConsoleKey.D2:
                            custFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                            while (custFile.Position < custFile.Length)
                            {
                                customer = (Customer)bFormatter.Deserialize(custFile);
                                Console.WriteLine(customer.ToString());
                            }
                            Console.Write("\nData Reading Completed. Press Enter:");
                            Console.ReadLine();
                            break;
                        case ConsoleKey.D0:
                            done = true;
                            break;
                        default:
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error:" + e.Message + ". Press Enter:");
                    Console.ReadLine();
                }

            } while (!done);




        }
    }
}
