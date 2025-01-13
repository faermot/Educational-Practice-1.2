using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task7 : IPrintOfSolution
    {
        double N, m;

        public Task7(double m)
        {
            this.m = m;
        }

        public void PrintSolution()
        {
            N = Math.Pow(m, 2) + 2.8 * Math.Abs(m) + 0.55;

            Console.WriteLine($"N = {N}");
        }
    }
}
