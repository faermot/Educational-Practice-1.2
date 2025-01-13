using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task19 : IPrintOfSolution
    {
        double P, n, y, g;

        public Task19(double n, double y, double g)
        {
            this.n = n;
            this.y = y;
            this.g = g;
        }

        public void PrintSolution()
        {
            P = n * Math.Sqrt(Math.Pow(y, 3) + 1.09 * g);

            Console.WriteLine($"P = {P}");
        }
    }
}
