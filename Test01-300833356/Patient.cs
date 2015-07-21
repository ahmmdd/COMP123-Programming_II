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

namespace Test01_300833356{
    class Patient{
        #region Feilds
        private static List<Prescription> presc = new List<Prescription>();
        #endregion
        #region Properties
        public string Name { get; private set; }
        public int Yob { get; private set; }
        #endregion
        #region Constructor
        public Patient(string name, int yob){
            Name = name;
            Yob = yob;
        }
        #endregion
        #region Methods
        public void AddPrescription(Prescription prescription){
            presc = new List<Prescription>();
            presc.Add(prescription);
        }
        public void RemovePrescription(string id){
            for (int i = 0; i < presc.Count; i++){
                if (presc[i].Id == id){
                    presc.RemoveAt(i);
                }
            }
        }

        private string GetPrescriptions(){
            string a = "";
            for (int i = 0; i < presc.Count; i++)
            {
                a = a + presc[i] + " ";
            }
            return a;
        }
       
        public override string ToString(){
            return string.Format("{0} yob: {1}", Name, Yob);
        }
        #endregion
    }
}
