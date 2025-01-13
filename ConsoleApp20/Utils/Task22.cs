using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20.Utils
{
    public class Task22 : IPrintOfSolution
    {
        double T, u, y, x;

        public Task22(double u, double y, double x)
        {
            this.u = u;
            this.y = y;
            this.x = x;
        }

        public void PrintSolution()
        {
            T = Math.Sin(2 * u) * Math.Log(2 * Math.Pow(y, 2) + Math.Sqrt(x));

            Console.WriteLine($"T = {T}");
        }
    }
}
