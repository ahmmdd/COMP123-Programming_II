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
    class Prescription
    {
        private static int CURRENT_NUMBER = 101;

        public string Doctor { get; private set; }
        public bool ForRepeat { get; private set; }
        public string Id { get; private set; }
        public int Length { get; private set; }
        public string Name { get; private set; }

        public override string ToString(){
            return string.Format(" #{0} {1} perscribed by {2} for {3} ({4})", Id, Name, Doctor, Length, ForRepeat);
        }

        public Prescription(string doctor, string name, int length, bool forRepeat = false)
        {
            Doctor = doctor;
            Name = name;
            Length = length;
            ForRepeat = forRepeat;
            Id = Convert.ToString(CURRENT_NUMBER);
            CURRENT_NUMBER++;
        }
    }
}
