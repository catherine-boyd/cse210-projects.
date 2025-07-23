using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    internal class Fraction
    {
        private double _top = 0;
        private double _bottom = 0;

        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        public Fraction(double top )
        {
            _bottom = 1;
            _top = top;
        }

        public Fraction(double top, double bottom)
        {
            _top = top;
            _bottom = bottom;

        }

        public double GetTop()
        { 
            return _top;
        }
        public double GetBottom()
        {
            return _bottom;
        }

        public void SetTop(double top)
        {
            _top = top;
        }

        public void SetBottom(double bottom)
        {
            _bottom = bottom ;
        }

         public string GetFractionstring()
        {
            string numerator = _top.ToString();
            string denominator = _bottom.ToString();
            return numerator + "/" + denominator;
        }

        public double GetDecimalValue()
        {
            return _top / _bottom;
        }
    }
}
