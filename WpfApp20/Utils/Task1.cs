using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23.Utils
{
    public class Task1
    {
        public static double Calculate(Dictionary<string, double> vars)
        {
            double x = vars["x"];
            double y = vars["y"];
            double f = vars["f"];
            return Math.Exp(x) * Math.Sin(f) / Math.Log(3.8 * y + f);
        }
    }
}
