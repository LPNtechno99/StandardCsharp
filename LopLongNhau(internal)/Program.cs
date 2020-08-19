using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LopLongNhau_internal_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fraction fr = new Fraction(4, 5);
            Console.WriteLine("fr : {0}",fr.ToString());
            Fraction.FractionArtist fa = new Fraction.FractionArtist();
            fa.Draw(fr);
            Console.ReadLine();
        }
    }
    public class Fraction
    {
        private int numerator;
        private int denominator;
        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public override string ToString()
        {
            StringBuilder sbd = new StringBuilder();
            sbd.AppendFormat("{0}/{1}", numerator, denominator);
            return sbd.ToString();
        }
        internal class FractionArtist
        {
            public void Draw(Fraction f)
            {
                Console.WriteLine("Draw the numerator: {0}", f.numerator);
                Console.WriteLine("Draw the denominator: {0}", f.denominator);
            }
        }
    }
}
