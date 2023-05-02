using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ParabolaCalc
{
    class Solver
    {
        double a = 1.0;
        double b = 0.0;
        double c = 0.0;
        public Solver(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public string GetAppearance()
        {
            StringBuilder builder = new StringBuilder(100);
            if (a == 1.0) builder.Append("y = x²");
            else builder.AppendFormat("y = {0}x²", a);
            if (b > 0) builder.AppendFormat(" +{0}x", b);
            else if (b < 0) builder.AppendFormat(" {0}x", b);
            if (c > 0) builder.AppendFormat(" +{0}", c);
            else if (c < 0) builder.AppendFormat(" {0}", c);
            return builder.ToString();
        }
        public (Complex, Complex) CalculateRoots()
        {
            Complex D = b * b - 4.0 * a * c;
            D = Complex.Sqrt(D);
            Complex x1 = (-b - D) / (2.0 * a);
            Complex x2 = (-b + D) / (2.0 * a);
            return (x1, x2);
        }
    }
}
