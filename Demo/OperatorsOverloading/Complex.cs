using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.OperatorsOverloading
{
    internal class Complex
    {
        // 10 + 6i
        public int Real { get; set; }
        public int Imag { get; set; }

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        #region Operator Overloaidng - Binary Operators
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex()
            {
                Real = (c1?.Real ?? 0) + (c2?.Real ?? 0),
                Imag = (c1?.Imag ?? 0) + (c2?.Imag ?? 0)
            };
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex()
            {
                Real = (c1?.Real ?? 0) - (c2?.Real ?? 0),
                Imag = (c1?.Imag ?? 0) - (c2?.Imag ?? 0)
            };
        }
        #endregion

        #region Operator Overloading - Unary Operator

        public static Complex operator ++ (Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) + 1,
                Imag = C?.Imag ?? 0
            };
        }

        public static Complex operator --(Complex C)
        {
            return new Complex()
            {
                Real = (C?.Real ?? 0) - 1,
                Imag = C?.Imag ?? 0
            };
        }

        #endregion
    }
}
