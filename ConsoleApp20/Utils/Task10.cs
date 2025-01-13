using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task10 : IPrintOfSolution
    {
        double U, e, x, k, y;

        public Task10(double e, double x, double k, double y)
        {
            this.e = e;
            this.x = x;
            this.k = k;
            this.y = y;
        }

        public void PrintSolution()
        {
            U = Math.Pow(e, y) + 7.355 * Math.Pow(k, 2) * Math.Sin(Math.Pow(x, 2));

            Console.WriteLine($"U = {U}");
        }
    }
}
