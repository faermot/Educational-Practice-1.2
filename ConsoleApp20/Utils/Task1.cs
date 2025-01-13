using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task1 : PrintOfSolution
    {
        double R, t, l;

        public Task1(double t, double l)
        {
            this.t = t;
            this.l = l;
        }

        public void PrintSolution()
        {
            R = 3 * Math.Pow(t, 2) + 3 * Math.Pow(l, 5) + 4.9;

            Console.WriteLine($"R = {R}");
        }
    }
}
