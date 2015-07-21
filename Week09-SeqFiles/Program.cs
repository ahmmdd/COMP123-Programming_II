using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week09_SeqFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "customers.txt";
            Customer customer;
            int custId;
            string custName;
            double custSales;

            FileStream custFile, inFile;
            StreamWriter writer;
            StreamReader reader;
            string nextRecord;

            Boolean done = false;
            ConsoleKeyInfo choice;
            string[] fields;

            if (File.Exists(fileName))
            {
                // open the stream
                custFile = new FileStream(fileName, FileMode.Append,
                    FileAccess.Write);
            }
            else
            {
                custFile = new FileStream(fileName, FileMode.Create,
                    FileAccess.Write);
            }
            writer = new StreamWriter(custFile);

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("1-Save Customer Data");
                    Console.WriteLine("2-Read Customer Data");
                    Console.WriteLine("\n0-Exit");

                    Console.Write("\nYour Choice >");
                    choice = Console.ReadKey();

                    switch (choice.Key)
                    {
                        case ConsoleKey.D1:
                            Console.Write("\nCustomer ID:");
                            custId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Customer Name:");
                            custName = Console.ReadLine();
                            Console.Write("Customer Sales: ");
                            custSales = Convert.ToDouble(Console.ReadLine());
                            customer = new Customer(custId, custName, custSales);

                            // write the customer data
                            writer.WriteLine(customer.ToString());

                            Console.Write("\n Customer data saved. Press Enter:");
                            Console.ReadLine();
                            break;
                        case ConsoleKey.D2:
                            writer.Close();
                            custFile.Close();
                            inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                            reader = new StreamReader(inFile);
                            Console.WriteLine("Reading customer data...\n");
                            nextRecord = reader.ReadLine();
                            while (nextRecord != null)
                            {
                                fields = nextRecord.Split(',');
                                custId = Convert.ToInt32(fields[0]);
                                custName = fields[1];
                                custSales = Convert.ToDouble(fields[2]);
                                // reconstruct the object
                                customer = new Customer(custId, custName, custSales);
                                Console.WriteLine(customer.ToString());
                                // object rebuilt, do other processing 
                                nextRecord = reader.ReadLine();
                            }
                            Console.Write("\nDisplay completed. Press Enter:");
                            Console.ReadLine();
                            reader.Close();
                            custFile.Close();
                            break;
                        case ConsoleKey.D0:
                            writer.Close();
                            custFile.Close();
                            done = true;
                            break;
                        default:
                            break;
                    }





                }
                catch (Exception e)
                {
                    Console.Write("\nError: " + e.Message + ". Press Enter:");
                    Console.ReadLine();
                }
            } while (!done);


        }
    }
}
