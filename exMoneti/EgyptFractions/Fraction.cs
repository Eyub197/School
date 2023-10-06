using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptFractions
{
    class Fraction
    {
        private int numerator;
        private int denominator;

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }

        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        private int gcd(int a, int b)
        {
            if (a == 0) return b;
            return gcd(b % a, a);
        }

        private void Simplify()
        {
            var gcd = this.gcd(this.Numerator, this.Denominator);
            this.Numerator /= gcd;
            this.Denominator /= gcd;
        }

        public static Fraction operator + (Fraction left, Fraction right)
        {
            var temp = new Fraction(left.numerator * right.denominator + left.denominator * right.numerator,
            left.denominator * right.denominator);
            temp.Simplify();

            return temp;
        }

        public static bool operator <(Fraction left, Fraction right)
        {
            var leftExp = new Fraction(left.numerator * right.denominator, left.denominator * right.denominator);
            var rightExp = new Fraction(right.numerator * left.denominator, right.denominator * left.denominator);
            if (leftExp.Numerator <= rightExp.Numerator) return true;
            return false ; 
        }

        public static bool operator > (Fraction left, Fraction right)
        {
            var leftExp = new Fraction(left.numerator * right.denominator, left.denominator * right.denominator);
            var rightExp = new Fraction(right.numerator * left.denominator, right.denominator * left.denominator);
            if (leftExp.Numerator >= rightExp.Numerator) return true;
            return false;
        }

        public override string ToString()
        {
            return string.Format("[{0}/{1}]", this.Numerator, this.denominator);
        }
    }
}
