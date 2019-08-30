using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equação2grau
{
    class EqIIgrau
    {
        private double a, b, c;
        public void SetABC(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void GetABC(out double a, out double b, out double c)
        {
            a = this.a;
            b = this.b;
            c = this.c;
        }
        public double Delta()
        {
            return Math.Pow(b, 2) - 4 * a * c;
        }
        public double X1()
        {
            return -b + Math.Sqrt(Delta()) / 2 * a;
        }
        public double X2()
        {
            return -b - Math.Sqrt(Delta()) / 2 * a;
        }
    }
}
