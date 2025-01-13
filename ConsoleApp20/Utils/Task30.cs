using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task30 : IPrintOfSolution
    {
        double W, e, y, r;

        public Task30(double e, double y, double r)
        {
            this.e = e;
            this.y = y;
            this.r = r;
        }

        public void PrintSolution()
        {
            W = Math.Pow(e, y + r) + 7.2 * Math.Sin(r);

            Console.WriteLine($"W = {W}");
        }
    }
}
