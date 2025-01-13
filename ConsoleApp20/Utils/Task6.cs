using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task6 : PrintOfSolution
    {
        double M, y, e, x;

        public Task6(double y, double e, double x)
        {
            this.y = y;
            this.e = e;
            this.x = x;
        }

        public void PrintSolution()
        {
            M = Math.Cos(2 * y) + 3.6 * Math.Pow(e, x);

            Console.WriteLine($"M = {M}");
        }
    }
}
