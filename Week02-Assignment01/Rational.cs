/*
 * Name: Mohammed Juned Ahmed
 * Student ID: 300833356
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02_Assignment01{
    public class Rational{
        private int denominator = 1;
        private int numerator = 0;

        public Rational(int numerator, int denominator){
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public override string ToString(){
            return string.Format("{0}/{1}", this.numerator, this.denominator);
        }

        public void IncreaseBy(Rational other){
            int den = this.denominator * other.denominator;
            int num = (this.denominator * other.numerator) + (this.numerator * other.denominator);
            this.denominator = den;
            this.numerator = num;
        }

        public void DecreaseBy(Rational other){
            int den = this.denominator * other.denominator;
            int num = (this.numerator * other.denominator) - (this.denominator * other.numerator);
            this.denominator = den;
            this.numerator = num;
        }
    }
}
