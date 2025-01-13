using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task27 : IPrintOfSolution
    {
        double W, v, e, y, x;

        public Task27(double v, double e, double y, double x)
        {
            this.v = v;
            this.e = e;
            this.y = y;
            this.x = x;
        }

        public void PrintSolution()
        {
            W = 1.03 * v + Math.Pow(e, 2 * y) + Math.Tan(Math.Abs(x));

            Console.WriteLine($"W = {W}");
        }
    }
}
