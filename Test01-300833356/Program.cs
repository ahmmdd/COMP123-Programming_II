/*
 * Name: Mohammed Juned Ahmed
 * Student ID: 300833356
 * Course: COMP123
 * Test01
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test01_300833356
{
    class Program
    {
        static void Main(string[] args)
        {
            //test the prescription class
            Console.WriteLine("\n*****Testing the Prescription Class");
            Console.WriteLine(new Prescription("Nika", "Asprin", 21));
            Console.WriteLine(new Prescription("Khan", "Amoxicillin", 14, true));

            //test the patient class
            Console.WriteLine("\n*****Testing the Patient Class");
            Console.WriteLine(new Patient("Manraj Gill", 1989));

            //testing AddPrescription method of the patient class
            Patient pat0 = new Patient("Qi An", 1990);
            Console.WriteLine("\n*****Testing the AddPrescription() method");
            pat0.AddPrescription(new Prescription("Pershad", "Coumadin", 21));
            pat0.AddPrescription(new Prescription("Pershad", "Metformin", 7, true));
            pat0.AddPrescription(new Prescription("Nika", "Ventolin", 28, true));
            pat0.AddPrescription(new Prescription("Nika", "Cipralex", 14, true));
            Console.WriteLine(pat0);
            Patient pat1 = new Patient("Andre Levy", 1993);
            Console.WriteLine("\n*****Testing the AddPrescription() method");
            pat1.AddPrescription(new Prescription("Khan", "Tylenol", 7, true));
            pat1.AddPrescription(new Prescription("Khan", "Synthroid", 21));
            pat1.AddPrescription(new Prescription("Filotti", "Ramipril", 56, true));
            pat1.AddPrescription(new Prescription("Pershad", "Pravastatin", 42, true));
            pat1.AddPrescription(new Prescription("Filotti", "Metformin", 7, true));
            pat1.AddPrescription(new Prescription("Khan", "Coumadin", 21));
            Console.WriteLine(pat1);

            //testing the RemovePrescription method of the patient class
            Console.WriteLine("\n*****Testing the RemovePrescription() method");
            pat1.RemovePrescription("108");
            pat1.RemovePrescription("109");
            pat1.RemovePrescription("108");
            Console.WriteLine(pat1);

        }
    }
}

