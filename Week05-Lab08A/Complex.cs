/*
 * Name: Mohammed Juned Ahmed
 * Student ID: 300833356
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week05_Lab08A{
    class Complex{
        #region Properties
        public int Imaginary{ get; private set; }
        public int Real { get; private set; }
        public double Modulus{get{return Math.Sqrt((Real * Real) + (Imaginary * Imaginary));}}
        public double Argument{get{return Math.Tanh(Real / Imaginary);}}
        #endregion

        #region Constructor
        public Complex(int real = 0, int imaginary = 0){
            Real = real;
            Imaginary = imaginary;
        }
        #endregion
        public override string ToString(){
            return string.Format("{0} & {1}", Real, Imaginary);
        }

        #region Operator
        public static Complex operator +(Complex lhs, Complex rhs){
            int real = lhs.Real + rhs.Real;
            int imaginary = lhs.Imaginary + rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static Complex operator -(Complex lhs, Complex rhs){
            int real = lhs.Real - rhs.Real;
            int imaginary = lhs.Imaginary - rhs.Imaginary;
            return new Complex(real, imaginary);
        }
        public static bool operator ==(Complex lhs, Complex rhs){
            if (lhs.Real == rhs.Real && lhs.Imaginary == rhs.Imaginary){ return true; }
            else{ return false; }
        }
        public static bool operator !=(Complex lhs, Complex rhs){
            if (lhs.Real != rhs.Real && lhs.Imaginary != rhs.Imaginary){ return true; }
            else { return false; }
        }
        #endregion
    }
}
