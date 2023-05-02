using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
