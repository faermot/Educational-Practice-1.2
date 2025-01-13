using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task12 : IPrintOfSolution
    {
        double K, t, x;

        public Task12(double t, double x)
        {
            this.t = t;
            this.x = x;
        }

        public void PrintSolution()
        {
            K = 7 * Math.Pow(t, 2) + 3 * Math.Sin(Math.Pow(x, 3)) + 9.2;

            Console.WriteLine($"K = {K}");
        }
    }
}
