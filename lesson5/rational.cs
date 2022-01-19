using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson5
{
    internal class rational
    {
        public int _numerator;
        public int _denominator;

        public int Numerator
        {
            private get { return _numerator; }
            set { _numerator = value; }
        }
        public int Denominator
        {
            private get { return _denominator; }
            set { _denominator = value; }
        }

        public rational(int numerator, int denominator)
        {
            if (Equals(numerator, denominator) == true)
            {
                Console.WriteLine("1");
            }
            else if (Equals(numerator, denominator) != true)
            {
                _numerator = numerator;
                _denominator = denominator;
                Console.WriteLine(Numerator + "/" + Denominator);
            }
        }
    }
}