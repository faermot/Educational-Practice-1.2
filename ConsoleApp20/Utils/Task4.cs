using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task4 : IPrintOfSolution
    {
        double D, a, t;

        public Task4(double a, double t)
        {
            this.a = a;
            this.t = t;
        }

        public void PrintSolution()
        {
            D = 9.8 * Math.Pow(a, 2) + 5.52 * Math.Cos(Math.Pow(t, 5));

            Console.WriteLine($"D = {D}");
        }
    }
}
